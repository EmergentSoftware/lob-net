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
        /// <param name="id">The identifier of the letter to be canceled.</param>
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
        /// <param name="id">The identifier of the postcard to be cancelled.</param>
        /// <returns></returns>
        public ModelList<Postcard> Postcards(int limit, int offset)
        {
            var service = new PostcardService(ApiKey);
            ModelList<Postcard> postcards = service.List(limit, offset);
            return postcards;
        }
    }
}
