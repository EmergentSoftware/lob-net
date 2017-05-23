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
            var letter = new Letter
            {

            };

            Letter createdLetter = Lob.Create(letter);
        }
    }
}
