using System.Collections.Generic;
using System.Linq;
using Models;
using Models.ChildModels;

namespace Repositories
{
    public class ChildOrdersRepository : IRepository<ChildOrder>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<ChildOrder> GetList()
        {
            return Db.ChildOrders.ToList();
        }

        public ChildOrder GetItem(int id)
        {
            return Db.ChildOrders.Find(id);
        }

        public void Create(ChildOrder item)
        {
            Db.ChildOrders.Add(item);
        }

        public void Update(ChildOrder item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.ChildOrders.Find(id);

            if (item != null)
            {
                Db.ChildOrders.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}