namespace CJBasic.ObjectManagement.Trees.Multiple
{
    using global::CJBasic.ObjectManagement;

    public interface IAgileNodePicker<TVal> : IObjectRetriever<string, TVal> where TVal: IMTreeVal
    {
        TVal PickupRoot();
    }
}

