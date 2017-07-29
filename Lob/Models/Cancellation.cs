using Newtonsoft.Json;

namespace Lob.Models
{
    public class Cancellation
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "deleted")]
        public bool? Deleted { get; set; }
    }
}
