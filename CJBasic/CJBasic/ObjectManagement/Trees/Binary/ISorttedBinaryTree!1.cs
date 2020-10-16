namespace CJBasic.ObjectManagement.Trees.Binary
{
    using System;
    using System.Collections.Generic;

    public interface ISorttedBinaryTree<TVal> : IBinaryTree<TVal> where TVal: IComparable
    {
        bool Contains(TVal var);
        global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> Get(TVal var);
        IList<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>> GetAllNodesAscend(bool ascend);
        global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> GetMaxNode(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> childTree);
        global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> GetMinNode(global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal> childTree);
        void Insert(TVal val);
        void Remove(TVal val);
        IList<global::CJBasic.ObjectManagement.Trees.Binary.Node<TVal>> Traverse(TraverseMode mode);
    }
}

