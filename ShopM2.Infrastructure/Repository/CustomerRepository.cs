using AutoMapper;
using ShopM2.Core.Interfaces;
using ShopM2.Infrastructure.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Infrastructure.Repository
{
    public class CustomerRepository : BaseRepository<Customer>, ICustomerRepository
    {
        DbSet<Customer> entities;

        private readonly IMapper mapper;

        public CustomerRepository(SHOP_M2Entities context, IMapper _mapper) : base(context)
        {
            entities = context.Set<Customer>();
            mapper = _mapper;
        }

        Core.Entities.Customer ICustomerRepository.Insert(Core.Entities.Customer customer)
        {
            Customer customerMap = mapper.Map<Customer>(customer);

            Customer customerDB = entities.Add(customerMap);

            if (customerDB != null)
            {
                Core.Entities.Customer customerNew = mapper.Map<Core.Entities.Customer>(customerDB);
                return customerNew;
            }
            else return null;

        }

        Core.Entities.Customer ICustomerRepository.SelectByEmail(string email)
        {
            Customer customerDB = entities.Where(x => x.Email == email).FirstOrDefault();

            Core.Entities.Customer customer = mapper.Map<Core.Entities.Customer>(customerDB);

            return customer;

        }
    }
}
