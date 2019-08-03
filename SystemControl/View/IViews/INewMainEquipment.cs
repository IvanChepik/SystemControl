using System;

namespace View.IViews
{
    public interface INewMainEquipment : IView
    {
        event Action BackToMainView;

        event Action AddingNewEquipment;

        void GetMessage(string message);

        string DateEquip { get; }

        string StatusBegin { get; }

        string Problems { get; }

        string DateProblems { get; }

        string RepairPerson { get; }

        string StatusEnd { get; }
    }
}