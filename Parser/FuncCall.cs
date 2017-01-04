using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser
{
    public class FuncCall:Node {
        public FuncNode Func { get; set; }
        public List<StructVariableNode> Args { get; set; }


        public FuncCall(string name, Abstract.Type type, FuncNode func) : base(name, type) {
            this.Func = func;
            this.Args = new List<StructVariableNode>();
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
