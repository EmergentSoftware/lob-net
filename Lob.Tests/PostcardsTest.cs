using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lob.Models;

namespace Lob.Tests
{
    [TestClass]
    public class PostCardsTest : LobTest
    {
        [TestMethod]
        public void CreatePostCard()
        {
            Postcard postcard = Lob.Create.Postcard(Postcard);
        }
    }
}
