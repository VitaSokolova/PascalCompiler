using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser {

    public enum ExprToken {
        IsEqual,
        IsLess,
        IsMore,
        IsLessOrEqual,
        IsMoreOrEqual,
        Add,
        Sub,
        Mult,
        Div,
        Conj,
        Dij,
        Neg,
        Ass,
        Error
    }

    public class Expression : Node {
        public Node LeftNode { get; set; }
        public Node RightNode { get; set; }

        public ExprToken ExprToken { get; set; }

        public object Result { get; set; }

        public bool IsValid => this.DataType != DataType.Error;

        public Expression(Node leftNode, Node rightNode, ExprToken exprToken) {
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
            this.ExprToken = exprToken;
            this.Name = "%expr";
            this.ChecValidExpr();
        }

        public void ChecValidExpr() {
            if (this.ExprToken == ExprToken.Neg) {
                if (this.LeftNode.DataType != DataType.VarBool) {
                    this.DataType = DataType.Error;
                    return;
                }
                else {
                    this.DataType = DataType.VarBool;
                    return;

                }
            }

            if (this.LeftNode.DataType != this.RightNode.DataType) {
                this.DataType = DataType.Error;
                return;
            }
            else {
                this.DataType = this.LeftNode.DataType;
            }

            switch (this.ExprToken) {
                case ExprToken.IsEqual: {
                    bool type = this.DataType == DataType.VarBool;
                    type = type || this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    type = type || this.DataType == DataType.VarString;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    this.DataType = DataType.VarBool;
                    break;
                }
                case ExprToken.IsLess: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    this.DataType = DataType.VarBool;
                    break;
                }
                case ExprToken.IsMore: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    this.DataType = DataType.VarBool;
                    break;
                }
                case ExprToken.IsLessOrEqual: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    this.DataType = DataType.VarBool;
                    break;
                }
                case ExprToken.IsMoreOrEqual: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    this.DataType = DataType.VarBool;
                    break;
                }
                case ExprToken.Add: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                        type = type || this.DataType == DataType.VarString;
                        if (!type) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Sub: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Mult: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Div: {
                    bool type = this.DataType == DataType.VarChar;
                    type = type || this.DataType == DataType.VarInt;
                    if (!type) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Conj: {
                    if (this.DataType != DataType.VarBool) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Dij: {
                    if (this.DataType != DataType.VarBool) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Neg: {

                    if (this.DataType != DataType.VarBool) {
                        this.DataType = DataType.Error;
                    }
                    break;
                }
                case ExprToken.Ass: {
                    break;
                }
            }
        }


        #region IXmlSerializable implementation

        public Expression() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Expression");
            writer.WriteAttributeString("Expr", this.ExprToken.ToString());
            writer.WriteAttributeString("ExprToken", this.ExprToken.ToString());
            writer.WriteAttributeString("IsValid", this.IsValid.ToString());
            base.WriteXml(writer);
            writer.WriteStartElement("LeftNode");
            this.LeftNode.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteStartElement("RightNode");
            this.RightNode?.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        #endregion
    }
}