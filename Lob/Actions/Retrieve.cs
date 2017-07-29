using Lob.Models;
using Lob.Services;

namespace Lob.Actions
{
    public class Retrieve : Action
    {
        public Retrieve(string apiKey)
            : base(apiKey) { }

        public Letter Letter(string id)
        {
            var service = new LetterService(ApiKey);
            var letter = service.Retrieve(id);
            return letter;
        }

        public Postcard Postcard(string id)
        {
            var service = new PostcardService(ApiKey);
            var postcard = service.Retrieve(id);
            return postcard;
        }

        public Address Address(string id)
        {
            var service = new AddressService(ApiKey);
            var address = service.Retrieve(id);
            return address;
        }
    }
}
