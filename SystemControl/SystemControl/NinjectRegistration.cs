using System.Windows.Forms;
using Commands;
using Ninject.Modules;
using Presenter;
using Presenter.MainPresenters;
using View.IViews;
using View.Views;

namespace SystemControl
{
    public class NinjectRegistration : NinjectModule
    {
        public override void Load()
        {
            Bind<ApplicationContext>().ToConstant(new ApplicationContext());

            Bind<ILoginView>().To<LoginView>();
            Bind<IMainView>().To<MainView>();
            Bind<INewOrderView>().To<NewOrderView>();
            Bind<INewChildCardsView>().To<NewChildCardsView>();
            Bind<INewPersonnelOrdersView>().To<NewPersonnellOrdersView>();
            Bind<INewPersonnelVacationView>().To<NewPersonnelVacationView>();
            Bind<INewMainEquipment>().To<NewMainViewEquipment>();
            Bind<INewMainViewCleaning>().To<NewMainViewCleaning>();
            Bind<INewMainViewItem>().To<NewMainViewItem>();
            Bind<INewMainViewOrder>().To<NewMainViewOrder>();
            Bind<INewMainViewRequest>().To<NewMainViewRequest>();
            Bind<INewMainViewCompetition>().To<NewMainViewCompetition>();
            Bind<INewAttendenceVIew>().To<NewAttendenceView>();
            Bind<INewWorkTimeView>().To<NewWorkTimeView>();

            Bind<MainPresenter>().ToSelf();
            Bind<LoginPresenter>().ToSelf();
            Bind<NewOrderPresenter>().ToSelf();
            Bind<NewChildCardPresenter>().ToSelf();
            Bind<NewWorkTimePresenter>().ToSelf();
            Bind<NewPersonnelOrdersPresenter>().ToSelf();
            Bind<NewPersonnelVacationPresenter>().ToSelf();
            Bind<NewPresenterAttendenceView>().ToSelf();
            Bind<NewMainPresenterCleaning>().ToSelf();
            Bind<NewMainPresenterCompetition>().ToSelf();
            Bind<NewMainPresenterEquipment>().ToSelf();
            Bind<NewMainPresenterItem>().ToSelf();
            Bind<NewMainPresenterOrder>().ToSelf();
            Bind<NewMainPresenterRequest>().ToSelf();

            Bind<ExecutorCommands>().ToSelf().InSingletonScope();
        }
    }
}