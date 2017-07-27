using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Models
{
    /// <summary>
    /// Verify a domestic address.
    /// The intended recipient, typically a person's or firm's name.
    /// </summary>
    public class USAddress : Data
    {
        /// <summary>
        /// (Optional)
        /// The intended recipient, typically a person's or firm's name.
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// (Required)
        /// </summary>
        [JsonProperty(PropertyName = "primary_line")]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// (Optional)
        /// </summary>
        [JsonProperty(PropertyName = "secondary_line")]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// (Optional)
        /// Only used for addresses in Puerto Rico.
        /// </summary>
        [JsonProperty(PropertyName = "urbanization")]
        public string Urbanization { get; set; }

        /// <summary>
        /// (Optional)
        /// Required if no city and state are passed. Must follow the ZIP format of 12345 or ZIP+4 format of 12345-1234 or 12345 1234.
        /// </summary>
        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// (Optional)
        /// City and state are required if no zip_code is passed.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// (Optional)
        /// City and state are required if no zip_code is passed.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}
