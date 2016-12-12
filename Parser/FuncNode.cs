using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class FuncNode: Node
    {
        public Table BodyTable { get; }
        public List<VariableNode> Args { get; }

        public FuncNode(string name, string type, Table bodyTable, List<VariableNode> args) : base(name, type)
        {
            this.BodyTable = bodyTable;
            this.Args = args;
        }
    }
}
