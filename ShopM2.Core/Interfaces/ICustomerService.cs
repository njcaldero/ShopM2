using ShopM2.Core.Entities;

namespace ShopM2.Core.Interfaces
{
    public interface ICustomerService
    {
        Customer Insert(Customer customer);

        Customer SelectByEmail(string email);
    }
}