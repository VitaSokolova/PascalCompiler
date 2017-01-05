using System.Xml;
using CompilerConsole.Parser.Abstract;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.BodyNodes {

    /// <summary>
    /// Класс для хранения узлов, главного тела - программы.
    /// Содержит:
    ///     Глобальные переменные
    ///     Глобальные методы
    ///     Основное тело программы
    /// </summary>
    public class ProgramNode : BodyNode {

        /* Заметка:
         * Важно понимать, что при генерации IL кода программе необходима точка входа - функция Main
         * И тело программы будет оборачивать свое тело в эту функцию, т.к. без этого не выйдет скомпилировать программу
         */

        public ProgramNode(Body bodyTable, string name = "%pr", DataType dataType = DataType.NotAType)
            : base(dataType, name, bodyTable) {
        }

        #region IXmlSerializable implementation

        public ProgramNode() {
        }

        public override void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("ProgramNode");
            base.WriteXml(writer);
            writer.WriteEndElement();
        }

        #endregion
    }
}
