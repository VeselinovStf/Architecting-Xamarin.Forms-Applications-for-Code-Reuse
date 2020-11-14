using Globomantics.MobileApp.Common.Models;
using System.Threading.Tasks;

namespace Globomantics.MobileApp.Common.Abstraction
{
    public interface ICustomerDAL
    {
        Task<Customer> GetCustomerById(string customerId);
    }
}
