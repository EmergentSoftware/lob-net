using Lob.Data;
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
            var service = new LettersService(ApiKey);
            var createdLetter = service.Create(letter);
            return createdLetter;
        }
    }
}
