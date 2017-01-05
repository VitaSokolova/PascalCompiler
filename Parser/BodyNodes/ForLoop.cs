using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes
{
    class ForLoop : BodyNode {

        public Node VarNode { get; set; }
        public Node CondNode { get; set; }
        public Node Incremental { get; set; }

        public ForLoop(Body bodyTable) : base(DataType.NotAType, "%for", bodyTable) {
        }

        public override T FindNodeByName<T>(string name) {
            if (this.VarNode is T && this.VarNode.Name == name) {
                return this.VarNode as T;
            }

            if (this.VarNode is Expression) {
                var exprNode = (Expression) this.VarNode;

                if (exprNode.LeftNode is T && exprNode.LeftNode.Name == name) {
                    return exprNode.LeftNode as T;
                }
            }
            return base.FindNodeByName<T>(name);
        }

        #region IXmlSerializable implementation

        public ForLoop() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("For");

            writer.WriteStartElement("VarNode");
            this.VarNode.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("CondNode");
            this.CondNode.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteStartElement("Increment");
            this.Incremental.WriteXml(writer);
            writer.WriteEndElement();

            this.BodyTable.WriteXml(writer);

            writer.WriteEndElement();
        }

        #endregion
    }
}
