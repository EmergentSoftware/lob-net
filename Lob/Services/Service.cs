using Lob.Interfaces;

namespace Lob.Services
{
    public class Service
    {
        protected IApiService ApiService { get; set; }

        public Service(string apiKey) 
            : this(new ApiService(apiKey)) { }

        public Service(IApiService apiService)
        {
            ApiService = apiService;
        }
    }
}
