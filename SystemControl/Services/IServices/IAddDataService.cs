namespace Services.IServices
{
    public interface IAddDataService<T>
    {
        T AddingEntity { get; set; }

        string Invoke();
    }
}