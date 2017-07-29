using System.Configuration;

namespace Lob.Tests
{
    public class Constants
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];

        public class Letter
        {
            public const string Id = "ltr_4868c3b754655f90";
        }

        public class Postcard
        {
            public const string Id = "psc_5c002b86ce47537a";
        }

        public class Address
        {
            public const string Id = "adr_fa85158b26c3eb7c";
        }
    }
}
