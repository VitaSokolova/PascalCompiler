using System;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace CompilerConsole.Parser.Abstract {

    /// <summary>
    /// Тип данных, который может иметь узел
    /// </summary>
    public enum DataType {
        VarInt,
        VarBool,
        VarChar,
        VarString,
        ArrInt,
        ArrBool,
        ArrChar,
        ArrString,
        Void,
        Error,

        /// <summary>
        /// Специальный тип данных. Используется для узлов типа BodyNode, т.к. они почти все, кроме методов, не имеют типа
        /// </summary>
        NotAType
    }

    /// <summary>
    /// Асбтрактный класс для любого узла AST дерева
    /// </summary>
    public abstract class Node : IXmlSerializable {

        public DataType DataType { get; set; }
        public string Name { get; set; }

        public Node(DataType dataType, string name) {
            this.DataType = dataType;
            this.Name = name;
        }

        #region IXmlSerializable implementation

        public Node() {

        }

        public virtual XmlSchema GetSchema() {
            throw new NotImplementedException();
        }

        public virtual void ReadXml(XmlReader reader) {
            throw new NotImplementedException();
        }

        public virtual void WriteXml(XmlWriter writer) {
            writer.WriteAttributeString("Name", this.Name);
            writer.WriteAttributeString("Type", this.DataType.ToString());
        }

        #endregion
    }
}
