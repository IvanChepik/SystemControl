using Commands;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewWorkTimePresenter
    {
        private readonly IKernel _kernel;

        private readonly INewWorkTimeView _view;

        private readonly ExecutorCommands _executorCommands;

        public NewWorkTimePresenter(IKernel kernel, INewWorkTimeView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
        }

        private void AddEventHandler(string answer)
        {
            _view.GetMessage(answer);
        }

        private void BackToMainView()
        {
            _kernel.Get<MainPresenter>().Run();
            _view.BackToMainView -= BackToMainView;
            _view.Close();
        }

        public void Run()
        {
            _view.Show();
        }
    }
}