using System;
using System.Collections.Generic;
using System.Text;

namespace CompilerConsole.Parser
{
    class Table
    {
      
        public List<Node> list;

        public Table ParentTable { get; }

        public Table(Table parentTable)
        {
            this.list = new List<Node>();
            this.ParentTable = parentTable;
        }

        public static T FindNode<T>(string objectName, Table table) where T: Node
        {
            if (table == null)
            {
                return null;
            }

            foreach (var node in table.list)
            {
                if (node is T && String.Compare(node.Name, objectName) == 0)
                {
                    return node as T;
                }   
            }

            return FindNode<T>(objectName, table.ParentTable);
        }
    }
}
