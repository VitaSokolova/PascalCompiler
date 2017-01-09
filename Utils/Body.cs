using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;
using CompilerConsole.Parser.Abstract;

namespace CompilerConsole.Utils {
    public class Body : IXmlSerializable, IEnumerable<Node> {

        public List<Node> Nodes { get; set; }

        public Body(List<Node> nodes) {
            this.Nodes = nodes;
        }

        #region IXmlSerializable implementation

        public Body() {
            this.Nodes = new List<Node>();
        }

        public XmlSchema GetSchema() {
            throw new NotImplementedException();
        }

        public void ReadXml(XmlReader reader) {
            throw new NotImplementedException();
        }

        public void WriteXml(XmlWriter writer) {
            writer.WriteStartElement("Body");
            foreach (var node in this.Nodes) {
                node.WriteXml(writer);
            }
            writer.WriteEndElement();
        }

        #endregion

        #region IEnumerable implementation

        public IEnumerator<Node> GetEnumerator() {
            return this.Nodes.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

#endregion
    }
}
