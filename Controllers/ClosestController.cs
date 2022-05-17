using Microsoft.AspNetCore.Mvc;
using RobotAPI.Clients;
using RobotAPI.Models;
using RobotAPI.Utils;

namespace RobotAPI.Controllers
{
    [Route("api/robots/closest")]
    [ApiController]
    public class ClosestController : ControllerBase
    {
        private readonly ISVTRobotsClient _robotsClient;
        public ClosestController(ISVTRobotsClient robotsClient)
        {
            _robotsClient = robotsClient;
        }

        /* Returns status 204, no content, if there are no robots found in the SVT robots api call (which doesnt happen in this 
         * example, but could happen in a different context). Otherwise return the correct payload assignment */ 
        [HttpPost]
        public async Task<PayloadAssigment?> Post(Payload payload)
        {
            IEnumerable<Robot> data = await _robotsClient.GetRobotData();
            return GetPayloadAssignment(payload, data);
        }

        /* Method returns a payload assignment or null if there are no robots available */
        private static PayloadAssigment? GetPayloadAssignment(Payload payload, IEnumerable<Robot> robots)
        {
            Robot? result = null;
            double resultDistance = Double.PositiveInfinity;

            foreach (Robot robot in robots)
            {
                double distance = DistanceUtils.Distance(payload.X, payload.Y, robot.X, robot.Y);
                if (distance <= 10)
                {
                    if (result == null || result.BatteryLevel < robot.BatteryLevel)
                    {
                        result = robot;
                        resultDistance = distance;
                    }
                }
                else if (distance < resultDistance)
                {
                    result = robot;
                    resultDistance = distance;
                }
            }

            return result == null ? null : new PayloadAssigment()
                {
                    RobotID = result.RobotID,
                    DistanceToGoal = (float)resultDistance,
                    BatteryLevel = result.BatteryLevel
                };
        }
    }
}
