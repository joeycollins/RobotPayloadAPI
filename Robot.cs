using Newtonsoft.Json;

namespace RobotAPI
{
    public class Robot
    {
        [JsonProperty("robotID")]
        public int RobotID {get; set;}
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }
        [JsonProperty("x")]
        public int X { get; set; }
        [JsonProperty("y")]
        public int Y { get; set; }
    }
}
