using Globomantics.MobileApp.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Globomatics.MobileApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private CustomerService _customerService;


        public AboutViewModel()
        {
            Title = "About";
            _customerService = new CustomerService();

            
        }


        public void GetCustomer()
        {
            //Checking if all is working correct
            var newTitle =  _customerService.GetCustomerById("SV");

            Title = newTitle.FirstName;
        }

    }
}
