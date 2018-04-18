namespace Stores.Data.Infrastructure
{
    public interface IUnitOfWork
    {
        void Commit();
    }
}
