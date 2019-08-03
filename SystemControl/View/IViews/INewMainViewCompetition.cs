using System;

namespace View.IViews
{
    public interface INewMainViewCompetition : IView
    {
        event Action BackToMainView;

        event Action AddingNewComp;

        void GetMessage(string message);

        string DateComp { get; }

        string Fullname { get; }

        int Group { get; }

        string NameComp { get; }

        string Storage { get; }
    }
}