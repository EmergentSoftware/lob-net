using Lob.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lob.Tests
{
    [TestClass]
    public class AddressTest : LobTest
    {
        [TestMethod]
        public void CreateAddress()
        {
            Address address = Lob.Create.Address(Address);
        }

        [TestMethod]
        public void RetrieveAddress()
        {
            Address address = Lob.Retrieve.Address(Constants.Address.Id);
        }

        [TestMethod]
        public void CancelAddress()
        {
            Cancellation cancellation = Lob.Cancel.Postcard(Constants.Address.Id);
        }

        [TestMethod]
        public void ListAddresses()
        {
            ModelList<Address> addresses = Lob.List.Addresses(limit: 2, offset: 0);
        }
    }
}
