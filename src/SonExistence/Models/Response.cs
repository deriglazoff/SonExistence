using Newtonsoft.Json;

namespace SonExistence.Models
{
    public class Response
    {
        [JsonProperty("uuid")]
        public string Uuid { get; set; }

        [JsonProperty("status")]
        public string Status { get; set; }

        [JsonProperty("error")]
        public object Error { get; set; }

        [JsonProperty("timestamp")]
        public string Timestamp { get; set; }
    }
}