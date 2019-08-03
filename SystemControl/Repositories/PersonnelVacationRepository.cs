using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using Models;
using Models.PersonnelModels;

namespace Repositories
{
    public class PersonnelVacationRepository : IRepository<PersonnelVacation>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<PersonnelVacation> GetList()
        {
            return Db.PersonnelVacations.ToList();
        }

        public PersonnelVacation GetItem(int id)
        {
            return Db.PersonnelVacations.Find(id);
        }

        public void Create(PersonnelVacation item)
        {
            Db.PersonnelVacations.Add(item);
        }

        public void Update(PersonnelVacation item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.PersonnelVacations.Find(id);

            if (item != null)
            {
                Db.PersonnelVacations.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}