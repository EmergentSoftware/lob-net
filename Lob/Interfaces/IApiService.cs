namespace Lob.Interfaces
{
    public interface IApiService
    {
        TResponse Post<TResponse>(string url, string data);
        TResponse Get<TResponse>(string url);
        TResponse Delete<TResponse>(string url);
    }
}
