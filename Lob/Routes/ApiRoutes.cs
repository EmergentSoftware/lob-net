using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Routes
{
    public static class ApiRoutes
    {
        private const string BaseUrl = "https://api.lob.com/v1";

        public static class Verifications
        {
            public const string US = BaseUrl + "/us_verifications";
            public const string Intl = BaseUrl + "/intl_verifications";
        }
    }
}
