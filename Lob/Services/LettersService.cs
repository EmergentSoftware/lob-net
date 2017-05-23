using Lob.Data;
using Lob.Interfaces;
using Lob.Routes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Services
{
    public class LettersService : Service, ILettersService
    {
        public LettersService(string apiKey)
            : base(apiKey) { }

        public LettersService(IApiService apiService)
            : base(apiService) { }

        public Letter Create(Letter letter)
        {
            string url = ApiRoutes.Letters.Create;
            return ApiService.Post<USVerification>(url, letter.Serialize());
        }
    }
}
