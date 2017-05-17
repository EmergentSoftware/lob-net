using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Data
{
    /// <summary>
    /// Verify a domestic address.
    /// The intended recipient, typically a person's or firm's name.
    /// 
    /// </summary>
    public class Address
    {
        /// <summary>
        /// optional
        /// The intended recipient, typically a person's or firm's name.
        /// </summary>
        [JsonProperty(PropertyName = "recipient")]
        public string Recipient { get; set; }

        /// <summary>
        /// required
        /// </summary>
        [JsonProperty(PropertyName = "primary_line")]
        public string PrimaryLine { get; set; }

        /// <summary>
        /// optional
        /// </summary>
        [JsonProperty(PropertyName = "secondary_line")]
        public string SecondaryLine { get; set; }

        /// <summary>
        /// optional
        /// Only used for addresses in Puerto Rico.
        /// </summary>
        [JsonProperty(PropertyName = "urbanization")]
        public string Urbanization { get; set; }

        /// <summary>
        /// optional
        /// Required if no city and state are passed. Must follow the ZIP format of 12345 or ZIP+4 format of 12345-1234 or 12345 1234.
        /// </summary>
        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }

        /// <summary>
        /// optional
        /// City and state are required if no zip_code is passed.
        /// </summary>
        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        /// <summary>
        /// optional
        /// City and state are required if no zip_code is passed.
        /// </summary>
        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }
    }
}
