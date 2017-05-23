using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Requests
{
    public class PostRequest : Request
    {
        public string Data { get; set; }

        public PostRequest() : base()
        {
            Method = "POST";
        }
    }
}
