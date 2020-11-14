using Globomantics.MobileApp.Common.Abstraction;
using Globomatics.MobileApp.Dependency;
using Globomatics.MobileApp.ViewModels;
using Xamarin.Forms;

namespace Globomatics.MobileApp
{
    public static class ViewModelLocator
    {
        private static ILocator Locator = Bootstrap.GetLocator();

        static ViewModelLocator()
        {
            Locator.Register<AboutViewModel>();
            //Locator.Register<IPlatformPrinter>(DependencyService.Get<IPlatformPrinter>());
        }

        public static void Register<TInterface, TImplementation>()
            where TImplementation : class, TInterface
            where TInterface : class => Locator.Register<TInterface, TImplementation>();

        public static AboutViewModel AboutViewModel => Locator.GetInstance<AboutViewModel>();
    }
}
