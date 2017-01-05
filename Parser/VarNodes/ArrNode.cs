using System;
using System.Xml;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Parser.VarNodes {

    public class ArrNode : VariableNode {

        /// <summary>
        /// Вчисляемое свойство. Вычисляет длинну массива из его RightSize и leftSize
        /// </summary>
        public int Length => this.RightSize - (this.LeftSize - 1);

        //У паскаля массивы объявляются вот так: [1..10] где 1 - LeftSize а 10 - RightSize
        public int LeftSize { get; set; }
        public int RightSize { get; set; }

        public ArrNode(DataType dataType, string name, int leftSize, int rightSize) : base(dataType, name) {
            this.LeftSize = leftSize;
            this.RightSize = rightSize;
        }

        #region IXmlSerializable implementation

        public ArrNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ArrNode");
            writer.WriteAttributeString("LeftSize", this.LeftSize.ToString());
            writer.WriteAttributeString("RightSize", this.RightSize.ToString());
            writer.WriteAttributeString("Length", this.Length.ToString());
            base.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion

        public static DataType ArrTypeToVarType(DataType type)
        {
            switch (type)
            {
                case DataType.ArrInt:
                    return DataType.VarInt;
                case DataType.ArrString:
                    return DataType.VarString;
                case DataType.ArrChar:
                    return DataType.VarChar;
                case DataType.ArrBool:
                    return DataType.VarBool;
                default:
                    throw new ArgumentOutOfRangeException(nameof(type), type, null);
            }
        }
    }
}
