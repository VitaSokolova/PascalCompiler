using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class FuncCall:Node {
        public FuncNode Func { get; set; }
        public List<VariableNode> Args { get; set; }


        public FuncCall(string name, string type, FuncNode func) : base(name, type) {
            this.Func = func;
            this.Args = new List<VariableNode>();
        }


    }
}
