using Globomantics.MobileApp.Common.Abstraction;
using Globomatics.MobileApp.Dependency;
using Globomatics.MobileApp.ViewModels;

namespace Globomatics.MobileApp
{
    public static class ViewModelLocator
    {
        private static ILocator Locator = Bootstrap.GetLocator();

        static ViewModelLocator()
        {
            Locator.Register<AboutViewModel>();
        }

        public static AboutViewModel AboutViewModel => Locator.GetInstance<AboutViewModel>();
    }
}
