using Lob.Models;
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

        [TestMethod]
        public void CancelLetter()
        {
            LetterCancellation cancellation = Lob.Cancel.Letter(Constants.Letter.Id);
        }

        [TestMethod]
        public void ListLetters()
        {
            LetterList letters = Lob.List.Letters(limit: 2, offset: 0);
        }
    }
}
