using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser
{
    public class StructVariableNode: VariableNode
    {
        public StructVariableNode(string name, Abstract.Type type, string modificator, VarType varType = VarType.Struct) : base(name, type, modificator, varType) {
        }

        public StructVariableNode() {
            
        }

        public override bool Equals(object obj)
        {
            if (this == null)
            {
                return false;
            }

            StructVariableNode temp = obj as StructVariableNode;
            if (temp == null)
            {
                return false;
            }
            if (this.Type != temp.Type)
            {
                return false;
            }
            if (String.CompareOrdinal(this.Name, temp.Name) != 0)
            {
                return false;
            }
            return true;
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("StructVariableNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
            
        }
    }
}
