using Commands;
using Commands.Commands;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterEquipment
    {
        private readonly IKernel _kernel;

        private readonly INewMainEquipment _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterEquipment(IKernel kernel, INewMainEquipment view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewEquipment += () => AddingNewEquipment(_view.DateEquip, _view.StatusBegin, _view.Problems,
                _view.DateProblems, _view.RepairPerson, _view.StatusEnd);
        }

        private void AddingNewEquipment(string date, string status, string problems, string dateproblems, string repairperson, string endstatus)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newEquipment = new MainEquipment()
            {
                DateEquipment = date,
                StatusEquipment = status,
                Problems = problems,
                DateProblems = dateproblems,
                RepairPerson = repairperson,
                EndStatus = endstatus
            };
            var command = new AddCommand<MainEquipment>(_executorCommands, newEquipment);
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