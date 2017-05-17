using Lob.Interfaces;
using Lob.Routes;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Services
{
    public class USVerificationService : IUSVerificationService
    {
        private IApiService ApiService { get; set; }

        public USVerificationService(string apiKey) 
            : this(new ApiService(apiKey)) { }

        public USVerificationService(IApiService apiService)
        {
            ApiService = apiService;
        }

        public Verification Verify(Address address)
        {
            string url = ApiRoutes.Verifications.US;
            return ApiService.Post<Verification>(url, address.ToJson());
        }
    }

    public interface IUSVerificationService
    {

    }

    public class Verification
    {

    }
}
