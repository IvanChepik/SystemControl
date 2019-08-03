using Commands;
using Commands.Commands;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class LoginPresenter
    {
        private readonly IKernel _kernel;

        private readonly ILoginView _view;

        private readonly ExecutorCommands _executorCommands;

        public LoginPresenter(IKernel kernel, ILoginView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.TryLogin += () => TryLogin(_view.Login, _view.Password);
        }

        private void TryLogin(string login, string password)
        {
            _executorCommands.LoginEvent = LoginEventHandler;
            var command = new LoginCommand(_executorCommands, login, password);
            command.Execute();
        }

        public void Run()
        {
            _view.Show();
        }

        private void LoginEventHandler(string answer)
        {
            if (answer == "OK")
            {
                _kernel.Get<MainPresenter>().Run();
                _view.Close();
            }

            if (answer == "ERROR")
            {
                _view.ShowErrorMessage("Неверный логин и/или пароль");
            }                       
        }
    }
}