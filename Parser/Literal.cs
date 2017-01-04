using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser {
    public class Literal : Node {

        public object Value { get; set; }

        public Literal(DataType dataType,object value, string name = "%lit") : base(dataType, name) {
            this.Value = value;
        }



        #region IXmlSerializable implementation

        public Literal() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Literal");
            base.WriteXml(writer);
            writer.WriteAttributeString("Value", this.Value.ToString());
            writer.WriteEndElement();
        }

        #endregion
    }
}
