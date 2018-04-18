using Stores.Data.Infrastructure;
using Stores.Data.Repositories;
using System;
using System.Collections.Generic;

namespace Stores.Service
{
    // operations you want to expose
    public interface IStoreService
    {
        IEnumerable<Stores.Model.Store> GetStores();
        Stores.Model.Store GetStore(int id);
        void CreateStore(Stores.Model.Store store);
        void SaveStore();
        void DeleteStore(int id);
    }
    public class StoreService : IStoreService
    {

        private readonly IStoreRepository storesRepository;
        private readonly IUnitOfWork unitOfWork;

        public StoreService(IStoreRepository storesRepository, IUnitOfWork unitOfWork)
        {
            this.storesRepository = storesRepository;
            this.unitOfWork = unitOfWork;
        }


        #region IStoreService Members
        public void CreateStore(Stores.Model.Store store)
        {
            storesRepository.Add(store);
        }

        public void DeleteStore(int id)
        {
            throw new NotImplementedException();
        }

        public Stores.Model.Store GetStore(int id)
        {
            return storesRepository.GetById(id);
        }

        public IEnumerable<Stores.Model.Store> GetStores()
        {
            return storesRepository.GetAll();
        }

        public void SaveStore()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
