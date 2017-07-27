﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Lob.Models;

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

            USVerification verification = Lob.Verify.USAddress(address);
        }
    }
}
