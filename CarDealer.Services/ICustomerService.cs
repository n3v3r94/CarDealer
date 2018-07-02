
namespace CarDealer.Services
{
   
    using System.Collections.Generic;
    using Models;
    public interface ICustomerService
    {
        IEnumerable<CustomerModel> OrderCustomers(OrderDirection order);
    }
}
