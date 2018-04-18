using Stores.Data.Infrastructure;
using Stores.Data.Repositories;
using Stores.Model;
using System;
using System.Collections.Generic;

namespace Stores.Service
{
    // operations you want to expose
    public interface ICustomerService
    {
        IEnumerable<Customer> GetCustomers();
        Customer GetCustomer(int id);
        void CreateCustomer(Customer customer);
        void SaveCustomer();
        void DeleteCustomer(int id);
    }
    public class CustomerService : ICustomerService
    {

        private readonly ICustomerRepository customersRepository;
        private readonly IUnitOfWork unitOfWork;

        public CustomerService(ICustomerRepository customersRepository, IUnitOfWork unitOfWork)
        {
            this.customersRepository = customersRepository;
            this.unitOfWork = unitOfWork;
        }


        #region ICustomerService Members
        public void CreateCustomer(Customer customer)
        {
            customersRepository.Add(customer);
        }

        public void DeleteCustomer(int id)
        {
            throw new NotImplementedException();
        }

        public Customer GetCustomer(int id)
        {
            return customersRepository.GetById(id);
        }

        public IEnumerable<Customer> GetCustomers()
        {
            return customersRepository.GetAll();
        }

        public void SaveCustomer()
        {
            unitOfWork.Commit();
        }
        #endregion
    }
}
