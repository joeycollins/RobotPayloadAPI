using Newtonsoft.Json;

namespace RobotAPI.Models
{
    public class PayloadAssigment
    {
        [JsonProperty("robotId")]
        public int RobotId { get; set; }
        
        [JsonProperty("distanceToGoal")]
        public float DistanceToGoal { get; set; }
        
        [JsonProperty("batteryLevel")]
        public int BatteryLevel { get; set; }
    }
}
