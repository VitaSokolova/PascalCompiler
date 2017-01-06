using CompilerConsole.Parser.Abstract;
using System;
using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Parser.VarNodes;

namespace CompilerConsole.Parser.CallNodes {
    public class ArrCall : Node {
        public ArrNode Arr { get; set; }

        public Node Index { get; set; }

        public Node Assign { get; set; }

        public Node OffsetIndex {
            get {
                //Вычисляем смещение в виде n-index;
                var offset = new Expression(new Literal(DataType.VarInt, this.Arr.LeftSize), this.Index, ExprToken.Sub );
                //Оно либо ноль либо отрицательное - умножаем на -1 чтобы получить положительное
                var toPositive = new Expression(offset, new Literal(DataType.VarInt, -1), ExprToken.Mult);
                return toPositive;
            }
        }

        public ArrCall(ArrNode arr) : base(ArrNode.ArrTypeToVarType(arr.DataType), "%ac" + arr.Name) {
            this.Arr = arr;
        }

        #region IXmlSerializable implementation

        public ArrCall() {

        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrCallNode");
            writer.WriteAttributeString("DataType", this.DataType.ToString());
            writer.WriteAttributeString("Arr", this.Arr.Name);
            writer.WriteStartElement("Index");
            this.Index.WriteXml(writer);
            writer.WriteEndElement();
            writer.WriteEndElement();
        }

        #endregion
    }
}
