using Lob.Interfaces;
using Lob.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Services
{
    public class ApiService : IApiService
    {
        private string ApiToken { get; set; }

        public ApiService(string apiToken)
        {
            ApiToken = apiToken;
        }

        public TResponse Post<TResponse>(string url, string data)
        {
            return Post<TResponse>(new PostRequest()
            {
                Url = url,
                Data = data
            });
        }

        private TResponse Post<TResponse>(PostRequest request)
        {
            WebRequest authRequest = WebRequest.Create(request.Url);

            authRequest.Method = request.Method;
            authRequest.ContentType = request.ContentType;
            authRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            authRequest.Headers.Add(GetAuthHeader());

            string value = "";
            UTF8Encoding utd8WithoutBom = new UTF8Encoding(false);
            value += request.Data;
            authRequest.ContentLength = utd8WithoutBom.GetByteCount(value);
            using (var writer = new StreamWriter(authRequest.GetRequestStream(), utd8WithoutBom))
            {
                writer.Write(value);
            }

            HttpWebResponse authResponse = (HttpWebResponse)authRequest.GetResponse();
            string content = "";
            using (var reader = new StreamReader(authResponse.GetResponseStream(), Encoding.UTF8))
            {
                content = reader.ReadToEnd();
            }

            TResponse response = JsonConvert.DeserializeObject<TResponse>(content);
            return response;
        }

        private string GetAuthHeader()
        {
            var encodedApiKey = Convert.ToBase64String(Encoding.ASCII.GetBytes(ApiToken));
            return "Authorization: Basic " + encodedApiKey;
        }
    }
}
