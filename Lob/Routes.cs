namespace Lob
{
    public static class Routes
    {
        private const string BaseUrl = "https://api.lob.com/v1";

        public class Verifications
        {
            public const string US = BaseUrl + "/us_verifications";
            public const string Intl = BaseUrl + "/intl_verifications";
        }

        public class Letters
        {
            public const string Create = BaseUrl + "/letters";
            public static string Retrieve(string id) => $"{BaseUrl}/letters/{id}";
        }
    }
}
