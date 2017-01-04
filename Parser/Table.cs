using System;
using System.Collections.Generic;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser {
    public class Table : IXmlSerializable {

        public List<Node> list { get; set; }

        public Table ParentTable { get; set; }

        public Table(Table parentTable) {
            this.list = new List<Node>();
            this.ParentTable = parentTable;
        }

        public Table() {

        }

        public static T FindNode<T>(string objectName, Table table) where T : Node {
            if (table == null) {
                return null;
            }

            foreach (var node in table.list) {
                if (node is T && String.Compare(node.Name, objectName) == 0) {
                    return node as T;
                }
            }
            return null;
            // return FindNode<T>(objectName, table.ParentTable);
        }

        public XmlSchema GetSchema() {
            return null;
        }

        public void ReadXml(XmlReader reader) {

        }

        public void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Table");
            foreach (var variableNode in this.list) {
                variableNode.WriteXml(writer);
            }
            writer.WriteEndElement();
        }
    }
}
