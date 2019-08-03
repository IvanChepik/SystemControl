using Models;

namespace Services.IServices
{
    public interface IDeleteService
    {
        ModelsType ModelsType { get; set; }

        int Id { get; set; }

        string Invoke();
    }
}