namespace CJBasic.ObjectManagement.Cache
{
    using global::CJBasic.ObjectManagement.Trees.Multiple;
    using System;

    public interface IHiberarchyVal : IMTreeVal
    {
        string SequenceCode { get; }
    }
}

