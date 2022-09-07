using Newtonsoft.Json;

namespace SonExistence.Dto
{
    public class DocumentDto
    {
        [JsonProperty("external_id")]
        public string ExternalId { get; set; }

        [JsonProperty("email")]
        public string Email { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("price")]
        public double Price { get; set; }

        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        [JsonProperty("sum")]
        public double Sum { get; set; }

        [JsonProperty("measurement_unit")]
        public string MeasurementUnit { get; set; }

        [JsonProperty("total")]
        public double Total { get; set; }

    }
}