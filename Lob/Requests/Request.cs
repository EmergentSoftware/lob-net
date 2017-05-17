using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

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
            Method = "GET";
            ContentType = "application/json";
        }
    }
}
