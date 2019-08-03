
using System.Collections.Generic;
using System.Linq;
using Models;
using Models.PersonnelModels;

namespace Repositories
{
    public class PersonnelOrdersRepository : IRepository<PersonnelOrder>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }
        public List<PersonnelOrder> GetList()
        {
            return Db.PersonnelOrders.ToList();
        }

        public PersonnelOrder GetItem(int id)
        {
            return Db.PersonnelOrders.Find(id);
        }

        public void Create(PersonnelOrder item)
        {
            Db.PersonnelOrders.Add(item);
        }

        public void Update(PersonnelOrder item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.PersonnelOrders.Find(id);

            if (item != null)
            {
                Db.PersonnelOrders.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}