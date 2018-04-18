using Stores.Data.Infrastructure;
using Stores.Data.Repositories;
using Stores.Model;
using System;
using System.Collections.Generic;

namespace Stores.Service
{
    // operations you want to expose
    public interface IProductService
    {
        IEnumerable<Product> GetProducts();
        Product GetProduct(int id);
        void CreateProduct(Product product);
        void SaveProduct();
        void DeleteProduct(int id);
    }
    public class ProductService : IProductService
    {

        private readonly IProductRepository productsRepository;
        private readonly IUnitOfWork unitOfWork;

        public ProductService(IProductRepository productsRepository, IUnitOfWork unitOfWork)
        {
            this.productsRepository = productsRepository;
            this.unitOfWork = unitOfWork;
        }


        #region IProductService Members
        public void CreateProduct(Product product)
        {
            productsRepository.Add(product);
        }

        public void DeleteProduct(int id)
        {
            throw new NotImplementedException();
        }

        public Product GetProduct(int id)
        {
            return productsRepository.GetById(id);
        }

        public IEnumerable<Product> GetProducts()
        {
            return productsRepository.GetAll();
        }

        public void SaveProduct()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
