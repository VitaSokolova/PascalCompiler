using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CompilerConsole.Parser
{
   public abstract class Node:IXmlSerializable
    {
        public string Name { get; set; }
        public string Type { get; set; }

        public Node(string name, string type)
        {
            this.Name = name;
            this.Type = type;
        }

        public Node() {
            
        }

        public XmlSchema GetSchema() {
            return null;
        }

        public virtual void ReadXml(XmlReader reader) {
            
        }

        public virtual void WriteXml(XmlWriter writer) {
           writer.WriteAttributeString("Name", this.Name);
            writer.WriteAttributeString("Type", this.Type);
        }
    }
}
