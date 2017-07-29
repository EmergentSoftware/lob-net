using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lob.Models;

namespace Lob.Tests
{
    [TestClass]
    public class PostCardTest : LobTest
    {
        [TestMethod]
        public void CreatePostcard()
        {
            Postcard postcard = Lob.Create.Postcard(Postcard);
        }

        [TestMethod]
        public void RetrievePostcard()
        {
            Postcard postcard = Lob.Retrieve.Postcard(Constants.Postcard.Id);
        }

        [TestMethod]
        public void CancelPostcard()
        {
            Cancellation cancellation = Lob.Cancel.Postcard(Constants.Postcard.Id);
        }

        [TestMethod]
        public void ListPostcards()
        {
            ModelList<Postcard> postcards = Lob.List.Postcards(limit: 2, offset: 0);
        }
    }
}
