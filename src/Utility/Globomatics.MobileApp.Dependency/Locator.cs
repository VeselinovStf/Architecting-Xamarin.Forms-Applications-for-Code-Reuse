using Globomantics.MobileApp.Common.Abstraction;
using System;
using TinyIoC;

namespace Globomatics.MobileApp.Dependency
{
    public class Locator : ILocator
    {
        private TinyIoCContainer _container;

        public Locator(TinyIoCContainer container)
        {
            _container = container;
        }
        public T GetInstance<T>() where T : class
        {
            return _container.Resolve<T>();
        }

        public void Register<T>() where T : class
        {
             _container.Register<T>();
        }

        public void Register<T>(T instance) where T : class
        {
            _container.Register<T>(instance);
        }

        void ILocator.Register<TInterface, TImplementation>() 
            where TImplementation : class
            where TInterface : class
        {
            _container.Register<TInterface, TImplementation>();
        }
    }
}
