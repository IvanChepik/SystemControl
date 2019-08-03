using Commands;
using Commands.Commands;
using Models.MainModels;
using Ninject;
using View.IViews;

namespace Presenter.MainPresenters
{
    public class NewMainPresenterRequest
    {
        private readonly IKernel _kernel;

        private readonly INewMainViewRequest _view;

        private readonly ExecutorCommands _executorCommands;

        public NewMainPresenterRequest(IKernel kernel, INewMainViewRequest view, ExecutorCommands executorCommands)
        {
            _kernel = kernel;
            _view = view;
            _executorCommands = executorCommands;

            _view.BackToMainView += BackToMainView;
            _view.AddingNewRequest += () => AddingNewRequest(_view.DateRequest, _view.TimeRequest, _view.Content,
                _view.Applicant, _view.AdmissionTime, _view.Notes);
        }

        private void AddingNewRequest(string date, string time, string content, string applicant, string admissionTime, string notes)
        {
            _executorCommands.AddEvent = AddEventHandler;
            var newRequest = new MainRequest()
            {
                RequestDate = date,
                RequestTime = time,
                RequestContent = content,
                RequestApplicant = applicant,
                AdmissionTime = admissionTime,
                Notes = notes
            };
            var command = new AddCommand<MainRequest>(_executorCommands, newRequest);
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