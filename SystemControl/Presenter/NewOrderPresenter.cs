using Commands;
using Commands.Commands;
using Models.ChildModels;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewOrderPresenter
    {
        private readonly IKernel _kernel;
        private readonly INewOrderView _view;
        private readonly ExecutorCommands _executorCommands;

        public NewOrderPresenter(IKernel kernel, INewOrderView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.AddingNewOrder += () => AddingNewOrder(_view.NameOrder, _view.FullName, _view.DateOrder, _view.StatusOrder);
            _view.BackToMainView += BackToMainView;
        }

        private void BackToMainView()
        {
            _kernel.Get<MainPresenter>().Run();
            _view.BackToMainView -= BackToMainView;
            _view.Close();
        }

        private void AddingNewOrder(string name, string fullname, string date, string status)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newChildOrder = new ChildOrder()
                {FullName = fullname, Name = name, Status = status, Date = date};
            var command = new AddCommand<ChildOrder>(_executorCommands, newChildOrder);
            command.Execute();
            //_kernel.Get<MainPresenter>().Run();
            //_view.Close();
        }

        private void AddEventHandler(string answer)
        {
            _view.GetMessage(answer);
        }

        public void Run()
        {
            _view.Show();
        }
    }
}