using Lob.Models;
using Lob.Services;

namespace Lob.Actions
{
    public class Create : Action
    {
        public Create(string apiKey)
            : base(apiKey) { }

        /// <summary>
        /// Create a new letter
        /// </summary>
        /// <param name="letter">Letter to create</param>
        /// <returns></returns>
        public Letter Letter(Letter letter)
        {
            var service = new LetterService(ApiKey);
            var createdLetter = service.Create(letter);
            return createdLetter;
        }

        /// <summary>
        /// Create a new postcard
        /// </summary>
        /// <param name="letter">Letter to create</param>
        /// <returns></returns>
        public Postcard Postcard(Postcard postcard)
        {
            var service = new PostcardService(ApiKey);
            var createdPostcard = service.Create(postcard);
            return createdPostcard;
        }
    }
}
