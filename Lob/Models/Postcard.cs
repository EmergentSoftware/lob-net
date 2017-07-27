using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace Lob.Models
{
    public class Postcard : Data
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "description")]
        public string Description { get; set; }

        [JsonProperty(PropertyName = "metadata")]
        public object Metadata { get; set; }

        [JsonProperty(PropertyName = "to")]
        public Address To { get; set; }

        [JsonProperty(PropertyName = "from")]
        public Address From { get; set; }

        [JsonProperty(PropertyName = "front")]
        public string Front { get; set; }

        [JsonProperty(PropertyName = "back")]
        public string Back { get; set; }

        [JsonProperty(PropertyName = "merge_variables")]
        public Dictionary<string, string> MergeVariables { get; set; }

        [JsonProperty(PropertyName = "message")]
        public string Message { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "front_template_id")]
        public object FrontTemplateId { get; set; }

        [JsonProperty(PropertyName = "back_template_id")]
        public object BackTemplateId { get; set; }

        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        [JsonProperty(PropertyName = "tracking_events")]
        public object[] TrackingEvents { get; set; }

        [JsonProperty(PropertyName = "thumbnails")]
        public Thumbnail[] Thumbnails { get; set; }

        [JsonProperty(PropertyName = "size")]
        public string Size { get; set; }

        [JsonProperty(PropertyName = "mail_type")]
        public string MailType { get; set; }

        [JsonProperty(PropertyName = "expected_delivery_date")]
        public string ExpectedDeliveryDate { get; set; }

        [JsonProperty(PropertyName = "date_created")]
        public DateTime? DateCreated { get; set; }

        [JsonProperty(PropertyName = "date_modified")]
        public DateTime? DateModified { get; set; }

        [JsonProperty(PropertyName = "send_date")]
        public DateTime? SendDate { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }
    }
}
