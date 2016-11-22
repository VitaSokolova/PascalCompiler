using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class VariableNode: Node
    {
        public VariableNode(string name, string type) : base(name, type)
        {
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
            if (String.CompareOrdinal(this.type, temp.type) != 0)
            {
                return false;
            }
            if (String.CompareOrdinal(this.name, temp.name) != 0)
            {
                return false;
            }
            return true;
        }
    }
}
