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

        public LobTest()
        {
            Lob = new Lob(Constants.ApiKey);
        }
    }
}
