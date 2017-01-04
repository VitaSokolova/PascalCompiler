using System;
using System.Collections.Generic;
using Antlr.Runtime.Tree;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Parser.VarNodes;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser {

    public partial class Parser {

        #region Constants

        private const string TypeDecl = "TYPE_DECL";
        private const string ArrDecl = "ARR_DECL";

        #endregion

        private List<VariableNode> ParseVarDecl(ITree tree, BodyNode bodyNode) {
            //Подразумевается, что нам сюда пришел itree = VAR_DECL

            List<VariableNode> variableNodesList = new List<VariableNode>();

            List<string> variableNames = new List<string>();
            for (int i = 0; i < tree.ChildCount; i++) {
                if (tree.GetChild(i).Text == TypeDecl) {

                    ITree typeDeclChild = tree.GetChild(i).GetChild(0);

                    if (typeDeclChild.Text == ArrDecl) {

                        #region Array declaration parsing

                        //Здесь typeDeclChild равен ARR_DECL
                        DataType type = this.StringToArrDataType(typeDeclChild.GetChild(1).GetChild(0).Text);
                        ITree range = typeDeclChild.GetChild(0); //здесь хранится узел Range

                        //Должны парситя выражения, но мы то знаем, что там целичисленные литералы (:
                        Literal leftSide = this.GetLiteralFromString(range.GetChild(0).Text);
                        Literal rightSide = this.GetLiteralFromString(range.GetChild(1).Text);

                        if (leftSide.DataType != DataType.VarInt || rightSide.DataType != DataType.VarInt) {
                            throw new InvalidCastException("Попытка присвоить разерности массива нецелочисленный размер");
                        }
                        int leftSize = (int) leftSide.Value;
                        int rightSize = (int) rightSide.Value;

                        if (leftSize < 0 && rightSize < 0) {
                            throw new InvalidCastException("Попытка присвоить разерности массива отрицательный размер");
                        }

                        foreach (var variableName in variableNames) {
                            variableNodesList.Add(new ArrNode(type, variableName, leftSize, rightSize));
                        }

                        #endregion

                    }
                    else {
                        //Здесь typeDeclChild равен какому-то типу данных
                        DataType type = this.StringToVarDataType(typeDeclChild.Text);
                        foreach (var variableName in variableNames) {
                            variableNodesList.Add(new StructVarNode(type, variableName));
                        }
                    }

                    variableNames.Clear();
                    continue;
                }
                variableNames.Add(tree.GetChild(i).Text);
            }
            //Проверяем на повторение имен переменных
            foreach (var variableNode in variableNodesList) {
                var node = bodyNode.FindNodeByName<VariableNode>(variableNode.Name);
                if (node != null) {
                    throw new NodeExistException(
                        $"Переменная с именем {variableNode.Name} уже существует в текущем контексте");
                }
            }
            //Проверяем на то, повторяются ли переменные при объявлении
            foreach (var variableNode in variableNodesList) {
                var find = variableNodesList.Find(node => node.Name == variableNode.Name && !node.Equals(variableNode));

                if (find != null) {
                    throw new NodeExistException(
                        $"Переменная с именем {variableNode.Name} уже существует в текущем контексте");
                }
            }

            return variableNodesList;
        }

    }
}
