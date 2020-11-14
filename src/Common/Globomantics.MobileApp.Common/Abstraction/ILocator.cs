namespace Globomantics.MobileApp.Common.Abstraction
{
    public interface ILocator
    {
        T GetInstance<T>() where T : class;

        void Register<T>() where T : class;

        //Example Use: Remove DependencyService from ViewModels
        void Register<T>(T instance) where T : class;

        void Register<TInterface, TImplementation>()
            where TImplementation : class, TInterface
            where TInterface : class;
    }
}
