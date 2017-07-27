using Lob.Models;
using Lob.Services;

namespace Lob.Actions
{
    public class Cancel : Action
    {
        public Cancel(string apiKey)
            : base(apiKey) { }

        /// <summary>
        /// Cancel a letter
        /// </summary>
        /// <param name="id">The identifier of the letter to be canceled.</param>
        /// <returns></returns>
        public LetterCancellation Letter(string id)
        {
            var service = new LettersService(ApiKey);
            LetterCancellation cancellation = service.Cancel(id);
            return cancellation;
        }
    }
}
