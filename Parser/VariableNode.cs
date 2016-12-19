using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;

namespace CompilerConsole.Parser
{
    public enum VarType {
        Reference,
        Struct
    }

    public class VariableNode: Node
    {
        public string Modificator { get; set; }

        /// <summary>
        /// Это тип важен для аргументов функций.
        /// То есть, если в функции аргумент имеет тип Reference, то это ссылочная переменная. Аналог ref в С#
        /// </summary>
        public VarType VarType { get; set; }

        public int IdNumber { get; set; }

        public VariableNode(string name, string type, string modificator, VarType varType = VarType.Struct) : base(name, type) {
            this.Modificator = modificator;
            this.VarType = varType;
        }

        public VariableNode() {
            
        }

        public override bool Equals(object obj)
        {
            if (this == null)
            {
                return false;
            }

            VariableNode temp = obj as VariableNode;
            if (temp == null)
            {
                return false;
            }
            if (String.CompareOrdinal(this.Type, temp.Type) != 0)
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
            writer.WriteStartElement("VariableNode");
            writer.WriteAttributeString("IDNumber", this.IdNumber.ToString());
            base.WriteXml(writer);
            writer.WriteAttributeString("Modificator", this.Modificator);
            writer.WriteAttributeString("VarType", this.VarType.ToString());
            writer.WriteEndElement();
            
        }
    }
}
