using Globomantics.MobileApp.Common;
using System;
using System.Threading.Tasks;

namespace Globomantics.MobileApp.Services
{
    public class CustomerService
    {
        public  Customer GetCustomerById(string customerId)
        {
            return new Customer() { FirstName = customerId};
        }

        //TODO: Implement remaining CRUD methods
    }
}
