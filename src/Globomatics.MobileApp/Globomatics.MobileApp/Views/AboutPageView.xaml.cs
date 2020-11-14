
using Globomatics.MobileApp.ViewModels;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Globomatics.MobileApp.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AboutPageView : ContentPage
    {
        public AboutPageView()
        {
            InitializeComponent();

            ViewModels = new AboutViewModel();

            BindingContext = ViewModels;
        }

        public AboutViewModel ViewModels { get; }

        private  void TEST_OnButtonCLicked(object sender, System.EventArgs e)
        {
             ViewModels.GetCustomer();

            Title = ViewModels.Title;
        }
    }
}