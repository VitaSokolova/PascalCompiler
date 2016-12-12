using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class VariableNode: Node
    {
        public string Modificator { get; set; }

        public int IdNumber { get; set; }

        public VariableNode(string name, string type, string modificator) : base(name, type) {
            this.Modificator = modificator;
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
    }
}
