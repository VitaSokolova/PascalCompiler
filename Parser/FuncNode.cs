using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser
{
    public class FuncNode: Node
    {
        public Table BodyTable { get; }
        public List<StructVariableNode> Args { get; }

        public FuncNode(string name, Abstract.Type type, Table bodyTable, List<StructVariableNode> args) : base(name, type)
        {
            this.BodyTable = bodyTable;
            this.Args = args;
        }

        public FuncNode() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("FuncNode");

            base.WriteXml(writer);

            writer.WriteStartElement("Args");
            foreach (var variableNode in this.Args) {
                variableNode.WriteXml(writer);
            }

            writer.WriteEndElement();

            writer.WriteStartElement("Body");
            this.BodyTable.WriteXml(writer);
            writer.WriteEndElement();

            writer.WriteEndElement();
        }
    }
}
