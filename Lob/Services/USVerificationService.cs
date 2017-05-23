using Lob.Data;
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
    public class USVerificationService : Service, IUSVerificationService
    {
        public USVerificationService(string apiKey)
            : base(apiKey) { }

        public USVerificationService(IApiService apiService)
            : base(apiService) { }

        public USVerification Verify(USAddress address)
        {
            string url = ApiRoutes.Verifications.US;
            return ApiService.Post<USVerification>(url, address.Serialize());
        }
    }
}
