using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Tests
{
    public static class Constants
    {
        public static readonly string ApiKey = ConfigurationManager.AppSettings["ApiKey"];
    }
}
