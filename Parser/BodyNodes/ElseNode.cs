using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {
    public class ElseNode : BodyNode {

        public ElseNode(Body bodyTable, DataType dataType = DataType.NotAType, string name = "%else")
            : base(dataType, name, bodyTable) {
        }

        #region IXmlSerializable implementation

        public ElseNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ElseNode");
            this.BodyTable.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
