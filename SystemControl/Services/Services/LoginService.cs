using System.Linq;
using Models;
using Ninject;
using Repositories;
using Services.IServices;

namespace Services.Services
{
    public class LoginService : ILoginService
    {
        private IKernel _kernel;

        public string Login { get; set; }

        public string Password { get; set; }

        public void InitLoginPassword(string login, string password)
        {
            Login = login;
            Password = password;
        }

        public LoginService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public string Invoke()
        {
            string answer;
            var user = GetUser();
            answer = user != null ? "OK" : "ERROR";

            return answer;
        }

        private User GetUser()
        {
            var db = _kernel.Get<UnitOfWork>().Users;

            return db.GetList().FirstOrDefault(x => x.Login == Login && x.Password == Password.GetHashCode().ToString());
        }
    }
}