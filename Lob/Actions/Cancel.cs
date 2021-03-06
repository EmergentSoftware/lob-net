﻿using Lob.Models;
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
        public Cancellation Letter(string id)
        {
            var service = new LetterService(ApiKey);
            Cancellation cancellation = service.Cancel(id);
            return cancellation;
        }

        /// <summary>
        /// Cancel a postcard
        /// </summary>
        /// <param name="id">The identifier of the postcard to be canceled.</param>
        /// <returns></returns>
        public Cancellation Postcard(string id)
        {
            var service = new PostcardService(ApiKey);
            Cancellation cancellation = service.Cancel(id);
            return cancellation;
        }
    }
}
