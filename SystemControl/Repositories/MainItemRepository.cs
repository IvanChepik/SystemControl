using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainItemRepository : IRepository<MainItem>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<MainItem> GetList()
        {
            return Db.MainItems.ToList();
        }

        public MainItem GetItem(int id)
        {
            return Db.MainItems.Find(id);
        }

        public void Create(MainItem item)
        {
            Db.MainItems.Add(item);
        }

        public void Update(MainItem item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainItems.Find(id);

            if (item != null)
            {
                Db.MainItems.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}