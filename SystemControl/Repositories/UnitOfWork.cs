using System;
using Models;
using Models.ChildModels;
using Models.MainModels;
using Models.PersonnelModels;
using Ninject;

namespace Repositories
{
    public class UnitOfWork : IDisposable
    {
        private IKernel _kernel;
        private bool _disposed = false;
        private SystemControlContext _db = new SystemControlContext();
        private IRepository<User> _repositoryUsers;
        private IRepository<ChildOrder> _childOrders;
        private IRepository<ChildCard> _childCards;
        private IRepository<PersonnelOrder> _personnelOrders;
        private IRepository<PersonnelVacation> _personnelVacation;

        private IRepository<MainEquipment> _mainEquipments;
        private IRepository<MainCleaning> _mainCleanings;
        private IRepository<MainItem> _mainItems;
        private IRepository<MainCompetition> _mainCompetitions;
        private IRepository<MainRequest> _mainRequests;
        private IRepository<MainOrders> _mainOrders;

        public UnitOfWork(IKernel kernel)
        {
            _kernel = kernel;
        }

        public IRepository<MainOrders> MainOrders
        {
            get
            {
                if (_mainOrders == null)
                {
                    _mainOrders = _kernel.Get<IRepository<MainOrders>>();
                    _mainOrders.Db = _db;
                }

                return _mainOrders;
            }
        }

        public IRepository<MainRequest> MainRequests
        {
            get
            {
                if (_mainRequests == null)
                {
                    _mainRequests = _kernel.Get<IRepository<MainRequest>>();
                    _mainRequests.Db = _db;
                }

                return _mainRequests;
            }
        }

        public IRepository<MainCompetition> MainCompetitions
        {
            get
            {
                if (_mainCompetitions == null)
                {
                    _mainCompetitions = _kernel.Get<IRepository<MainCompetition>>();
                    _mainCompetitions.Db = _db;
                }

                return _mainCompetitions;
            }
        }

        public IRepository<MainItem> MainItems
        {
            get
            {
                if (_mainItems == null)
                {
                    _mainItems = _kernel.Get<IRepository<MainItem>>();
                    _mainItems.Db = _db;
                }

                return _mainItems;
            }
        }

        public IRepository<MainCleaning> MainCleanings
        {
            get
            {
                if (_mainCleanings == null)
                {
                    _mainCleanings = _kernel.Get<IRepository<MainCleaning>>();
                    _mainCleanings.Db = _db;
                }

                return _mainCleanings;
            }
        }

        public IRepository<MainEquipment> MainEquipments
        {
            get
            {
                if (_mainEquipments == null)
                {
                    _mainEquipments = _kernel.Get<IRepository<MainEquipment>>();
                    _mainEquipments.Db = _db;
                }

                return _mainEquipments;
            }
        }

        public IRepository<User> Users
        {
            get
            {
                if (_repositoryUsers == null)
                {
                    _repositoryUsers = _kernel.Get<IRepository<User>>();
                    _repositoryUsers.Db = _db;
                }

                return _repositoryUsers;
            }
        }

        public IRepository<PersonnelOrder> PersonnelOrders
        {
            get
            {
                if (_personnelOrders == null)
                {
                    _personnelOrders = _kernel.Get<IRepository<PersonnelOrder>>();
                    _personnelOrders.Db = _db;
                }

                return _personnelOrders;
            }
        }

        public IRepository<PersonnelVacation> PersonnelVacation
        {
            get
            {
                if (_personnelVacation == null)
                {
                    _personnelVacation = _kernel.Get<IRepository<PersonnelVacation>>();
                    _personnelVacation.Db = _db;
                }

                return _personnelVacation;
            }
        }

        public IRepository<ChildOrder> ChildOrders
        {
            get
            {
                if (_childOrders == null)
                {
                    _childOrders = _kernel.Get<IRepository<ChildOrder>>();
                    _childOrders.Db = _db;
                }

                return _childOrders;
            }
        }

        public IRepository<ChildCard> ChildCards
        {
            get
            {
                if (_childCards == null)
                {
                    _childCards = _kernel.Get<IRepository<ChildCard>>();
                    _childCards.Db = _db;
                }

                return _childCards;
            }
        }

        public void Save()
        {
            _db.SaveChanges();
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    _db.Dispose();
                }

                _disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}