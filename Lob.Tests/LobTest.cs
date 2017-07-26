using Lob.Data;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Lob.Tests
{
    [TestClass]
    public class LobTest
    {
        public Lob Lob { get; set; }
        public Letter Letter { get; set; }
        public Address Address { get; set; }

        public LobTest()
        {
            Lob = new Lob(Constants.ApiKey);

            Address = new Address
            {
                Description = null,
                Name = "Harry Zhang",
                Phone = null,
                Email = null,
                Company = null,
                AddressLine1 = "123 Test Street",
                AddressLine2 = null,
                AddressCity = "Mountain View",
                AddressState = "CA",
                AddressZip = "94041",
                AddressCountry = "US",
            };

            Letter = new Letter
            {
                Description = "Demo Letter",
                To = Address,
                From = Address,
                Color = true,
                File = "<html style='padding-top: 3in; margin: .5in;'>HTML Letter for {{name}}</html>",
                DoubleSided = true,
                AddressPlacement = "top_first_page",
                ReturnEnvelope = false,
                PerforatedPage = null,
                ExtraService = null,
                MailType = "usps_first_class",
                TemplateId = null,
                TrackingNumber = null,
                TrackingEvents = null,
                SendDate = DateTime.Now.AddDays(1),
            };
        }
    }
}
