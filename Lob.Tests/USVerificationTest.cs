using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lob.Services;
using Lob.Data;

namespace Lob.Tests
{
    [TestClass]
    public class USVerificationTest : LobTest
    {
        [TestMethod]
        public void VerifyValidAddress()
        {
            var address = new USAddress
            {
                PrimaryLine = "185 Berry Street",
                City = "San Francisco",
                State = "CA",
                ZipCode = "94107"
            };

            USVerification verification = Lob.Verify(address);
        }
    }
}
