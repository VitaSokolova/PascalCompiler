using System;
using System.Collections;
using System.Collections.Generic;
using System.Xml;
using CompilerConsole.Parser.BodyNodes;
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

        public void RemoveNode(Node node) {
            this.BodyTable.Nodes.Remove(node);
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

            return bodyNode.ParentBodyNode?.FindNodeByName<T>(name);
        }

        public virtual T FindNodeByName<T>(string name) where T : Node {
            return this.FindNodeByName<T>(name, this);
        }

        #region IEnumerable implementation

        public IEnumerator<Node> GetEnumerator() {
            return this.BodyTable.GetEnumerator();
        }

        IEnumerator IEnumerable.GetEnumerator() {
            return this.GetEnumerator();
        }

        #endregion

        public static FuncNode FindFuncByNameAndArgsWithRoot(string name, List<Node> args, BodyNode rootBodyNode) {
            if (rootBodyNode is FuncNode) {
                var func = (FuncNode) rootBodyNode;
                var findFlag = false;
                if (func.Args.Count == args.Count && rootBodyNode.Name == name) {
                    findFlag = true;
                    for (int i = 0; i < func.Args.Count; i++) {
                        var variableNode = func.Args[i];
                        if (variableNode.DataType != args[i].DataType) {
                            findFlag = false;
                            break;
                        }
                    }
                }

                if (findFlag) {
                    return rootBodyNode as FuncNode;
                }
            }
            foreach (var node in rootBodyNode) {
                if (node is FuncNode) {
                    var func = (FuncNode) node;
                    var tempNode = FindFuncByNameAndArgsWithRoot(name, args, func);
                    if (tempNode != null) {
                        return tempNode;
                    }
                }
            }
            return null;
        }
    }
}
