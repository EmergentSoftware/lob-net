using Lob.Data;
using Lob.Services;
using System;

namespace Lob.Actions
{
    public class Retrieve : Action
    {
        public Retrieve(string apiKey)
            : base(apiKey) { }

        public Letter Letter(string id)
        {
            var service = new LettersService(ApiKey);
            var letter = service.Retrieve(id);
            return letter;
        }
    }
}
