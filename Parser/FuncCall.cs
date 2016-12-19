using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser
{
    public class FuncCall:Node {
        public FuncNode Func { get; set; }
        public List<VariableNode> Args { get; set; }


        public FuncCall(string name, string type, FuncNode func) : base(name, type) {
            this.Func = func;
            this.Args = new List<VariableNode>();
        }

        public FuncCall() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("FuncCall");
            base.WriteXml(writer);
            writer.WriteStartElement("Args");
            foreach (var variableNode in this.Args) {
                variableNode.WriteXml(writer);
            }

            writer.WriteEndElement();
            writer.WriteEndElement();
        }
    }
}
