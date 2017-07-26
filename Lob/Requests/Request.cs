using System.Net;

namespace Lob.Requests
{
    public class Request
    {
        public string Url { get; set; }
        public string Method { get; set; }
        public string ContentType { get; set; }
        public NetworkCredential Credential { get; set; }
        public CookieContainer Container { get; set; }

        public Request()
        {
            ContentType = "application/json";
        }
    }
}
