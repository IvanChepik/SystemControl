using System;

namespace View.IViews
{
    public interface INewMainViewRequest : IView
    {
        event Action BackToMainView;

        event Action AddingNewRequest;

        void GetMessage(string message);

        string DateRequest { get; }

        string TimeRequest { get; }

        string Content { get; }

        string Applicant { get; }

        string AdmissionTime { get; }

        string Notes { get; }
    }
}