using Lob.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
