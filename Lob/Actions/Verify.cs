using Lob.Data;
using Lob.Services;

namespace Lob.Actions
{
    public class Verify : Action
    {
        public Verify(string apiKey)
            : base(apiKey) { }

        /// <summary>
        /// Verify a domestic address. 
        /// Only requests with live API keys will use valid CASS data to generate a response. 
        /// Properly formatted requests with test API keys will return the generic dummy response on the right, regardless of inputs.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public USVerification USAddress(USAddress address)
        {
            var service = new USVerificationService(ApiKey);
            USVerification verification = service.Verify(address);
            return verification;
        }
    }
}
