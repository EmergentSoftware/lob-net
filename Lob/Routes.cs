﻿namespace Lob
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
            public static string Cancel(string id) => $"{BaseUrl}/letters/{id}";
            public static string List(int limit, int offset) => $"{BaseUrl}/letters?limit={limit}&offset={offset}";
        }

        public class Postcards
        {
            public const string Create = BaseUrl + "/postcards";
            public static string Retrieve(string id) => $"{BaseUrl}/postcards/{id}";
            public static string Cancel(string id) => $"{BaseUrl}/postcards/{id}";
            public static string List(int limit, int offset) => $"{BaseUrl}/postcards?limit={limit}&offset={offset}";
        }

        public class Addresses
        {
            public const string Create = BaseUrl + "/addresses";
            public static string Retrieve(string id) => $"{BaseUrl}/addresses/{id}";
            public static string Cancel(string id) => $"{BaseUrl}/addresses/{id}";
            public static string List(int limit, int offset) => $"{BaseUrl}/addresses?limit={limit}&offset={offset}";
        }
    }
}
