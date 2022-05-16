using Newtonsoft.Json;

namespace RobotAPI.Models
{
    public class PayloadAssigment
    {
        [JsonProperty("robotID")]
        public int RobotID { get; set; }
        
        [JsonProperty("distanceToGoal")]
        public float DistanceToGoal { get; set; }
        
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }
    }
}
