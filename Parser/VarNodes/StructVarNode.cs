using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser.VarNodes {

    public class StructVarNode : VariableNode {

        public StructVarNode(DataType dataType, string name) : base(dataType, name) {
        }

        #region IXmlSerializable implementation

        public StructVarNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("StructVarNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
