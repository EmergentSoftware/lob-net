using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System;

namespace Lob.Data
{
    public class Letter : Data
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

        [JsonProperty(PropertyName = "color")]
        public bool Color { get; set; }

        [JsonProperty(PropertyName = "file")]
        public string File { get; set; }

        [JsonProperty(PropertyName = "double_sided")]
        public bool DoubleSided { get; set; }

        [JsonProperty(PropertyName = "address_placement")]
        public string AddressPlacement { get; set; }

        [JsonProperty(PropertyName = "return_envelope")]
        public bool ReturnEnvelope { get; set; }

        [JsonProperty(PropertyName = "perforated_page")]
        public object PerforatedPage { get; set; }

        [JsonProperty(PropertyName = "extra_service")]
        public object ExtraService { get; set; }

        [JsonProperty(PropertyName = "mail_type")]
        public string MailType { get; set; }

        [JsonProperty(PropertyName = "url")]
        public string Url { get; set; }

        [JsonProperty(PropertyName = "template_id")]
        public object TemplateId { get; set; }

        [JsonProperty(PropertyName = "carrier")]
        public string Carrier { get; set; }

        [JsonProperty(PropertyName = "tracking_number")]
        public object TrackingNumber { get; set; }

        [JsonProperty(PropertyName = "tracking_events")]
        public object[] TrackingEvents { get; set; }

        [JsonProperty(PropertyName = "thumbnails")]
        public Thumbnail[] Thumbnails { get; set; }

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