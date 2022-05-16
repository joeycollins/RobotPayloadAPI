using RobotAPI.Models;

namespace RobotAPI.Utils
{
    public class DistanceUtils
    {
        public static double Distance(int x1, int y1, int x2, int y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }

        public static PayloadAssigment GetPayloadAssignment(Payload payload, IEnumerable<Robot> robots)
        {
            Robot result = null;
            double distance = Double.PositiveInfinity;

            foreach (Robot robot in robots)
            {
                double d = Distance(payload.X, payload.Y, robot.X, robot.Y);
                if (d <= 10)
                {
                    if (result == null || result.BatteryLevel < robot.BatteryLevel)
                    {
                        result = robot;
                        distance = d;
                    }
                }
                else if (Distance(payload.X, payload.Y, robot.X, robot.Y) < distance){
                    result = robot;
                    distance = d;
                }
            }

            return new PayloadAssigment()
            {
                RobotID = result.RobotID,
                DistanceToGoal = (float)distance,
                BatteryLevel = result.BatteryLevel
            };
        }
    }
}
