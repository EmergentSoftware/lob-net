using Lob.Data;
using Lob.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob
{
    public class Lob
    {
        private string ApiKey { get; set; }

        public Lob(string apiKey)
        {
            ApiKey = apiKey;
        }

        /// <summary>
        /// Verify a domestic address. Only requests with live API keys will use valid CASS data to generate a response. Properly formatted requests with test API keys will return the generic dummy response on the right, regardless of inputs.
        /// </summary>
        /// <param name="address"></param>
        /// <returns></returns>
        public USVerification Verify(USAddress address)
        {
            var service = new USVerificationService(ApiKey);

            USVerification verification = service.Verify(address);

            return verification;
        }
    }
}
