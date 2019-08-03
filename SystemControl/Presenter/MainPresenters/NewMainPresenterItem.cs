using Commands;
using Commands.Commands;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterItem
    {
        private readonly IKernel _kernel;

        private readonly INewMainViewItem _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterItem(IKernel kernel, INewMainViewItem view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewItem += () => AddingNewItem(_view.NameItem, _view.ItemNumber, _view.Quantity, _view.DateItem,
                _view.NumberAct, _view.Note);
        }

        private void AddingNewItem(string name, string number, int quantity, string date, string numberAct, string notes)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newItem = new MainItem()
            {
                DateItem = date,
                ItemNumber = number,
                NameItem = name,
                Quantity = quantity,
                Notes = notes,
                NumberAct = numberAct
            };
            var command = new AddCommand<MainItem>(_executorCommands, newItem);
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