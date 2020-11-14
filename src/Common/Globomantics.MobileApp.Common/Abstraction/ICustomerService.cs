using Globomantics.MobileApp.Common.Models;

namespace Globomantics.MobileApp.Common.Abstraction
{
    public interface ICustomerService
    {
        Customer GetCustomerById(string customerId);
    }
}
