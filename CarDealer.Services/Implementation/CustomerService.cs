



namespace CarDealer.Services.Implementation
{
    using Models;
    using Data;
   
    using System.Collections.Generic;
    using System.Linq;

    public class CustomerService : ICustomerService

    {
        private readonly CarDealerDbContext db;

        public CustomerService(CarDealerDbContext db)
        {
            this.db = db;
        }
        public IEnumerable<CustomerModel> OrderCustomers(OrderDirection order)
        {
            var CustomerQuery = this.db.Customers.AsQueryable();

            switch (order)
            {
                case OrderDirection.Ascending:
                    CustomerQuery = CustomerQuery.OrderBy(b => b.BirthDate).ThenBy(c=>c.Name);
                    break;
                case OrderDirection.Descending:
                    CustomerQuery = CustomerQuery.OrderByDescending(b => b.BirthDate).ThenBy(c=>c.Name);
                    break;
            
                default:
                    throw new System.InvalidOperationException($"Invali order direction {order}");

            }
            return CustomerQuery
                .Select(c => new CustomerModel
                {
                    Name = c.Name,
                    BirthDate = c.BirthDate,
                    IsYoungDriver = c.IsYoungDriver
               
                }).ToList();
                
        }
    }
}
