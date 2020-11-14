using Globomantics.MobileApp.Common.Abstraction;
using Globomatics.MobileApp.UWP;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformPrinter))]
namespace Globomatics.MobileApp.UWP
{
    public class PlatformPrinter : IPlatformPrinter
    {
        public string GetPlatformString()
        {
            return "Android Platform Specific Printer";
        }
    }
}