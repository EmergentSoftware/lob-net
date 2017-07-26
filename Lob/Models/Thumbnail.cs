using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Data
{
    public class Thumbnail
    {
        [JsonProperty(PropertyName = "small")]
        public string Small { get; set; }

        [JsonProperty(PropertyName = "medium")]
        public string Medium { get; set; }

        [JsonProperty(PropertyName = "large")]
        public string Large { get; set; }
    }
}
