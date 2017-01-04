using CompilerConsole.Parser.Abstract;
using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Parser.BodyNodes;

namespace CompilerConsole.Parser.CallNodes {

    public class FuncCall : Node {

        public FuncNode Method { get; set; }

        public List<Node> SendArgs { get; set; }

        public FuncCall(FuncNode method) : base(method.DataType, "%mc" + method.Name) {
            this.Method = method;
            this.SendArgs = new List<Node>();
        }

        #region IXmlSerializable implementation

        public FuncCall() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("MethCallNode");
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Func", this.Method.Name);
            writer.WriteStartElement("SendArgs");
            foreach (var sendArg in this.SendArgs) {
                sendArg.WriteXml(writer);
            }
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        #endregion
    }
}
