using Lob.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Tests
{
    [TestClass]
    public class LettersTest : LobTest
    {
        [TestMethod]
        public void CreateValidLetter()
        {
            Letter createdLetter = Lob.Create(Letter);
        }

        [TestMethod]
        public void SerializeLetter()
        {
            string json = Letter.Serialize();
        }
    }
}
