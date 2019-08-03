using Models;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using Ninject.Modules;
using Repositories;
using Services.IServices;
using Services.Services;

namespace Commands
{
    public class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IRepository<User>>().To<UserRepository>();

            Bind<IRepository<ChildOrder>>().To<ChildOrdersRepository>();
            Bind<IRepository<ChildCard>>().To<ChildCardsRepository>();
            Bind<IRepository<PersonnelOrder>>().To<PersonnelOrdersRepository>();
            Bind<IRepository<PersonnelVacation>>().To<PersonnelVacationRepository>();
            Bind<IRepository<MainCleaning>>().To<MainCleaningRepository>();
            Bind<IRepository<MainCompetition>>().To<MainCompetitionRepository>();
            Bind<IRepository<MainItem>>().To<MainItemRepository>();
            Bind<IRepository<MainOrders>>().To<MainOrdersRepository>();
            Bind<IRepository<MainEquipment>>().To<MainEquipmentRepository>();
            Bind<IRepository<MainRequest>>().To<MainRequestRepository>();

            Bind<ILoginService>().To<LoginService>().InSingletonScope();

            Bind<IAddDataService<ChildOrder>>().To<AddDataService<ChildOrder>>().InSingletonScope();
            Bind<IAddDataService<ChildCard>>().To<AddDataService<ChildCard>>().InSingletonScope();
            Bind<IAddDataService<PersonnelOrder>>().To<AddDataService<PersonnelOrder>>().InSingletonScope();
            Bind<IAddDataService<PersonnelVacation>>().To<AddDataService<PersonnelVacation>>().InSingletonScope();
            Bind<IAddDataService<MainCleaning>>().To<AddDataService<MainCleaning>>().InSingletonScope();
            Bind<IAddDataService<MainCompetition>>().To<AddDataService<MainCompetition>>().InSingletonScope();
            Bind<IAddDataService<MainItem>>().To<AddDataService<MainItem>>().InSingletonScope();
            Bind<IAddDataService<MainOrders>>().To<AddDataService<MainOrders>>().InSingletonScope();
            Bind<IAddDataService<MainEquipment>>().To<AddDataService<MainEquipment>>().InSingletonScope();
            Bind<IAddDataService<MainRequest>>().To<AddDataService<MainRequest>>().InSingletonScope();

            Bind<IInitTableService<ChildOrder>>().To<InitTableService<ChildOrder>>().InSingletonScope();
            Bind<IInitTableService<ChildCard>>().To<InitTableService<ChildCard>>().InSingletonScope();
            Bind<IInitTableService<PersonnelOrder>>().To<InitTableService<PersonnelOrder>>().InSingletonScope();
            Bind<IInitTableService<PersonnelVacation>>().To<InitTableService<PersonnelVacation>>().InSingletonScope();
            Bind<IInitTableService<MainCleaning>>().To<InitTableService<MainCleaning>>().InSingletonScope();
            Bind<IInitTableService<MainCompetition>>().To<InitTableService<MainCompetition>>().InSingletonScope();
            Bind<IInitTableService<MainItem>>().To<InitTableService<MainItem>>().InSingletonScope();
            Bind<IInitTableService<MainOrders>>().To<InitTableService<MainOrders>>().InSingletonScope();
            Bind<IInitTableService<MainEquipment>>().To<InitTableService<MainEquipment>>().InSingletonScope();
            Bind<IInitTableService<MainRequest>>().To<InitTableService<MainRequest>>().InSingletonScope();

            Bind<IDeleteService>().To<DeleteService>().InSingletonScope();

            Bind<UnitOfWork>().ToSelf().InSingletonScope();
        }
    }
}