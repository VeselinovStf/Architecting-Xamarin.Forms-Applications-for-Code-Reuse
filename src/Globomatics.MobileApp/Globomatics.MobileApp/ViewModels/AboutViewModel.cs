using Globomantics.MobileApp.Common.Abstraction;
using Globomantics.MobileApp.Services;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Globomatics.MobileApp.ViewModels
{
    public class AboutViewModel : BaseViewModel
    {
        private ICustomerService _customerService;


        public AboutViewModel(ICustomerService customerService)
        {
            Title = "About";
            _customerService = customerService;

            
        }


        public void GetCustomer()
        {
            //Checking if all is working correct
            var newTitle =  _customerService.GetCustomerById("SV");

            Title = newTitle.FirstName;
        }

    }
}
