using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class Node
    {
        public string Name { get; }
        public string Type { get; } 

        public Node(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }
        
    }
}
