using Globomantics.MobileApp.Common.Abstraction;
using Globomatics.MobileApp.Droid;
using Xamarin.Forms;

//[assembly: Dependency(typeof(PlatformPrinter))]
namespace Globomatics.MobileApp.Droid
{
    public class PlatformPrinter : IPlatformPrinter
    {
        public string GetPlatformString()
        {
            return "Android Platform Specific Printer";
        }
    }
}