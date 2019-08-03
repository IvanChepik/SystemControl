using Commands;
using Commands.Commands;
using Models.ChildModels;
using Ninject;
using View.IViews;

namespace Presenter
{
    public class NewChildCardPresenter
    {
        private readonly IKernel _kernel;
        private readonly INewChildCardsView _view;
        private readonly ExecutorCommands _executorCommands;

        public NewChildCardPresenter(IKernel kernel, INewChildCardsView view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewOrder += () => AddingNewCard(_view.FullName, _view.DateBirth, _view.PlaceBirth,
                _view.Address, _view.NumberAccount, _view.FullNameParents, _view.HomePhoneNumber, _view.CellPhoneNumber,
                _view.Mail, _view.Notes);
            ;
        }

        private void AddingNewCard(params string[] args)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newChildCard = new ChildCard()
                {
                    Id = 1,
                    FullName = args[0], DateBirth = args[1], PlaceBirth = args[2], Address = args[3],
                    NumberAccount = args[4],FullNameParents = args[5], HomePhoneNumber = args[6],
                    CellPhoneNumber = args[7], Mail = args[8], Notes = args[9]
                };
            var command = new AddCommand<ChildCard>(_executorCommands, newChildCard);
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