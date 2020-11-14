using Globomantics.MobileApp.Common.Models;
using Globomantics.MobileApp.Common.Abstraction;

namespace Globomantics.MobileApp.Services
{
    public class CustomerService : ICustomerService
    {
        public  Customer GetCustomerById(string customerId)
        {
            return new Customer() { FirstName = customerId};
        }

        //TODO: Implement remaining CRUD methods
    }
}
