using System;

namespace View.IViews
{
    public interface INewPersonnelOrdersView : IView
    {
        event Action AddingNewOrder;

        event Action BackToMainView;

        string NameOrder { get; }

        string Position { get; }

        string FullName { get; }

        string Date { get; }

        string Status { get; }

        void GetMessage(string message);
    }
}