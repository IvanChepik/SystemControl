using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainOrdersRepository : IRepository<MainOrders>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<MainOrders> GetList()
        {
            return Db.MainOrderses.ToList();
        }

        public MainOrders GetItem(int id)
        {
            return Db.MainOrderses.Find(id);
        }

        public void Create(MainOrders item)
        {
            Db.MainOrderses.Add(item);
        }

        public void Update(MainOrders item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainOrderses.Find(id);

            if (item != null)
            {
                Db.MainOrderses.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}