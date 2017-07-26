using Lob.Data;
using Lob.Interfaces;

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
            string url = Routes.Verifications.US;
            return ApiService.Post<USVerification>(url, address.Serialize());
        }
    }
}
