using ShopM2.Core.Entities;
using ShopM2.Core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Services
{
    public class CustomerService : ICustomerService
    {
        private readonly ICustomerRepository customerRepository;

        public CustomerService(ICustomerRepository _customerRepository)
        {
            customerRepository = _customerRepository;
        }

        Customer Insert(Customer customer)
        {
            throw new NotImplementedException();
        }

        /// <summary>
        /// service that returns the list of products
        /// </summary>
        /// <returns></returns>
        Customer ICustomerService.Insert(Customer customer)
        {
            return customerRepository.Insert(customer);
        }

        Customer ICustomerService.SelectByEmail(string email)
        {
            return customerRepository.SelectByEmail(email);
        }
    }
}
