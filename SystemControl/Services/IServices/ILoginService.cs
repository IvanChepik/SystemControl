namespace Services.IServices
{
    public interface ILoginService
    {
        string Login { get; set; }

        string Password { get; set; }

        void InitLoginPassword(string login, string password);

        string Invoke();
    }
}