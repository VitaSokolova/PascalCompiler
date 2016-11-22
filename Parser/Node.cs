using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class Node
    {
        protected string name;
        protected string type;
        protected int idNumber;

        public Node(string name, string type)
        {
            this.name = name;
            this.type = type;
        }
        
    }
}
