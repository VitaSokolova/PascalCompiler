using System.Xml;

namespace CompilerConsole.Parser.Abstract
{
    public enum VarType
    {
        Reference,
        Struct
    }

    public abstract class VariableNode:Node
    {
        public string Modificator { get; set; }

        /// <summary>
        /// Это тип важен для аргументов функций.
        /// То есть, если в функции аргумент имеет тип Reference, то это ссылочная переменная. Аналог ref в С#
        /// </summary>
        public VarType VarType { get; set; }

        public int IdNumber { get; set; }

        public VariableNode(string name, Type type, string modificator, VarType varType = VarType.Struct)
            : base(name, type) {
            this.VarType = varType;
            this.Modificator = modificator;
        }

        public VariableNode() {
            
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteAttributeString("IDNumber", this.IdNumber.ToString());
            base.WriteXml(writer);
            writer.WriteAttributeString("Modificator", this.Modificator);
            writer.WriteAttributeString("VarType", this.VarType.ToString());
        }
    }
}
