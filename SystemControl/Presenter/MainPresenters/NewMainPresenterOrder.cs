using Commands;
using Commands.Commands;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterOrder
    {
        private readonly IKernel _kernel;

        private readonly INewMainViewOrder _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterOrder(IKernel kernel, INewMainViewOrder view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewOrder += () => AddingNewOrder(_view.NameOrder, _view.DateOrder, _view.Status);
        }

        private void AddingNewOrder(string name, string date, string status)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newOrder = new MainOrders()
            {
                NameOrder = name,
                DateOrder = date,
                Status = status
            };
            var command = new AddCommand<MainOrders>(_executorCommands, newOrder);
            command.Execute();
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