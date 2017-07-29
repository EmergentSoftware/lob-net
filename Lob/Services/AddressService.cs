using Lob.Interfaces;
using Lob.Models;

namespace Lob.Services
{
    public class AddressService : Service, IModelService<Address>, IDeleteService
    {
        public AddressService(string apiKey)
            : base(apiKey) { }

        public Address Create(Address address)
        {
            string url = Routes.Addresses.Create;
            return ApiService.Post<Address>(url, address.Serialize());
        }

        public Address Retrieve(string id)
        {
            string url = Routes.Addresses.Retrieve(id);
            return ApiService.Get<Address>(url);
        }

        public Deletion Delete(string id)
        {
            string url = Routes.Postcards.Cancel(id);
            return ApiService.Get<Deletion>(url);
        }

        public ModelList<Address> List(int limit, int offset)
        {
            string url = Routes.Addresses.List(limit, offset);
            return ApiService.Get<ModelList<Address>>(url);
        }
    }
}
