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
        public LetterList Letters(int limit, int offset)
        {
            var service = new LettersService(ApiKey);
            LetterList letters = service.List(limit, offset);
            return letters;
        }
    }
}
