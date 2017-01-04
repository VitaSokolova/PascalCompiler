using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Utils;

namespace CompilerConsole.Parser.Abstract {

    /// <summary>
    /// Абстрактный класс для всех узлов, которые содержат тело
    /// </summary>
    public abstract class BodyNode : Node, IEnumerable<Node> {

        public Node this[int i] {
            get { return this.BodyTable.Nodes[i]; }
            set { this.BodyTable.Nodes[i] = value; }
        }

        public BodyNode ParentBodyNode { get; set; }

        public Body BodyTable { get; set; }

        public BodyNode(DataType dataType, string name, Body bodyTable) : base(dataType, name) {
            this.BodyTable = bodyTable;
        }

        public void AddNode(Node node) {
            this.BodyTable.Nodes.Add(node);
        }

        #region IXmlSerializable implementation

        public BodyNode() {
            this.BodyTable = new Body();
        }

        public override void WriteXml(XmlWriter writer) {
            base.WriteXml(writer);
            this.BodyTable.WriteXml(writer);
        }

        #endregion

        protected virtual T FindNodeByName<T>(string name, BodyNode bodyNode) where T : Node
        {
            if (bodyNode == null)
            {
                return null;
            }

            foreach (var node in bodyNode)
            {
                if (node is T && node.Name == name)
                {
                    return node as T;
                }
            }

            return this.FindNodeByName<T>(name, bodyNode.ParentBodyNode);
        }

        public abstract T FindNodeByName<T>(string name) where T : Node;

        #region IEnumerable implementation

        public IEnumerator<Node> GetEnumerator() {
            return this.BodyTable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        #endregion
    }
}
