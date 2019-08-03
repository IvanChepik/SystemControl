using System;
using Models;
using Models.MainModels;
using Ninject;
using Repositories;
using Services.IServices;

namespace Services.Services
{
    public class DeleteService : IDeleteService
    {
        private IKernel _kernel;

        public ModelsType ModelsType { get; set; }

        public int Id { get; set; }

        public DeleteService(IKernel kernel)
        {
            _kernel = kernel;
        }

        public string Invoke()
        {
            try
            {
                switch (ModelsType)
                {
                    case ModelsType.ChildOrders:
                        _kernel.Get<UnitOfWork>().ChildOrders.Delete(Id);
                        _kernel.Get<UnitOfWork>().ChildOrders.Save();
                        return "ОК";
                    case ModelsType.ChildCards:
                        _kernel.Get<UnitOfWork>().ChildCards.Delete(Id);
                        _kernel.Get<UnitOfWork>().ChildCards.Save();
                        return "ОК";
                    case ModelsType.PersonnelOrders:
                        _kernel.Get<UnitOfWork>().PersonnelOrders.Delete(Id);
                        _kernel.Get<UnitOfWork>().PersonnelOrders.Save();
                        return "ОК";
                    case ModelsType.PersonnelVacation:
                        _kernel.Get<UnitOfWork>().PersonnelVacation.Delete(Id);
                        _kernel.Get<UnitOfWork>().PersonnelVacation.Save();
                        return "ОК";
                    case ModelsType.MainCleanings:
                        _kernel.Get<UnitOfWork>().MainCleanings.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainCleanings.Save();
                        return "ОК";
                    case ModelsType.MainCompetition:
                        _kernel.Get<UnitOfWork>().MainCompetitions.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainCompetitions.Save();
                        return "ОК";
                    case ModelsType.MainEquipment:
                        _kernel.Get<UnitOfWork>().MainEquipments.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainEquipments.Save();
                        return "ОК";
                    case ModelsType.MainItem:
                        _kernel.Get<UnitOfWork>().MainItems.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainItems.Save();
                        return "ОК";
                    case ModelsType.MainOrders:
                        _kernel.Get<UnitOfWork>().MainOrders.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainOrders.Save();
                        return "ОК";
                    case ModelsType.MainRequest:
                        _kernel.Get<UnitOfWork>().MainRequests.Delete(Id);
                        _kernel.Get<UnitOfWork>().MainRequests.Save();
                        return "ОК";
                    default:
                        return "Ошибка";
                }
            }
            catch
            {
                return "Отсутствует элемент";
            }           
        }
    }
}