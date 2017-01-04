using System;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser.Nodes {
    [Serializable]
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

        public bool IsValid => this.Type != Abstract.Type.Error;

        public Expression(Node leftNode, Node rightNode, ExprToken exprToken) {
            this.LeftNode = leftNode;
            this.RightNode = rightNode;
            this.ExprToken = exprToken;
            this.Name = "expr";
            this.ChecValidExpr();
        }

        public Expression() {
            
        }

        public void ChecValidExpr() {
            if (this.LeftNode.Type != this.RightNode.Type) {
                this.Type = Abstract.Type.Error;
                return;
            }
            else {
                this.Type = this.LeftNode.Type;
            }

            switch (this.ExprToken) {
                case ExprToken.IsEqual: {
                    bool type = this.Type == Abstract.Type.VarBool;
                    type = type || this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    this.Type = Abstract.Type.VarBool;
                    break;
                }
                case ExprToken.IsLess: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    this.Type = Abstract.Type.VarBool;
                    break;
                }
                case ExprToken.IsMore: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                        this.Type = Abstract.Type.VarBool;
                        break;
                }
                case ExprToken.IsLessOrEqual: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                        this.Type = Abstract.Type.VarBool;
                        break;
                }
                case ExprToken.IsMoreOrEqual: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                        this.Type = Abstract.Type.VarBool;
                        break;
                }
                case ExprToken.Add: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Sub: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Mult: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Div: {
                    bool type = this.Type == Abstract.Type.VarChar;
                    type = type || this.Type == Abstract.Type.VarFloat;
                    type = type || this.Type == Abstract.Type.VarInt;
                    if (!type) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Conj: {
                    if (this.Type != Abstract.Type.VarBool) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Dij: {
                    if (this.Type != Abstract.Type.VarBool) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Neg: {

                    if (this.Type != Abstract.Type.VarBool) {
                        this.Type = Abstract.Type.Error;
                    }
                    break;
                }
                case ExprToken.Ass: {
                    break;
                }
            }
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Expression");
            base.WriteXml(writer);
            writer.WriteStartElement("LeftNode");
            this.LeftNode.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("RightNode");
            this.RightNode.WriteXml(writer);
            writer.WriteEndElement();

           // writer.WriteAttributeString("ExprToken", this.ExprToken.ToString());
           // writer.WriteAttributeString("IsValid", this.IsValid.ToString());
            writer.WriteEndElement();
        }

        public new static Abstract.Type GetType(string type) {
            switch (type) {
                case "integer":
                    return Abstract.Type.VarInt;
//                case "real":
  //                  return Abstract.Type.VarFloat;
                case "boolean":
                    return Abstract.Type.VarBool;
    //            case "string":
      //              return Abstract.Type.VarString;
                case "char":
                    return Abstract.Type.VarChar;
                case "_integer":
                    return Abstract.Type.ArrInt;
        //        case "_real":
          //          return Abstract.Type.ArrFloat;
                case "_boolean":
                    return Abstract.Type.ArrBool;
            //    case "_string":
              //      return Abstract.Type.ArrString;
                case "_char":
                    return Abstract.Type.ArrChar;
                case "void":
                    return Abstract.Type.Void;
            }
            return Abstract.Type.Error;
        }
    }
}
