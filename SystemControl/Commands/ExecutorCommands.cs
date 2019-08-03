using System;
using System.Collections.Generic;
using Models;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using Ninject;
using Services.IServices;

namespace Commands
{
    public class ExecutorCommands
    {
        public Action <string> LoginEvent;

        public Action<string> AddEvent;

        public Action<string> DeleteEvent;

        public Action<List<ChildOrder>> InitEvent;

        public Action<List<ChildCard>> InitChildCardsEvent;

        public Action<List<PersonnelOrder>> InitPersonnelOrdersEvent;

        public Action<List<PersonnelVacation>> InitPersonnelVacationEvent;

        public Action<List<MainOrders>> InitMainOrdersEvent;
    
        public Action<List<MainRequest>> InitMainRequestEvent;

        public Action<List<MainCleaning>> InitMainCleaningEvent;

        public Action<List<MainCompetition>> InitMainCompEvent;

        public Action<List<MainItem>> InitMainItemEvent;

        public Action<List<MainEquipment>> InitMainEquipEvent;

        private IKernel _kernel;

        public ExecutorCommands()
        {
            var registrations = new NinjectRegistrations();
            _kernel = new StandardKernel(registrations);
        }

        public void Login(string login, string password)
        {
            var service = _kernel.Get<ILoginService>();

            service.InitLoginPassword(login, password);
            CallEvent(service.Invoke(), LoginEvent);
        }

        public void Add<T>(T addingEntity)
        {
            var service = _kernel.Get<IAddDataService<T>>();
            service.AddingEntity = addingEntity;
            CallEvent(service.Invoke(), AddEvent);

        }

        public void Delete(ModelsType modelsType, int id)
        {
            var service = _kernel.Get<IDeleteService>();
            service.ModelsType = modelsType;
            service.Id = id;
            CallEvent(service.Invoke(), DeleteEvent);
        }

        public void InitDataBase<T>(ModelsType modelType)
        {
            var service = _kernel.Get<IInitTableService<T>>();
            service.ModelsType = modelType;
            var choosingEvent = GetAction<T>(modelType);
            CallInitEvent<T>(service.Invoke(), choosingEvent);          
        }

        private Action<List<T>> GetAction<T>(ModelsType type)
        {
            switch (type)
            {
                case ModelsType.ChildCards:
                    return InitChildCardsEvent as Action<List<T>>;
                case ModelsType.ChildOrders:
                    return InitEvent as Action<List<T>>;
                case ModelsType.PersonnelOrders:
                    return InitPersonnelOrdersEvent as Action<List<T>>;
                case ModelsType.PersonnelVacation:
                    return InitPersonnelVacationEvent as Action<List<T>>;
                case ModelsType.MainCleanings:
                    return InitMainCleaningEvent as Action<List<T>>;
                case ModelsType.MainCompetition:
                    return InitMainCompEvent as Action<List<T>>;
                case ModelsType.MainEquipment:
                    return InitMainEquipEvent as Action<List<T>>;
                case ModelsType.MainOrders:
                    return InitMainOrdersEvent as Action<List<T>>;
                case ModelsType.MainRequest:
                    return InitMainRequestEvent as Action<List<T>>;
                case ModelsType.MainItem:
                    return InitMainItemEvent as Action<List<T>>;
                default:
                    throw new Exception();
            }
        }

        public void CallInitEvent<T>(List<T> modelsList, Action<List<T>> handler)
        {
            handler?.Invoke(modelsList);
        }

        public void CallEvent(string answer, Action<string> handler)
        {
            handler?.Invoke(answer);
        }
    }
}