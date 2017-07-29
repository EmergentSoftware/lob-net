using Lob.Interfaces;
using Lob.Models;

namespace Lob.Services
{
    public class USVerificationService : Service, IVerificationService<USVerification, USAddress>
    {
        public USVerificationService(string apiKey)
            : base(apiKey) { }

        public USVerificationService(IApiService apiService)
            : base(apiService) { }

        public USVerification Verify(USAddress address)
        {
            string url = Routes.Verifications.US;
            return ApiService.Post<USVerification>(url, address.Serialize());
        }
    }
}
