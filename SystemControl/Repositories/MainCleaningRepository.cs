using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainCleaningRepository : IRepository<MainCleaning>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<MainCleaning> GetList()
        {
            return Db.MainCleanings.ToList();
        }

        public MainCleaning GetItem(int id)
        {
            return Db.MainCleanings.Find(id);
        }

        public void Create(MainCleaning item)
        {
            Db.MainCleanings.Add(item);
        }

        public void Update(MainCleaning item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainCleanings.Find(id);

            if (item != null)
            {
                Db.MainCleanings.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}