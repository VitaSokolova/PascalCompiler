using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class FuncNode: Node
    {
        private Table bodyTable;

        public FuncNode(string name, string type) : base(name, type)
        {
            this.bodyTable = new Table();
        }
    }
}
