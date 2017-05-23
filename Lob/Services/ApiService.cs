using Lob.Interfaces;
using Lob.Requests;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http.Headers;
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
            WebRequest webRequest = WebRequest.Create(request.Url);

            webRequest.Method = request.Method;
            webRequest.ContentType = request.ContentType;
            webRequest.Credentials = CredentialCache.DefaultNetworkCredentials;

            webRequest.Headers.Add("Authorization", GetAuthHeader());

            UTF8Encoding utd8WithoutBom = new UTF8Encoding(false);
            webRequest.ContentLength = utd8WithoutBom.GetByteCount(request.Data);
            using (var writer = new StreamWriter(webRequest.GetRequestStream(), utd8WithoutBom))
            {
                writer.Write(request.Data);
            }

            string content = "";
            HttpWebResponse authResponse = null;

            try
            {
                authResponse = (HttpWebResponse)webRequest.GetResponse();
            }
            catch (WebException ex)
            {
                using (var reader = new StreamReader(ex.Response.GetResponseStream(), Encoding.UTF8))
                {
                    content = reader.ReadToEnd();
                }

                throw new Exception(content, ex);
            }

            using (var reader = new StreamReader(authResponse.GetResponseStream(), Encoding.UTF8))
            {
                content = reader.ReadToEnd();
            }

            TResponse response = JsonConvert.DeserializeObject<TResponse>(content);

            return response;
        }

        private string GetAuthHeader()
        {
            var encodedApiKey = Convert.ToBase64String(Encoding.ASCII.GetBytes(string.Format("{0}:{1}", ApiToken, null)));
            return "Basic " + encodedApiKey;
        }
    }
}
