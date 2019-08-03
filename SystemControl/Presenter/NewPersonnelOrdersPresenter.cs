using Commands;
using Commands.Commands;
using Models.PersonnelModels;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewPersonnelOrdersPresenter
    {
        private readonly IKernel _kernel;

        private readonly INewPersonnelOrdersView _view;

        private readonly ExecutorCommands _executorCommands;

        public NewPersonnelOrdersPresenter(IKernel kernel, INewPersonnelOrdersView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewOrder += () => AddingNewOrder(_view.NameOrder, _view.Position, _view.FullName, _view.Date, _view.Status);
        }

        private void AddingNewOrder(string name, string position, string fullName, string date, string status)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newPersonnelOrder = new PersonnelOrder()
                {Date = date, FullName = fullName, Name = name, Position = position, Status = status};
            var command = new AddCommand<PersonnelOrder>(_executorCommands, newPersonnelOrder);
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