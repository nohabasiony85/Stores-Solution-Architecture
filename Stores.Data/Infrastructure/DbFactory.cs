namespace Stores.Data.Infrastructure
{
    class DbFactory : IDbFactory
    {
        StoreEntities dbContext;
        public void Dispose()
        {
            if (dbContext != null)
                dbContext.Dispose();
        }

        public StoreEntities Init()
        {
            return dbContext ?? (dbContext = new StoreEntities());
        }
    }
}
