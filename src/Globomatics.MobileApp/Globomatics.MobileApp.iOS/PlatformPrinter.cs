using Globomantics.MobileApp.Common.Abstraction;
using Globomatics.MobileApp.iOS;
using Xamarin.Forms;

[assembly: Dependency(typeof(PlatformPrinter))]
namespace Globomatics.MobileApp.iOS
{
    public class PlatformPrinter : IPlatformPrinter
    {
        public string GetPlatformString()
        {
            return "iOS Platform Specific Printer";
        }
    }
}