namespace UGF.Base
{
    public interface ISelectableBy<T> where T: UnityEngine.Object
    {
        void SelectedBy(T item);
        void DeselectedBy(T item);
    }
}

