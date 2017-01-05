using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {

    class WhileLoop : BodyNode {

        public Node Condition { get; set; }

        public WhileLoop(Body bodyTable) : base(DataType.NotAType, "%wl", bodyTable) {
        }

        #region IXmlSerializable implementation

        public WhileLoop() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("While");
            writer.WriteStartElement("Condition");
            this.Condition.WriteXml(writer);
            writer.WriteEndElement();
            this.BodyTable.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
