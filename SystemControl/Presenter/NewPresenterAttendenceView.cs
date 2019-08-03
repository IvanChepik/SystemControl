using Commands;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewPresenterAttendenceView
    {
        private readonly IKernel _kernel;

        private readonly INewAttendenceVIew _view;

        private readonly ExecutorCommands _executorCommands;

        public NewPresenterAttendenceView(IKernel kernel, INewAttendenceVIew view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
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