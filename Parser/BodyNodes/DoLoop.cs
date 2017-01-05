using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {

    class DoLoop : BodyNode {

        public Node Condition { get; set; }

        public DoLoop(Body bodyTable) : base(DataType.NotAType, "%dwl", bodyTable) {
        }

        #region IXmlSerializable implementation

        public DoLoop() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Do");
            writer.WriteStartElement("Condition");
            this.Condition.WriteXml(writer);
            writer.WriteEndElement();
            this.BodyTable.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
