namespace Globomantics.MobileApp.Common.Abstraction
{
    public interface ILocator
    {
        T GetInstance<T>() where T : class;

        void Register<T>() where T : class;
    }
}
