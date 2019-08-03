using System;

namespace View.IViews
{
    public interface INewOrderView : IView
    {
        event Action AddingNewOrder;

        event Action BackToMainView;

        void GetMessage(string message);

        string NameOrder { get; }

        string FullName { get; }

        string DateOrder { get; }

        string StatusOrder { get; }
    }
}