using System;
using Ninject;
using System.Windows.Forms;
using Models;
using Presenter;

namespace SystemControl
{
    public static class EntryPoint
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        public static void Main()
        {
            var registration = new NinjectRegistration();
            var kernel = new StandardKernel(registration);

            kernel.Get<LoginPresenter>().Run();
            Application.Run(kernel.Get<ApplicationContext>());
        }
    }
}
