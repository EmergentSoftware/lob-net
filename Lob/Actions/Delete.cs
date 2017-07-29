using Lob.Models;
using Lob.Services;

namespace Lob.Actions
{
    public class Delete : Action
    {
        public Delete(string apiKey)
            : base(apiKey) { }

        /// <summary>
        /// Delete an address
        /// </summary>
        /// <param name="id">The identifier of the address to be deleted.</param>
        /// <returns></returns>
        public Deletion Address(string id)
        {
            var service = new AddressService(ApiKey);
            Deletion deletion = service.Delete(id);
            return deletion;
        }
    }
}
