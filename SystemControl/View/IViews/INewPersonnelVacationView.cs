using System;

namespace View.IViews
{
    public interface INewPersonnelVacationView : IView
    {
        event Action AddingNewVacation;

        event Action BackToMainView;

        string Position { get; }

        string FullName { get; }

        string PersonnelNumber { get; }

        int QuanitityDay { get; }

        string PlannedDate { get; }

        string FactDate { get; }

        string Notes { get; }

        void GetMessage(string message);
    }
}