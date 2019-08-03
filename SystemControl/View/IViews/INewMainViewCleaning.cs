using System;

namespace View.IViews
{
    public interface INewMainViewCleaning : IView
    {
        event Action BackToMainView;

        event Action AddingNewCleaning;

        void GetMessage(string message);

        string PlaceCleaning { get; }

        string PlannedData { get; }

        string DesName { get; }

        string FactData { get; }

        string Executor { get; }
    }
}