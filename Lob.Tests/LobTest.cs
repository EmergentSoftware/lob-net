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
    public class LobTest
    {
        public Lob Lob { get; set; }
        public Letter Letter { get; set; }
        public Address Address { get; set; }
        public Thumbnail Thumbnail { get; set; }

        public LobTest()
        {
            Lob = new Lob(Constants.ApiKey);

            Address = new Address
            {
                Id = "adr_8bad937e10c42730",
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
                AddressCountry = "United Stats",
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                Deleted = true,
                Object = "address"
            };

            Thumbnail = new Thumbnail
            {
                Large = "https://s3-us-west-2.amazonaws.com/assets.lob.com/ltr_4868c3b754655f90_thumb_small_1.png?AWSAccessKeyId=AKIAJVT3IPSNH662QU6A&Expires=1449430428&Signature=j%2FTzUuHJkrlbAJZGNpCm3xfxgmE%3D",
                Medium = "https://s3-us-west-2.amazonaws.com/assets.lob.com/ltr_4868c3b754655f90_thumb_medium_1.png?AWSAccessKeyId=AKIAJVT3IPSNH662QU6A&Expires=1449430428&Signature=j%2FTzUuHJkrlbAJZGNpCm3xfxgmE%3D",
                Small = "https://s3-us-west-2.amazonaws.com/assets.lob.com/ltr_4868c3b754655f90_thumb_large_1.png?AWSAccessKeyId=AKIAJVT3IPSNH662QU6A&Expires=1449430428&Signature=j%2FTzUuHJkrlbAJZGNpCm3xfxgmE%3D"
            };

            Letter = new Letter
            {
                Id = "ltr_4868c3b754655f90",
                Description = "Demo Letter",
                To = Address,
                From = Address,
                Color = true,
                DoubleSided = true,
                AddressPlacement = "top_first_page",
                ReturnEnvelope = false,
                PerforatedPage = null,
                ExtraService = null,
                MailType = "usps_first_class",
                Url = "https://s3-us-west-2.amazonaws.com/assets.lob.com/ltr_4868c3b754655f90.pdf?AWSAccessKeyId=AKIAJVT3IPSNH662QU6A&Expires=1449430428&Signature=j%2FTzUuHJkrlbAJZGNpCm3xfxgmE%3D",
                TemplateId = null,
                Carrier = "USPS",
                TrackingNumber = null,
                TrackingEvents = null,
                Thumbnails = new Thumbnail[] { Thumbnail },
                ExpectedDeliveryDate = DateTime.Now.ToString(),
                DateCreated = DateTime.Now,
                DateModified = DateTime.Now,
                SendDate = DateTime.Now,
                Object = "letter"
            };
        }
    }
}
