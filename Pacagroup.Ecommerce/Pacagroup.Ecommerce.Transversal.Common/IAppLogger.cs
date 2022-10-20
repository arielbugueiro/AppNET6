namespace Pacagroup.Ecommerce.Transversal.Common
{
    public interface IAppLogger<T>
    {
        void LogInformation(string message, params object[] arg);
        void LogWarning(string message, params object[] arg);
        void LogError(string message, params object[] arg);
    }
}
