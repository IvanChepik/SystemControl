using System;
using System.Collections.Generic;
using Models;
using Models.ChildModels;
using Ninject;
using Repositories;
using Services.IServices;

namespace Services.Services
{
    public class InitTableService<T> : IInitTableService<T>
    {
        private IKernel _kernel;

        public ModelsType ModelsType { get; set; }

        public InitTableService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public List<T> Invoke()
        {
            switch (ModelsType)
            {
                case ModelsType.ChildOrders:
                    var childOrders = _kernel.Get<UnitOfWork>().ChildOrders.GetList();
                    return childOrders as List<T>;
                case ModelsType.ChildCards:
                    var childCards = _kernel.Get<UnitOfWork>().ChildCards.GetList();
                    return childCards as List<T>;
                case ModelsType.PersonnelOrders:
                    var personnelOrders = _kernel.Get<UnitOfWork>().PersonnelOrders.GetList();
                    return personnelOrders as List<T>;
                case ModelsType.PersonnelVacation:
                    var personnelVacations = _kernel.Get<UnitOfWork>().PersonnelVacation.GetList();
                    return personnelVacations as List<T>;
                case ModelsType.MainCleanings:
                    var mainCleanings = _kernel.Get<UnitOfWork>().MainCleanings.GetList();
                    return mainCleanings as List<T>;
                case ModelsType.MainEquipment:
                    var mainEquipment = _kernel.Get<UnitOfWork>().MainEquipments.GetList();
                    return mainEquipment as List<T>;
                case ModelsType.MainCompetition:
                    var mainComp = _kernel.Get<UnitOfWork>().MainCompetitions.GetList();
                    return mainComp as List<T>;
                case ModelsType.MainItem:
                    var mainItems = _kernel.Get<UnitOfWork>().MainItems.GetList();
                    return mainItems as List<T>;
                case ModelsType.MainOrders:
                    var mainOrders = _kernel.Get<UnitOfWork>().MainOrders.GetList();
                    return mainOrders as List<T>;
                case ModelsType.MainRequest:
                    var mainRequests = _kernel.Get<UnitOfWork>().MainRequests.GetList();
                    return mainRequests as List<T>;
                default:
                    throw new Exception();
            }
        }
    }
}