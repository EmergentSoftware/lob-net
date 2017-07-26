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
    }
}
