using System;

namespace View.IViews
{
    public interface INewMainViewItem : IView
    {
        event Action BackToMainView;

        event Action AddingNewItem;

        void GetMessage(string message);

        string NameItem { get; }

        string ItemNumber { get; }

        int Quantity { get; }

        string DateItem { get; }

        string NumberAct { get; }

        string Note { get; }
    }
}