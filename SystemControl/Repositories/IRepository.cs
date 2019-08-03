using System;
using System.Collections.Generic;
using Models;

namespace Repositories
{
    public interface IRepository<T> : IDisposable
        where T : class
    {
        SystemControlContext Db { get; set; }

        List<T> GetList();

        T GetItem(int id);

        void Create(T item);

        void Update(T item);

        void Delete(int id);

        void Save();
    }
}