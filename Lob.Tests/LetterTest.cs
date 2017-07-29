using Lob.Models;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Lob.Tests
{
    [TestClass]
    public class LetterTest : LobTest
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
            Cancellation cancellation = Lob.Cancel.Letter(Constants.Letter.Id);
        }

        [TestMethod]
        public void ListLetters()
        {
            ModelList<Letter> letters = Lob.List.Letters(limit: 2, offset: 0);
        }
    }
}
