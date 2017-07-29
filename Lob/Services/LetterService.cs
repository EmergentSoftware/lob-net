using Lob.Interfaces;
using Lob.Models;

namespace Lob.Services
{
    public class LetterService : Service, IModelService<Letter>
    {
        public LetterService(string apiKey)
            : base(apiKey) { }

        public LetterService(IApiService apiService)
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

        public Cancellation Cancel(string id)
        {
            string url = Routes.Letters.Cancel(id);
            return ApiService.Delete<Cancellation>(url);
        }

        public ModelList<Letter> List(int limit, int offset)
        {
            string url = Routes.Letters.List(limit, offset);
            return ApiService.Get<ModelList<Letter>>(url);
        }
    }
}
