using CompilerConsole.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Parser.VarNodes;

namespace CompilerConsole.Parser.CallNodes {
    public class ArrCall : Node {
        public ArrNode Arr { get; set; }

        public Node Index { get; set; }

        public Node Assign { get; set; }

        public ArrCall(ArrNode arr) : base(ArrNode.ArrTypeToVarType(arr.DataType), "%ac" + arr.Name) {
            this.Arr = arr;
        }

        #region IXmlSerializable implementation

        public ArrCall() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrCallNode");
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Arr", this.Arr.Name);
            writer.WriteStartElement("Index");
            this.Index.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        #endregion
    }
}
