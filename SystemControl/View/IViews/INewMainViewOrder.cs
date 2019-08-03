using System;

namespace View.IViews
{
    public interface INewMainViewOrder : IView
    {
        event Action BackToMainView;

        event Action AddingNewOrder;

        void GetMessage(string message);

        string DateOrder { get; }

        string NameOrder { get; }

        string Status { get; }
    }
}