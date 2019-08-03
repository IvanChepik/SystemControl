using System;

namespace View.IViews
{
    public interface INewChildCardsView : IView
    {
        event Action AddingNewOrder;

        event Action BackToMainView;

        void GetMessage(string message);

        string FullName { get; }
        string DateBirth { get; }
        string PlaceBirth { get;}
        string Address { get; }
        string NumberAccount { get; }
        string FullNameParents { get;  }
        string HomePhoneNumber { get; }
        string CellPhoneNumber { get; }
        string Mail { get; }
        string Notes { get; }
    }
}