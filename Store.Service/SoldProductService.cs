using Stores.Data.Infrastructure;
using Stores.Data.Repositories;
using Stores.Model;
using System;
using System.Collections.Generic;

namespace Stores.Service
{
    // operations you want to expose
    public interface ISoldProductService
    {
        IEnumerable<SoldProduct> GetSoldProducts();
        SoldProduct GetSoldProduct(int id);
        void CreateSoldProduct(SoldProduct soldProduct);
        void SaveSoldProduct();
        void DeleteSoldProduct(int id);
    }
    public class SoldProductService : ISoldProductService
    {

        private readonly ISoldProductRepository soldProductsRepository;
        private readonly IUnitOfWork unitOfWork;

        public SoldProductService(ISoldProductRepository soldProductsRepository, IUnitOfWork unitOfWork)
        {
            this.soldProductsRepository = soldProductsRepository;
            this.unitOfWork = unitOfWork;
        }


        #region ISoldProductService Members
        public void CreateSoldProduct(SoldProduct soldProduct)
        {
            soldProductsRepository.Add(soldProduct);
        }

        public void DeleteSoldProduct(int id)
        {
            throw new NotImplementedException();
        }

        public SoldProduct GetSoldProduct(int id)
        {
            return soldProductsRepository.GetById(id);
        }

        public IEnumerable<SoldProduct> GetSoldProducts()
        {
            return soldProductsRepository.GetAll();
        }

        public void SaveSoldProduct()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
