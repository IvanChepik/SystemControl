using Commands;
using Commands.Commands;
using Models.PersonnelModels;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewPersonnelVacationPresenter
    {
        private readonly IKernel _kernel;

        private readonly INewPersonnelVacationView _view;

        private readonly ExecutorCommands _executorCommands;

        public NewPersonnelVacationPresenter(IKernel kernel, INewPersonnelVacationView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewVacation += () => AddingNewVacation(_view.Position, _view.FullName, _view.PersonnelNumber, _view.QuanitityDay, _view.PlannedDate, _view.FactDate, _view.Notes);
        }

        private void AddingNewVacation(string status, string fullName, string personnelNumber, int quantityDays, string plannedDate, string factDate, string notes)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newPersonnelVacation = new PersonnelVacation()
            {
                CountDay = quantityDays, FactDate = factDate, FullName = fullName, Notes = notes,
                PersonnelNumber = personnelNumber, PlanDate = plannedDate, Position = status
            };
            var command = new AddCommand<PersonnelVacation>(_executorCommands, newPersonnelVacation);
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