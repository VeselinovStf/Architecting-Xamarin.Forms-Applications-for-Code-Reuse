using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Globomatics.MobileApp
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
        }

        public void Register<TInterface, TImplementation>()
           where TImplementation : class, TInterface
           where TInterface : class => ViewModelLocator.Register<TInterface, TImplementation>();


        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
