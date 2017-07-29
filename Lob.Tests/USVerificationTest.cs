using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lob.Models;

namespace Lob.Tests
{
    [TestClass]
    public class USVerificationTest : LobTest
    {
        [TestMethod]
        public void VerifyValidAddress()
        {
            USVerification verification = Lob.Verify.USAddress(USAddress);
        }
    }
}
