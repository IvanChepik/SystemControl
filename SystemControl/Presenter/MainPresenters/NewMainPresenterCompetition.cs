using Commands;
using Commands.Commands;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterCompetition
    {
        private readonly IKernel _kernel;

        private readonly INewMainViewCompetition _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterCompetition(IKernel kernel, INewMainViewCompetition view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewComp += () =>
                AddingNewCompetition(_view.DateComp, _view.Fullname, _view.Group, _view.NameComp, _view.Storage);
        }

        private void AddingNewCompetition(string dateComp, string fullname, int group, string name, string storage)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newComp = new MainCompetition()
            {
                DateCompetition = dateComp,
                Fullname = fullname,
                Group = group,
                NameCompetition = name,
                Storage = storage
            };
            var command = new AddCommand<MainCompetition>(_executorCommands, newComp);
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