using Newtonsoft.Json;

namespace RobotAPI.Models
{
    public class Payload
    {
        [JsonProperty("loadId")]
        public int LoadId { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
