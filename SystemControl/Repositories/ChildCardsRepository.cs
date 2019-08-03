using System.Collections.Generic;
using System.Linq;
using Models;
using Models.ChildModels;

namespace Repositories
{
    public class ChildCardsRepository : IRepository<ChildCard>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<ChildCard> GetList()
        {
            return Db.ChildCards.ToList();
        }

        public ChildCard GetItem(int id)
        {
            return Db.ChildCards.Find(id);
        }

        public void Create(ChildCard item)
        {
            Db.ChildCards.Add(item);
        }

        public void Update(ChildCard item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.ChildCards.Find(id);

            if (item != null)
            {
                Db.ChildCards.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}