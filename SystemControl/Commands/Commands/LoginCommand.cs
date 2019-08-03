namespace Commands.Commands
{
    public class LoginCommand : Command
    {
        private string _login;
        private string _password;

        public LoginCommand(ExecutorCommands executorCommands, string login, string password) : base (executorCommands)
        {
            _login = login;
            _password = password;
        }

        public override void Execute()
        {
            Executor.Login(_login, _password);
        }
    }
}