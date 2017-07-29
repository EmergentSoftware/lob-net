using Lob.Models;
using Lob.Services;

namespace Lob.Actions
{
    public class List : Action
    {
        public List(string apiKey)
            : base(apiKey) { }

        /// <summary>
        /// List all letters
        /// </summary>
        /// <param name="limit">How many results to return.</param>
        /// /// <param name="offset">Return requested # of items starting with the value, default=0, must be an integer.</param>
        /// <returns></returns>
        public ModelList<Letter> Letters(int limit, int offset)
        {
            var service = new LetterService(ApiKey);
            ModelList<Letter> letters = service.List(limit, offset);
            return letters;
        }

        /// <summary>
        /// List all postcards
        /// </summary>
        /// <param name="limit">How many results to return.</param>
        /// <param name="offset">Return requested # of items starting with the value, default=0, must be an integer.</param>
        /// <returns></returns>
        public ModelList<Postcard> Postcards(int limit, int offset)
        {
            var service = new PostcardService(ApiKey);
            ModelList<Postcard> postcards = service.List(limit, offset);
            return postcards;
        }

        /// <summary>
        /// List all addresses
        /// </summary>
        /// <param name="limit">How many results to return.</param>
        /// <param name="offset">Return requested # of items starting with the value, default=0, must be an integer.</param>
        /// <returns></returns>
        public ModelList<Address> Addresses(int limit, int offset)
        {
            var service = new AddressService(ApiKey);
            ModelList<Address> addresses = service.List(limit, offset);
            return addresses;
        }
    }
}
