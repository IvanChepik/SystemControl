using System;
using Models;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using Ninject;
using Repositories;
using Services.IServices;

namespace Services.Services
{
    public class AddDataService<T> : IAddDataService<T> where T : class
    {
        private IKernel _kernel;

        public T AddingEntity { get; set; }

        public AddDataService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public string Invoke()
        {
            try
            {
                var type = GetModelType();
                var db = GetRepository(type);
                AddToDatabase(db);
            }
            catch (Exception exception)
            {
                return exception.Message;
            }

            return "OK";
        }

        private IRepository<T> GetRepository(ModelsType type)
        {
            switch (type)
            {
                case ModelsType.ChildOrders:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().ChildOrders;
                case ModelsType.ChildCards:
                    return (IRepository<T>) _kernel.Get<UnitOfWork>().ChildCards;
                case ModelsType.PersonnelOrders:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().PersonnelOrders;
                case ModelsType.PersonnelVacation:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().PersonnelVacation;
                case ModelsType.MainCleanings:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainCleanings;
                case ModelsType.MainCompetition:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainCompetitions;
                case ModelsType.MainEquipment:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainEquipments;
                case ModelsType.MainItem:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainItems;
                case ModelsType.MainOrders:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainOrders;
                case ModelsType.MainRequest:
                    return (IRepository<T>)_kernel.Get<UnitOfWork>().MainRequests;
                default:
                    throw new Exception();
            }
        }

        private ModelsType GetModelType()
        {
            if (AddingEntity is ChildOrder)
            {
                return ModelsType.ChildOrders;
            }

            if (AddingEntity is ChildCard)
            {
                return ModelsType.ChildCards;
            }

            if (AddingEntity is PersonnelOrder)
            {
                return ModelsType.PersonnelOrders;
            }

            if (AddingEntity is PersonnelVacation)
            {
                return ModelsType.PersonnelVacation;
            }
            
            if (AddingEntity is MainCleaning)
            {
                return ModelsType.MainCleanings;
            }

            if (AddingEntity is MainCompetition)
            {
                return ModelsType.MainCompetition;
            }

            if (AddingEntity is MainEquipment)
            {
                return ModelsType.MainEquipment;
            }

            if (AddingEntity is MainItem)
            {
                return ModelsType.MainItem;
            }

            if (AddingEntity is MainOrders)
            {
                return ModelsType.MainOrders;
            }

            if (AddingEntity is MainRequest)
            {
                return ModelsType.MainRequest;
            }

            throw new Exception();
        }

        private void AddToDatabase(IRepository<T> db)
        {
            db.Create(AddingEntity);
            db.Save();
        }
    }
}