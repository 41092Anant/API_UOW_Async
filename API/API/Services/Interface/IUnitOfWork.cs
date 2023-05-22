namespace API.Services.Interface
{
    public interface IUnitOfWork : IDisposable
    {
        IPersonRepository Person { get; }
        int Save();
    }
}
