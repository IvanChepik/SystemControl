using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainCompetitionRepository : IRepository<MainCompetition>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }
        public List<MainCompetition> GetList()
        {
            return Db.MainCompetitions.ToList();
        }

        public MainCompetition GetItem(int id)
        {
            return Db.MainCompetitions.Find(id);
        }

        public void Create(MainCompetition item)
        {
            Db.MainCompetitions.Add(item);
        }

        public void Update(MainCompetition item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainCompetitions.Find(id);

            if (item != null)
            {
                Db.MainCompetitions.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}