using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainRequestRepository : IRepository<MainRequest>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }
        public List<MainRequest> GetList()
        {
            return Db.MainRequests.ToList();
        }

        public MainRequest GetItem(int id)
        {
            return Db.MainRequests.Find(id);
        }

        public void Create(MainRequest item)
        {
            Db.MainRequests.Add(item);
        }

        public void Update(MainRequest item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainRequests.Find(id);

            if (item != null)
            {
                Db.MainRequests.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}