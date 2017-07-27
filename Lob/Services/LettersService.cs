using Lob.Data;
using Lob.Interfaces;
using Lob.Models;
using System.Collections.Generic;

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
            string url = Routes.Letters.Create;
            return ApiService.Post<Letter>(url, letter.Serialize());
        }

        public Letter Retrieve(string id)
        {
            string url = Routes.Letters.Retrieve(id);
            return ApiService.Get<Letter>(url);
        }

        public LetterCancellation Cancel(string id)
        {
            string url = Routes.Letters.Cancel(id);
            return ApiService.Delete<LetterCancellation>(url);
        }

        public LetterList List(int limit, int offset)
        {
            string url = Routes.Letters.List(limit, offset);
            return ApiService.Get<LetterList>(url);
        }
    }
}
