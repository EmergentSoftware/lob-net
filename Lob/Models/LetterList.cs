using Lob.Data;
using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lob.Models
{
    public class LetterList
    {
        [JsonProperty(PropertyName = "data")]
        public List<Letter> Letters { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }
    }
}
