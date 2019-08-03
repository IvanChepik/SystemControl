using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using Models;

namespace Repositories
{
    public class UserRepository : IRepository<User>
    {
        public SystemControlContext Db { get; set; }

        private bool _disposed;

        public UserRepository(SystemControlContext db)
        {
            Db = db;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        public virtual void Dispose(bool disposing)
        {
            if (!_disposed)
            {
                if (disposing)
                {
                    Db.Dispose();
                }
            }

            _disposed = true;
        }

        public List<User> GetList()
        {
            return Db.Users.ToList();
        }

        public User GetItem(int id)
        {
            return Db.Users.Find(id);
        }

        public void Create(User item)
        {
            Db.Users.Add(item);
        }

        public void Update(User item)
        {
            Db.Entry(item).State = EntityState.Modified;
        }

        public void Delete(int id)
        {
            var user = Db.Users.Find(id);

            if (user != null)
            {
                Db.Users.Remove(user);
            }
        }

        public void Save()
        {
            Db.SaveChanges();
        }

    }
}