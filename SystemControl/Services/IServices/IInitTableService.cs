using System.Collections.Generic;
using Models;
using Models.ChildModels;

namespace Services.IServices
{
    public interface IInitTableService<T>
    {
        ModelsType ModelsType { get; set; }

        List<T> Invoke();
    }
}