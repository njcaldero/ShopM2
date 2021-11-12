using ShopM2.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopM2.Core.Interfaces
{
    public interface ICustomerRepository
    {
        Customer Insert(Customer customer);

        Customer SelectByEmail(string email);
    }
}
