using Globomantics.MobileApp.Common.Models;
using Globomantics.MobileApp.Common.Abstraction;
using System.Threading.Tasks;

namespace Globomantics.MobileApp.DAL
{
    public class CustomerDAL : ICustomerDAL
    {
        public async Task<Customer> GetCustomerById(string customerId)
        {
            return new Customer();
        }

        //TODO: Implement remaining CRUD methods
    }
}
