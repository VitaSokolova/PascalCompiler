using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {
    public class IfNode : BodyNode {
        public Node Condition { get; set; }
        public ElseNode ElseBody { get; set; }

        public IfNode(Body bodyTable) : base(DataType.NotAType, "%Ifn", bodyTable) {
        }

        public override T FindNodeByName<T>(string name) {
            return this.FindNodeByName<T>(name, this);
        }

        #region IXmlSerializable implementation

        public IfNode() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("IfNode");
            writer.WriteStartElement("Condition");
            this.Condition.WriteXml(writer);
            writer.WriteEndElement();
            this.BodyTable.WriteXml(writer);
            this.ElseBody.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
