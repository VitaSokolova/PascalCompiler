using System;
using System.Collections.Generic;
using System.Text;
using CompilerConsole.Parser;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.BodyNodes;
using CompilerConsole.Parser.CallNodes;
using CompilerConsole.Parser.VarNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.ILGenerator {
    public partial class Generator {
        public string LineNumber => this.PreLineNumber + this.Counter++ + ":" + this.Offset;

        /// <summary>
        /// IL_
        /// </summary>
        public string PreLineNumber = "IL_";

        /// <summary>
        /// Счетчик строк
        /// </summary>
        public int Counter;

        /// <summary>
        /// Это символ табуляции
        /// </summary>
        public string Offset = "\t";

        /// <summary>
        /// Генерирует IL код для методы
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать IL код</param>
        /// <returns></returns>
        private string GenerateILMethod(FuncNode method) {
            this.Counter = 0;
            StringBuilder methodIL = new StringBuilder();
            string startMethodIL;
            //Дело в том, что массивы в паскале не канает инитить так же ка и в си. Поэтому будем извращаться
            StringBuilder arrays = new StringBuilder();

            #region Method start

            if (method.Name == Parser.Parser.Main) {
                startMethodIL = this.Reader(Template.DeclMainFunc);

                foreach (var node in method.ParentBodyNode) {
                    if (node is ArrNode) {
                        arrays.AppendLine(this.ExpressionToIL(node));
                    }
                }
            }
            else {
                startMethodIL = this.Reader(Template.StartFuncDecl);
                startMethodIL = startMethodIL.Replace("{type}", ToCILVariableType(method.DataType));

                foreach (var node in method) {
                    if (node is ArrNode) {
                        arrays.AppendLine(this.ExpressionToIL(node));
                    }
                }
            }

            startMethodIL = startMethodIL.Replace(this._cilReplacedToken[ILReplacedToken.MethodName], method.Name);
            //Генерирем аргументы и включаем их в шаблон
            startMethodIL = startMethodIL.Replace(this._cilReplacedToken[ILReplacedToken.MethodArgs],
                this.GenerateArgs(method));

            #endregion

            #region Methpd body

            methodIL.AppendLine(startMethodIL);
            //Генерация декларации локальных переменных
            string localVardeclTemplate = this.Reader(Template.LocalvariableDeclaration);
            localVardeclTemplate = localVardeclTemplate.Replace(this._cilReplacedToken[ILReplacedToken.Variables],
                this.GenerateLocalVariableDeclaration(method));
            methodIL.AppendLine(localVardeclTemplate);

            //Генерация IL кода для выражений
            methodIL.AppendLine(arrays.ToString());
            methodIL.AppendLine(this.GenerateExpression(method));

            #endregion

            #region Method end

            //Генерация IL кода для окончания декларации метода
            string methodEnd = this.Reader(Template.DeclFuncFinich);
            //Здесь мы указываем возвращаемое значение, ели оно есть
            if (method.DataType != DataType.Void) {
                methodIL.AppendLine(this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                    this.Offset + 0);
            }

            methodIL.AppendLine(this.LineNumber + "ret");
            methodIL.AppendLine(methodEnd);

            #endregion

            return methodIL.ToString();
        }

        #region Method body decomposition

        /// <summary>
        /// Генерирует IL код, для аргументов метода
        /// </summary>
        /// <param name="method">Метод, для которого нужно сгенерировать аргументы</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateArgs(FuncNode method) {
            StringBuilder args = new StringBuilder();
            for (int i = 0; i < method.Args.Count; i++) {
                var variableNode = method.Args[i];
                args.Append(this.Offset + this.GenerateFuncArg(variableNode));
                if (method.Args.Count > 1 && i != method.Args.Count - 1) {
                    args.Append(",");
                }
                args.AppendLine();
            }

            return args.ToString();
        }

        /// <summary>
        /// Выбирает все локальные переменные из тела узла, зате удаляет их из него
        /// </summary>
        /// <param name="bodeNode">узел, из которого нужно выбрать все локаьные переменные</param>
        /// <returns>Выбранные локлаьные переменные</returns>
        private List<VariableNode> GetAllLocalVariables(BodyNode bodeNode) {
            var variables = new List<VariableNode>();

            foreach (var node in bodeNode) {
                if (node is VariableNode) {
                    variables.Add(node as VariableNode);
                }

                if (node is BodyNode) {
                    variables.AddRange(this.GetAllLocalVariables(node as BodyNode));
                }
            }

            foreach (var variableNode in variables) {
                if (!(variableNode is ArrNode))
                    bodeNode.RemoveNode(variableNode);
            }

            return variables;
        }

        /// <summary>
        /// Гененрирует IL код, отвечающий за объявление локальных переменных внутри метода
        /// </summary>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateLocalVariableDeclaration(BodyNode bodeNode) {
            StringBuilder localVariables = new StringBuilder();

            List<VariableNode> variables = this.GetAllLocalVariables(bodeNode);
            //теперь заносим их в IL
            for (int i = 0; i < variables.Count; i++) {
                localVariables.Append(this.GenerateVarDecl(variables[i]));
                if (variables.Count > 1 && i < variables.Count - 1) {
                    localVariables.Append(",");
                }
                localVariables.AppendLine();
            }

            return localVariables.ToString();
        }

        /// <summary>
        /// Генерирует IL код соответствующи различным операциям
        /// </summary>
        /// <param name="method">Метод, выражения в теле которого необходимо сгенерировать в виде IL кода</param>
        /// <returns>IL кода</returns>
        private string GenerateExpression(FuncNode method) {
            StringBuilder expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (Node node in method.BodyTable.Nodes) {
                var result = this.ExpressionToIL(node);

                if (!String.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }

        #endregion

        /// <summary>
        /// Генерирует IL код для объявления глобальных переменных
        /// </summary>
        /// <param name="body">Тело, из которого нужно извлечь объявление глобальных переменных и сгененрировать для них IL код</param>
        /// <returns>Сгенерированный IL код</returns>
        private string GenerateGlobalVar(BodyNode body) {
            StringBuilder fields = new StringBuilder();
            foreach (var node in body) {
                if (!(node is VariableNode)) continue;
                if (!(node as VariableNode).IsGlobal) continue;
                var decl = this.Reader(Template.FieldDecl);
                decl = decl.Replace("{name}", node.Name);
                decl = decl.Replace("{type}", ToCILVariableType(node.DataType));
                fields.AppendLine(decl);
            }
            return fields.ToString();
        }

        #region Utils

        public string ExpressionToIL(Node node) {
            if (node is StructVarNode) {
                return this.GenerateILSructVarNode((VariableNode) node);
            }

            if (node is ArrCall) {
                return this.GenerateILArrCall((ArrCall) node);
            }

            if (node is FuncCall) {
                return this.GenerateILMethCall((FuncCall) node);
            }

            if (node is Expression) {
                return this.ActionExprToIL((Expression) node);
            }

            if (node is Literal) {
                return this.LineNumber + this.GenerateILLiterals((Literal) node);
            }
            if (node is ArrNode) {
                return this.GenerateILArrNodeDecl((ArrNode) node);
            }
            if (node is IfNode) {
                return this.GenerateILIfNode((IfNode) node);
            }
            if (node is ForLoop) {
                return this.GenerateILForLoop((ForLoop) node);
            }
            return null;
        }

        #region Generarate IL for non expression nodes

        private string GenerateILForLoop(ForLoop forNode) {
            var varE = this.ExpressionToIL(forNode.VarNode) + Environment.NewLine;
            var goToCondition = this.LineNumber + "br" + this.Offset;
            var body = this.ParseBody(forNode.BodyTable);
            var counter = GetLineNumber(body);
            var incremental = this.ExpressionToIL(forNode.Incremental) + Environment.NewLine;
            goToCondition += this.PreLineNumber + this.Counter + Environment.NewLine;
            var condition = this.ExpressionToIL(forNode.CondNode) + Environment.NewLine;
            condition += this.LineNumber + this.Offset + "brtrue" + this.Offset + this.PreLineNumber + counter;
            return varE + goToCondition + body + incremental + condition;
        }

        private string GenerateILIfNode(IfNode ifNode) {
            var cond = this.ExpressionToIL(ifNode.Condition) + Environment.NewLine; //Гнерируем IL код для условия
            cond = cond.Replace("{end line}", this.PreLineNumber + this.Counter);
            var goTo = this.LineNumber + this.Offset + "brfalse"; //Сюда еще бы доваить ссылку на елс

            var body = this.ParseBody(ifNode.BodyTable); //Генерируем IL код для тела ифа

            var tempCounter = this.Counter;
            var elseBody = "";
            if (ifNode.ElseBody != null) {
                tempCounter++;
                body += this.LineNumber + this.Offset + "br" + this.Offset;
                elseBody = this.ParseBody(ifNode.ElseBody.BodyTable);
                body += this.PreLineNumber + this.Counter;
            }
            goTo += this.Offset + this.PreLineNumber + tempCounter + Environment.NewLine;
            body += Environment.NewLine;
            return cond + goTo + body + elseBody;
        }

        private string GenerateILArrNodeDecl(ArrNode arr) {
            var arrSize = this.ExpressionToIL(new Literal(DataType.VarInt, arr.Length)) + Environment.NewLine;
            var arrDecl = this.Reader(Template.ArrDecl);
            var t = ToCILVariableType(arr.DataType);
            t = t.Replace("[]", "");
            var fc = t[0];
            t = t.Remove(0, 1);
            t = t.Insert(0, char.ToUpper(fc).ToString());
            arrDecl = this.LineNumber + arrDecl.Replace("{type}", t) + Environment.NewLine;
            string writeArr;
            if (arr.IsGlobal) {
                var callField = this.Reader(Template.CallField)
                    .Replace("{type}", ToCILVariableType(arr.DataType));
                callField = callField.Replace("{name}", arr.Name);
                writeArr = this._operationDictionary[ILOperation.WriteField] + this.Offset + callField;
            }
            else {
                writeArr = this._operationDictionary[ILOperation.WriteLocalVariable] + this.Offset + arr.Number;
            }
            return arrSize + arrDecl + this.LineNumber + writeArr;
        }

        private string GenerateILArrCall(ArrCall arr) {
            string arrCall;
            if (arr.Arr.IsGlobal) {
                var callField = this.Reader(Template.CallField)
                    .Replace("{type}", ToCILVariableType(arr.Arr.DataType));
                callField = callField.Replace("{name}", arr.Arr.Name);

                arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset +
                          callField +
                          Environment.NewLine;
            }
            else {
                if (arr.Arr.IsMethodArg) {
                    arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                }
                else {
                    arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                              this.Offset +
                              arr.Arr.Number + Environment.NewLine;
                }
            }
            var index = this.ExpressionToIL(arr.OffsetIndex) + Environment.NewLine;
            var load = arr.Arr.DataType == DataType.ArrString
                ? this._operationDictionary[ILOperation.ReadArrRefElement]
                : this._operationDictionary[ILOperation.ReadArrStructElement];

            return arrCall + index + this.LineNumber + load;
        }

        private string GenerateILSructVarNode(VariableNode varNode) {
            if (varNode.IsGlobal) {
                string field = this.Reader(Template.CallField);
                field = field.Replace("{type}", ToCILVariableType(varNode.DataType));
                field = field.Replace("{name}", varNode.Name);
                return this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
            }
            var operation = varNode.IsMethodArg
                ? this._operationDictionary[ILOperation.ReadMethodArg]
                : this._operationDictionary[ILOperation.ReadLocalVariable];

            return this.LineNumber + operation + this.Offset + varNode.Number;
        }

        private string GenerateILMethCall(FuncCall methCallNode) {
            StringBuilder methodCall = new StringBuilder();
            foreach (var sendArg in methCallNode.SendArgs) {
                if (sendArg is ArrNode) {
                    methodCall.AppendLine(this.GenerateILSructVarNode((VariableNode) sendArg));
                }
                else {
                    methodCall.AppendLine(this.ExpressionToIL(sendArg));
                }
            }

            switch (methCallNode.Method.Name) {
                case Parser.Parser.WriteMethodName: {
                    var type = methCallNode.SendArgs.Count != 0 ? methCallNode.SendArgs[0].DataType : DataType.Void;
                    methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                      this.Reader(Template.ConsoleWriteLine)
                                          .Replace("{type}", ToCILVariableType(type)));
                    break;
                }
                case Parser.Parser.ReadMethodName: {
                    //Если вызываем ввод из консоли
                    methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                      this.Reader(Template.ConsoleReadLine));
                    break;
                }
                case Parser.Parser.ReadFile: {
                    methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                      this.Reader(Template.ReadFile));
                    break;
                }
                default: {
                    string method = this.Reader(Template.CallMethod);
                    method = method.Replace("{type}", ToCILVariableType(methCallNode.Method.DataType));
                    method = method.Replace("{name}", methCallNode.Method.Name);

                    string args = "";

                    for (int i = 0; i < methCallNode.SendArgs.Count; i++) {
                        var sendArg = methCallNode.SendArgs[i];
                        args += ToCILVariableType(sendArg.DataType);
                        if (methCallNode.SendArgs.Count > 1 && i != methCallNode.SendArgs.Count - 1) {
                            args += ", ";
                        }
                    }
                    method = method.Replace("{args}", args);
                    methodCall.Append(this.LineNumber + this._operationDictionary[ILOperation.Call] + this.Offset +
                                      method);
                    break;
                }
            }
            return methodCall.ToString();
        }

        private string GenerateILLiterals(Literal literal) {
            var result = "";

            switch (literal.DataType) {
                case DataType.VarInt:
                    result = this._operationDictionary[ILOperation.IntConstLoad] + this.Offset +
                             literal.Value;
                    break;
                case DataType.VarString:
                    return this._operationDictionary[ILOperation.StringConstLoad] + this.Offset +
                           literal.Value;
                case DataType.VarChar:
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset +
                           (int) (char) literal.Value;
                case DataType.VarBool:
                    var boolRes = literal.Value.ToString() == "False" ? "0" : "1";
                    return this._operationDictionary[ILOperation.IntConstLoad] + this.Offset + boolRes;
                default:
                    throw new ArgumentOutOfRangeException($"GenerateConstIL странный тип {literal.DataType}");
            }
            return result;
        }

        private string GenerateFuncArg(Node variable) => $"{ToCILVariableType(variable.DataType)} {variable.Name}";

        private string GenerateVarDecl(VariableNode node)
            => $"{this.Offset} [{node.Number}] {ToCILVariableType(node.DataType)} {node.Name}";

        #endregion

        private string ParseBody(Body body) {
            StringBuilder expressions = new StringBuilder();
            //Начинаем парсить выражения
            foreach (Node node in body.Nodes) {
                string result = this.ExpressionToIL(node);

                if (!String.IsNullOrEmpty(result)) {
                    expressions.AppendLine(result);
                }
            }
            return expressions.ToString();
        }

        public string ActionExprToIL(Expression node) {
            switch (node.ExprToken) {
                case ExprToken.IsEqual: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op;
                }
                case ExprToken.IsLess: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = this.LineNumber + this._operationDictionary[ILOperation.Less];
                    return exprl + exprr + op;
                }
                case ExprToken.IsMore: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = this.LineNumber + this._operationDictionary[ILOperation.More];
                    return exprl + exprr + op;
                }
                case ExprToken.IsLessOrEqual: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = this.LineNumber + this._operationDictionary[ILOperation.More] + Environment.NewLine;
                    string ln = this.LineNumber + "ldc.i4 0" + Environment.NewLine;
                    string ope = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op + ln + ope;
                }
                case ExprToken.IsMoreOrEqual: {
                    string exprl = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string exprr = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                    string op = this.LineNumber + this._operationDictionary[ILOperation.Less] + Environment.NewLine;
                    string ln = this.LineNumber + "ldc.i4 0" + Environment.NewLine;
                    string ope = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return exprl + exprr + op + ln + ope;
                }
                case ExprToken.Add:
                    return this.GenerateAddExpr(node);
                case ExprToken.Sub:
                    return this.GenerateSubExpr(node);
                case ExprToken.Mult:
                    return this.GenerateMultExpr(node);
                case ExprToken.Div:
                    return this.GenerateDivExpr(node);
                case ExprToken.Conj:
                    return this.GenerateConjExpr(node);
                case ExprToken.Dij:
                    return this.GenerateConjExpr(node);
                case ExprToken.Neg: {
                    string expr = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
                    string lineNum = this.LineNumber;
                    string ln = lineNum + "ldc.i4 0" + Environment.NewLine;
                    expr = expr.Replace("{end line}", lineNum.Replace(":", ""));
                    string op = this.LineNumber + this._operationDictionary[ILOperation.Neg];
                    return expr + ln + op;
                }
                case ExprToken.Ass:
                    return this.AssignExprToIL(node);
                case ExprToken.Error:
                    break;
                default:
                    throw new ArgumentOutOfRangeException();
            }
            return null;
        }

        #region Generate IL for expressions

        public string AssignExprToIL(Expression node) {
            var assignString = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            var writeOpertion = "";
            if (node.LeftNode is ArrCall) {
                var arr = (ArrCall) node.LeftNode;
                string arrCall;
                if (arr.Arr.IsGlobal) {
                    var callField = this.Reader(Template.CallField)
                        .Replace("{type}", ToCILVariableType(arr.Arr.DataType));
                    callField = callField.Replace("{name}", arr.Arr.Name);
                    arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset +
                              callField +
                              Environment.NewLine;
                }
                else {
                    if (arr.Arr.IsMethodArg) {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                    else {
                        arrCall = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                  this.Offset +
                                  arr.Arr.Number + Environment.NewLine;
                    }
                }

                var index = this.ExpressionToIL(arr.OffsetIndex) + Environment.NewLine;
                var righte = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
                var write = arr.Arr.DataType == DataType.ArrString
                    ? this._operationDictionary[ILOperation.WriteArrRefElement]
                    : this._operationDictionary[ILOperation.WriteArrStructElement];

                return arrCall + index + righte + this.LineNumber + write;
            }

            if (node.LeftNode is ArrNode) {
                var arrl = (ArrNode) node.LeftNode;
                var arrr = (ArrNode) node.RightNode;
                string loadRight;
                if (arrr.IsGlobal) {
                    string field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", ToCILVariableType(((ArrNode) node.LeftNode).DataType));
                    field = field.Replace("{name}", ((ArrNode) node.LeftNode).Name);
                    loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadField] + this.Offset + field;
                }
                else {
                    if (arrr.IsMethodArg) {
                        loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadMethodArg] + this.Offset +
                                    arrr.Number + Environment.NewLine;
                    }
                    else {
                        loadRight = this.LineNumber + this._operationDictionary[ILOperation.ReadLocalVariable] +
                                    this.Offset +
                                    arrr.Number + Environment.NewLine;
                    }
                }
                string loadLeft;
                if (arrl.IsGlobal) {
                    var field = this.Reader(Template.CallField);
                    field = field.Replace("{type}", ToCILVariableType(((ArrNode) node.LeftNode).DataType));
                    field = field.Replace("{name}", ((ArrNode) node.LeftNode).Name);
                    loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteField] + this.Offset + field;
                }
                else {
                    if (arrl.IsMethodArg) {
                        loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteMethodArg] + this.Offset +
                                   arrr.Number + Environment.NewLine;
                    }
                    else {
                        loadLeft = this.LineNumber + this._operationDictionary[ILOperation.WriteLocalVariable] +
                                   this.Offset +
                                   arrr.Number + Environment.NewLine;
                    }
                }
                return loadRight + loadLeft;
            }

            var writeLineNumber = "";
            if (((VariableNode) node.LeftNode).IsGlobal) {
                var field = this.Reader(Template.CallField);
                field = field.Replace("{type}", ToCILVariableType(((VariableNode) node.LeftNode).DataType));
                field = field.Replace("{name}", ((VariableNode) node.LeftNode).Name);
                writeLineNumber = this.LineNumber;
                writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteField] + this.Offset +
                                field;
            }

            else {
                writeLineNumber = this.LineNumber;
                if (((VariableNode) node.LeftNode).IsMethodArg) {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteMethodArg];
                }
                else {
                    writeOpertion = writeLineNumber + this._operationDictionary[ILOperation.WriteLocalVariable];
                }
                writeOpertion += this.Offset + ((VariableNode) node.LeftNode).Number;
            }
            assignString = assignString.Replace("{end line}", writeLineNumber.Replace(":", ""));
            var writeAssignString = writeOpertion;
            return assignString + writeAssignString;
        }

        private string GenerateConjExpr(Expression expr) {
            var left = this.ExpressionToIL(expr.LeftNode) + Environment.NewLine;

            var op = "";
            switch (expr.ExprToken) {
                case ExprToken.Conj: {
                    op = this._operationDictionary[ILOperation.Conj].Replace("{opline}", this.LineNumber) +
                         Environment.NewLine;
                    break;
                }
                case ExprToken.Dij: {
                    op = this._operationDictionary[ILOperation.Dij].Replace("{opline}", this.LineNumber) +
                         Environment.NewLine;
                    break;
                }
            }
            var right = this.ExpressionToIL(expr.RightNode) + Environment.NewLine;

            var endOp = "";

            switch (expr.ExprToken) {
                case ExprToken.Conj: {
                    endOp = this.Reader(Template.Conj);
                    break;
                }
                case ExprToken.Dij: {
                    endOp = this.Reader(Template.Dij);
                    break;
                }
            }
            endOp = endOp.Replace("{br line}", this.LineNumber);
            var constLine = this.LineNumber;
            op = op.Replace("{const line}", constLine.Replace(":", ""));
            endOp = endOp.Replace("{const line}", constLine);
            endOp = endOp.Replace("{end}", this.LineNumber + " br {end line}");

            return left + op + right + endOp + Environment.NewLine;
        }

        private string GenerateAddExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Add];
        }

        private string GenerateSubExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Sub];
        }

        private string GenerateMultExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Mul];
        }

        private string GenerateDivExpr(Expression node) {
            var left = this.ExpressionToIL(node.LeftNode) + Environment.NewLine;
            var right = this.ExpressionToIL(node.RightNode) + Environment.NewLine;
            return left + right + this.LineNumber + this._operationDictionary[ILOperation.Div];
        }

        #endregion

        #region Static methods

        /// <summary>
        /// Переводит тип переменной в тип переменной, понятный CILу
        /// </summary>
        /// <param name="type">тип переменной, который нужно перевести в CIL тип</param>
        /// <returns>строковое представление CIL типа</returns>
        private static string ToCILVariableType(DataType type) {
            switch (type) {
                case DataType.VarInt:
                    return "int32";
                case DataType.VarString:
                    return "string";
                case DataType.VarChar:
                    return "char";
                case DataType.VarBool:
                    return "bool";
                //Просто чтоб ошибка не вылетала - нужно дописать
                case DataType.ArrInt:
                    return "int32[]";
                case DataType.ArrString:
                    return "string[]";
                case DataType.ArrChar:
                    return "char[]";
                case DataType.ArrBool:
                    return "bool[]";
                case DataType.Void:
                    return "void";
            }
            return null;
        }

        /// <summary>
        /// Эо функция - костыль. Бывают такие ситуации, когда без нее не обойтись ни как. Вообще ни как
        /// </summary>
        /// <param name="text"></param>
        /// <returns></returns>
        private static string GetLineNumber(string text) {
            string res = "";
            for (int i = 0; i < text.Length; i++) {
                if (text[i] == '_') {
                    for (int j = i + 1; j < text.Length; j++) {
                        if (text[j] == ':') {
                            return res;
                        }
                        res += text[j];
                    }
                }
            }
            return null;
        }

        #endregion


        #endregion
    }
}