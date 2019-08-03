using Commands;
using Commands.Commands;
using Models.ChildModels;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterCleaning
    {
        private readonly IKernel _kernel;

        private readonly INewMainViewCleaning _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterCleaning(IKernel kernel, INewMainViewCleaning view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewCleaning += () => AddingNewCleaning(_view.PlaceCleaning, _view.PlannedData, _view.DesName,
                _view.FactData, _view.Executor);
        }

        private void AddingNewCleaning(string place, string plandata, string disin, string factdata, string executor)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newCleaning = new MainCleaning()
            {
                Executor = executor,
                FactDate = factdata,
                HoldingPlace = place,
                NameDisinfectant = disin,
                PlannedDate = plandata
            };
            var command = new AddCommand<MainCleaning>(_executorCommands, newCleaning);
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