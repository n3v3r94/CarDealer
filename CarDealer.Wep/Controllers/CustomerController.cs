


namespace CarDealer.Wep.Controllers
{
    using CarDealer.Services;
    using CarDealer.Services.Models;
    using Microsoft.AspNetCore.Mvc;
    using Models.Customer;
    


    public class CustomerController : Controller
    {
        public readonly ICustomerService customer;

        public CustomerController (ICustomerService customer)
        {
            this.customer = customer;
        }

        [Route("customers/all/{order}")]
        public IActionResult All (string id)
        {
            var orderDirection = id.ToLower() == "ascending" ? OrderDirection.Ascending : OrderDirection.Descending;

            var customers = this.customer.OrderCustomers(orderDirection);
            return View(new AllCustomerModel
            {
                Customer = customers,
                OrderDirection = orderDirection
            });
        }
    }
}
