using System;

namespace View.IViews
{
    public interface ILoginView : IView
    {
        string Login { get; }

        string Password { get; }

        void ShowErrorMessage(string message);

        event Action TryLogin;
    }
}