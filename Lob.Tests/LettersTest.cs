using Lob.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lob.Tests
{
    [TestClass]
    public class LettersTest : LobTest
    {
        [TestMethod]
        public void CreateValidLetter()
        {
            Letter createdLetter = Lob.Create.Letter(Letter);
        }

        [TestMethod]
        public void RetrieveLetter()
        {
            Letter letter = Lob.Retrieve.Letter(Constants.Letter.Id);
        }
    }
}
