using System.Collections.Generic;
using System.Linq;
using Models;
using Models.MainModels;

namespace Repositories
{
    public class MainEquipmentRepository : IRepository<MainEquipment>
    {
        public void Dispose()
        {
            throw new System.NotImplementedException();
        }

        public SystemControlContext Db { get; set; }

        public List<MainEquipment> GetList()
        {
            return Db.MainEquipments.ToList();
        }

        public MainEquipment GetItem(int id)
        {
            return Db.MainEquipments.Find(id);
        }

        public void Create(MainEquipment item)
        {
            Db.MainEquipments.Add(item);
        }

        public void Update(MainEquipment item)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(int id)
        {
            var item = Db.MainEquipments.Find(id);

            if (item != null)
            {
                Db.MainEquipments.Remove(item);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }
    }
}