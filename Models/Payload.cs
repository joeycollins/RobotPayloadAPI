using Newtonsoft.Json;

namespace RobotAPI.Models
{
    public class Payload
    {
        [JsonProperty("loadID")]
        public int LoadID { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
