using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser {
    public class ArrayNode : VariableNode {
        public int ArrayLegth { get; set; }

        public ArrayNode(string name, Abstract.Type type, string modificator, int arrLength, VarType varType = VarType.Struct)
            : base(name, type, modificator, varType) {
            this.ArrayLegth = arrLength;
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrayNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
        }
    }
}