using Lob.Interfaces;
using Lob.Models;

namespace Lob.Services
{
    public class PostcardService : Service, IPostcardService
    {
        public PostcardService(string apiKey)
            : base(apiKey) { }

        public Postcard Create(Postcard postcard)
        {
            string url = Routes.Postcards.Create;
            return ApiService.Post<Postcard>(url, postcard.Serialize());
        }
    }
}
