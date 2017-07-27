using Newtonsoft.Json;

namespace Lob.Models
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
