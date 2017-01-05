using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {

    /// <summary>
    /// Класс для процедур и функций
    /// </summary>
    public class FuncNode : BodyNode {

        public List<VariableNode> Args { get; set; }

        public FuncNode(DataType dataType, string name, List<VariableNode> args, Body bodyTable)
            : base(dataType, name, bodyTable) {
            this.Args = args;
        }

        public override T FindNodeByName<T>(string name) {
            //Ищем среди аргументов
            foreach (var node in this.Args) {
                if (node is T && node.Name == name) {
                    return node as T;
                }
            }
            //Если не нашли начинаем рекурсивно обходить тела
            return base.FindNodeByName<T>(name);
        }

        #region IXmlSerializable implementation

        public FuncNode() {
            this.Args = new List<VariableNode>();
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("FuncNode");
            base.WriteXml(writer);

            writer.WriteStartElement("Args");
            foreach (var variableNode in this.Args)
            {
                variableNode.WriteXml(writer);
            }
            writer.WriteEndElement();

            writer.WriteEndElement();
        }

        #endregion
    }
}
