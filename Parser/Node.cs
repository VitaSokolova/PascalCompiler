using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CompilerConsole.Parser.Abstract
{
    public enum Type
    {
        VarInt,
        VarFloat,
        VarString,
        VarChar,
        VarBool,

        ArrInt,
        ArrFloat,
        ArrString,
        ArrChar,
        ArrBool,

        Void,

        Error,
        NotAType
    }

    public abstract class Node:IXmlSerializable
    {
        public string Name { get; set; }
        public Type Type { get; set; }

        public Node(string name, Type type)
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
            writer.WriteAttributeString("Type", this.Type.ToString());
        }
    }
}
