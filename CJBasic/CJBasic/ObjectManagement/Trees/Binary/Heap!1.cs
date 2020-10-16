namespace CJBasic.ObjectManagement.Trees.Binary
{
    using global::CJBasic.Threading.Synchronize;
    using System;
    using System.Collections.Generic;

    [Serializable]
    public class Heap<TVal> : IHeap<TVal>, IBinaryTree<TVal> where TVal: IComparable
    {
        [NonSerialized]
        private global::CJBasic.Threading.Synchronize.SmartRWLocker _smartRWLocker;
        private List<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>> allNode;
        private int count;
        private global::CJBasic.ObjectManagement.Trees.Binary.HeapType heapType;
        private global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> root;

        public Heap()
        {
            this.allNode = new List<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>>();
            this._smartRWLocker = null;
            this.heapType = global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max;
            this.count = 0;
        }

        public Heap(global::CJBasic.ObjectManagement.Trees.Binary.HeapType type)
        {
            this.allNode = new List<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>>();
            this._smartRWLocker = null;
            this.heapType = global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max;
            this.count = 0;
            this.heapType = type;
        }

        private bool Contain(TVal val, global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node)
        {
            if (node == null)
            {
                return false;
            }
            if (node.TheValue.CompareTo(val) == 0)
            {
                return true;
            }
            if (((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max) && (node.TheValue.CompareTo(val) < 0)) || ((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Min) && (node.TheValue.CompareTo(val) > 0)))
            {
                return false;
            }
            return (this.Contain(val, node.LeftChild) || this.Contain(val, node.RightChild));
        }

        public bool Contains(TVal val)
        {
            using (this.SmartRWLocker.Lock(AccessMode.Read))
            {
                return this.Contain(val, this.root);
            }
        }

        public global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> Get(TVal val)
        {
            using (this.SmartRWLocker.Lock(AccessMode.Read))
            {
                foreach (global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node in this.allNode)
                {
                    if (node.TheValue.CompareTo(val) == 0)
                    {
                        return node;
                    }
                }
                return null;
            }
        }

        private global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> GetTheLastNode(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> rootNode)
        {
            if (rootNode == null)
            {
                return null;
            }
            global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node = null;
            Queue<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>> queue = new Queue<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>>();
            queue.Enqueue(rootNode);
            while (queue.Count > 0)
            {
                node = queue.Dequeue();
                if (node.LeftChild != null)
                {
                    queue.Enqueue(node.LeftChild);
                }
                if (node.RightChild != null)
                {
                    queue.Enqueue(node.RightChild);
                }
            }
            return node;
        }

        public void Insert(TVal val)
        {
            using (this.SmartRWLocker.Lock(AccessMode.Write))
            {
                if (!this.Contains(val))
                {
                    global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node = new global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>(val, null);
                    if (this.root == null)
                    {
                        this.root = node;
                    }
                    else
                    {
                        int num = 0;
                        if ((this.allNode.Count % 2) == 1)
                        {
                            num = (this.allNode.Count - 1) / 2;
                            this.allNode[num].LeftChild = node;
                            node.Parent = this.allNode[num];
                        }
                        else
                        {
                            num = (this.allNode.Count - 2) / 2;
                            this.allNode[num].RightChild = node;
                            node.Parent = this.allNode[num];
                        }
                        this.SwapFromLeafToRoot(node);
                    }
                    this.count++;
                    this.allNode.Add(node);
                }
            }
        }

        public TVal Pop()
        {
            if (this.root == null)
            {
                throw new Exception("The Root Is Null");
            }
            TVal theValue = this.root.TheValue;
            this.Remove(theValue);
            return theValue;
        }

        public void Remove(TVal val)
        {
            using (this.SmartRWLocker.Lock(AccessMode.Write))
            {
                global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> root = this.Get(val);
                if (root != null)
                {
                    if (this.allNode.Count == 1)
                    {
                        this.root = null;
                    }
                    else
                    {
                        global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node2 = this.allNode[this.allNode.Count - 1];
                        if (root.TheValue.CompareTo(node2.TheValue) != 0)
                        {
                            root.TheValue = node2.TheValue;
                        }
                        if ((this.allNode.Count % 2) == 0)
                        {
                            this.allNode[(this.allNode.Count - 2) / 2].LeftChild = null;
                        }
                        else
                        {
                            this.allNode[(this.allNode.Count - 3) / 2].RightChild = null;
                        }
                        this.allNode.RemoveAt(this.allNode.Count - 1);
                        this.count--;
                        this.SwapFromRootToLeaf(root);
                    }
                }
            }
        }

        private void SwapFromLeafToRoot(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node)
        {
            global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> parent = node;
            if (this.heapType != global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max)
            {
                while ((parent.Parent != null) && (parent.Parent.TheValue.CompareTo(parent.TheValue) > 0))
                {
                    this.SwapValueOfTwoNode(parent, parent.Parent);
                    parent = parent.Parent;
                }
            }
            else
            {
                while ((parent.Parent != null) && (parent.Parent.TheValue.CompareTo(parent.TheValue) < 0))
                {
                    this.SwapValueOfTwoNode(parent, parent.Parent);
                    parent = parent.Parent;
                }
            }
        }

        private void SwapFromRootToLeaf(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> root)
        {
            global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> leftChild = root;
            while ((leftChild.LeftChild != null) || (leftChild.RightChild != null))
            {
                if (leftChild.RightChild == null)
                {
                    if (((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max) && (leftChild.TheValue.CompareTo(leftChild.LeftChild.TheValue) < 0)) || ((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Min) && (leftChild.TheValue.CompareTo(leftChild.LeftChild.TheValue) > 0)))
                    {
                        this.SwapValueOfTwoNode(leftChild, leftChild.LeftChild);
                        leftChild = leftChild.LeftChild;
                        continue;
                    }
                    break;
                }
                if (((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max) && (leftChild.LeftChild.TheValue.CompareTo(leftChild.RightChild.TheValue) < 0)) || ((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Min) && (leftChild.LeftChild.TheValue.CompareTo(leftChild.RightChild.TheValue) > 0)))
                {
                    if (((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max) && (leftChild.TheValue.CompareTo(leftChild.RightChild.TheValue) < 0)) || ((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Min) && (leftChild.TheValue.CompareTo(leftChild.RightChild.TheValue) > 0)))
                    {
                        this.SwapValueOfTwoNode(leftChild, leftChild.RightChild);
                        leftChild = leftChild.RightChild;
                        continue;
                    }
                    break;
                }
                if (((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Max) && (leftChild.TheValue.CompareTo(leftChild.LeftChild.TheValue) < 0)) || ((this.heapType == global::CJBasic.ObjectManagement.Trees.Binary.HeapType.Min) && (leftChild.TheValue.CompareTo(leftChild.LeftChild.TheValue) > 0)))
                {
                    this.SwapValueOfTwoNode(leftChild, leftChild.LeftChild);
                    leftChild = leftChild.LeftChild;
                }
                else
                {
                    break;
                }
            }
        }

        private void SwapValueOfTwoNode(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node1, global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> node2)
        {
            TVal theValue = node1.TheValue;
            node1.TheValue = node2.TheValue;
            node2.TheValue = theValue;
        }

        public int Count
        {
            get
            {
                return this.count;
            }
        }

        public int Depth
        {
            get
            {
                return decimal.ToInt32(decimal.Ceiling((decimal) Math.Log((double) (this.count + 1), 2.0)));
            }
        }

        public global::CJBasic.ObjectManagement.Trees.Binary.HeapType HeapType
        {
            get
            {
                return this.heapType;
            }
        }

        public global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> Root
        {
            get
            {
                return this.root;
            }
        }

        private global::CJBasic.Threading.Synchronize.SmartRWLocker SmartRWLocker
        {
            get
            {
                if (this._smartRWLocker == null)
                {
                    this._smartRWLocker = new global::CJBasic.Threading.Synchronize.SmartRWLocker();
                }
                return this._smartRWLocker;
            }
        }

        Node<TVal> IBinaryTree<TVal>.Root => throw new NotImplementedException();
    }
}

