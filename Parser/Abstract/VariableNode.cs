using System;
using System.Xml;

namespace CompilerConsole.Parser.Abstract {

    public abstract class VariableNode : Node {

        public bool IsMethodArg { get; set; }
        public bool IsGlobal { get; set; }
        public int Number { get; set; }

        public VariableNode(DataType dataType, string name) : base(dataType, name) {
            this.IsGlobal = false;
            this.IsMethodArg = false;
        }


        #region IXmlSerializable implementation

        public VariableNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            base.WriteXml(writer);
            writer.WriteAttributeString("IsMethodArg", this.IsMethodArg.ToString());
            writer.WriteAttributeString("IsGlobal", this.IsGlobal.ToString());
            writer.WriteAttributeString("Number", this.Number.ToString());
        }

        #endregion
    }
}
