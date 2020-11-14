﻿using Globomantics.MobileApp.Common.Abstraction;
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
    }
}
