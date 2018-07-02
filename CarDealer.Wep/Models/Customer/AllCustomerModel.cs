

namespace CarDealer.Wep.Models.Customer
{
    using System.Collections.Generic;
    
    using CarDealer.Services.Models;

    public class AllCustomerModel
    {
        public IEnumerable<CustomerModel> Customer { set; get; }

        public OrderDirection OrderDirection { get; set; }
    }
}
