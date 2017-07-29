using Newtonsoft.Json;
using System.Collections.Generic;

namespace Lob.Models
{
    public class ModelList<T>
    {
        [JsonProperty(PropertyName = "data")]
        public List<T> Models { get; set; }

        [JsonProperty(PropertyName = "count")]
        public int Count { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }
    }
}
