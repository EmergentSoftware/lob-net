using Lob.Interfaces;
using Lob.Models;

namespace Lob.Services
{
    public class PostcardService : Service, IModelService<Postcard>
    {
        public PostcardService(string apiKey)
            : base(apiKey) { }

        public Postcard Create(Postcard postcard)
        {
            string url = Routes.Postcards.Create;
            return ApiService.Post<Postcard>(url, postcard.Serialize());
        }

        public Postcard Retrieve(string id)
        {
            string url = Routes.Postcards.Retrieve(id);
            return ApiService.Get<Postcard>(url);
        }

        public Cancellation Cancel(string id)
        {
            string url = Routes.Postcards.Cancel(id);
            return ApiService.Get<Cancellation>(url);
        }

        public ModelList<Postcard> List(int limit, int offset)
        {
            string url = Routes.Postcards.List(limit, offset);
            return ApiService.Get<ModelList<Postcard>>(url);
        }
    }
}
