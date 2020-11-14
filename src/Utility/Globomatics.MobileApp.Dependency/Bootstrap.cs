using Globomantics.MobileApp.Common.Abstraction;
using Globomantics.MobileApp.DAL;
using Globomantics.MobileApp.Services;
using System;
using System.Collections.Generic;
using System.Text;
using TinyIoC;

namespace Globomatics.MobileApp.Dependency
{
    public static class Bootstrap
    {
        internal static TinyIoCContainer GetCContainer()
        {
            var container = new TinyIoCContainer();

            container.Register<ICustomerDAL, CustomerDAL>();
            container.Register<ICustomerService, CustomerService>();

            return container;
        }

        public static ILocator GetLocator()
        {
            return new Locator(Bootstrap.GetCContainer());
        }
    }
}
