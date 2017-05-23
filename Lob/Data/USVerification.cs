using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lob.Data
{
    public class USVerification
    {
        [JsonProperty(PropertyName = "id")]
        public string Id { get; set; }

        [JsonProperty(PropertyName = "recipient")]
        public string Recipient { get; set; }

        [JsonProperty(PropertyName = "primary_line")]
        public string PrimaryLine { get; set; }

        [JsonProperty(PropertyName = "secondary_line")]
        public string SecondaryLine { get; set; }

        [JsonProperty(PropertyName = "urbanization")]
        public string Urbanization { get; set; }

        [JsonProperty(PropertyName = "last_line")]
        public string LastLine { get; set; }

        [JsonProperty(PropertyName = "deliverability")]
        public string Deliverability { get; set; }

        [JsonProperty(PropertyName = "components")]
        public Components Components { get; set; }

        [JsonProperty(PropertyName = "deliverability_analysis")]
        public DeliverabilityAnalysis DeliverabilityAnalysis { get; set; }

        [JsonProperty(PropertyName = "object")]
        public string Object { get; set; }
    }

    public class Components
    {
        [JsonProperty(PropertyName = "primary_number")]
        public string PrimaryNumber { get; set; }

        [JsonProperty(PropertyName = "street_predirection")]
        public string StreetPredirection { get; set; }

        [JsonProperty(PropertyName = "street_name")]
        public string StreetName { get; set; }

        [JsonProperty(PropertyName = "street_suffix")]
        public string StreetSuffix { get; set; }

        [JsonProperty(PropertyName = "street_postdirection")]
        public string StreetPostdirection { get; set; }

        [JsonProperty(PropertyName = "secondary_designator")]
        public string SecondaryDesignator { get; set; }

        [JsonProperty(PropertyName = "secondary_number")]
        public string SecondaryNumber { get; set; }

        [JsonProperty(PropertyName = "pmb_designator")]
        public string PmbDesignator { get; set; }

        [JsonProperty(PropertyName = "pmb_number")]
        public string PmbNumber { get; set; }

        [JsonProperty(PropertyName = "extra_secondary_information")]
        public string ExtraSecondaryInformation { get; set; }

        [JsonProperty(PropertyName = "city")]
        public string City { get; set; }

        [JsonProperty(PropertyName = "state")]
        public string State { get; set; }

        [JsonProperty(PropertyName = "zip_code")]
        public string ZipCode { get; set; }

        [JsonProperty(PropertyName = "zip_code_plus_4")]
        public string ZipCodePlus4 { get; set; }

        [JsonProperty(PropertyName = "zip_code_type")]
        public string ZipCodeType { get; set; }

        [JsonProperty(PropertyName = "delivery_point_barcode")]
        public string DeliveryPointBarcode { get; set; }

        [JsonProperty(PropertyName = "record_type")]
        public string RecordType { get; set; }

        [JsonProperty(PropertyName = "default_building_address")]
        public bool DefaultBuildingAddress { get; set; }

        [JsonProperty(PropertyName = "county")]
        public string County { get; set; }

        [JsonProperty(PropertyName = "county_fips")]
        public string CountyFips { get; set; }

        [JsonProperty(PropertyName = "carrier_route")]
        public string CarrierRoute { get; set; }

        [JsonProperty(PropertyName = "carrier_route_type")]
        public string CarrierRouteType { get; set; }
    }

    public class DeliverabilityAnalysis
    {
        [JsonProperty(PropertyName = "dpv_confirmation")]
        public string DpvConfirmation { get; set; }

        [JsonProperty(PropertyName = "dpv_cmra")]
        public string DpvCmra { get; set; }

        [JsonProperty(PropertyName = "dpv_vacant")]
        public string DpvVacant { get; set; }

        [JsonProperty(PropertyName = "dpv_footnotes")]
        public string[] DpvFootnotes { get; set; }

        [JsonProperty(PropertyName = "ews_match")]
        public bool EwsMatch { get; set; }

        [JsonProperty(PropertyName = "lacs_indicator")]
        public string LacsIndicator { get; set; }

        [JsonProperty(PropertyName = "lacs_return_code")]
        public string LacsReturnCode { get; set; }

        [JsonProperty(PropertyName = "suite_return_code")]
        public string SuiteReturnCode { get; set; }
    }
}
