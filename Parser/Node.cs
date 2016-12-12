using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class Node
    {
        public string Name { get; }
        public string Type { get; }
        public string Modificator { get; set; }

        public Node(string name, string type, string modificator)
        {
            this.Name = name;
            this.Type = type;
            this.Modificator = modificator;
        }
        
    }
}
