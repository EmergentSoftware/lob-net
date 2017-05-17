using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Requests
{
    public class GetRequest
    {
        public List<KeyValuePair<string, string>> Args { get; set; }

        public GetRequest() : base() { }
    }
}
