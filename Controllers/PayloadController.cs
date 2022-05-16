using Microsoft.AspNetCore.Mvc;
using RobotAPI.Clients;
using RobotAPI.Models;
using RobotAPI.Utils;

namespace RobotAPI.Controllers
{
    [Route("api/robots/closest")]
    [ApiController]
    public class PayloadController : ControllerBase
    {
        private readonly ISVTRobotsClient _robotsClient;
        public PayloadController(ISVTRobotsClient robotsClient)
        {
            _robotsClient = robotsClient;
        }

        [HttpPost]
        public async Task<PayloadAssigment> Post(Payload payload)
        {
            IEnumerable<Robot> data = await _robotsClient.GetRobotData();
            return DistanceUtils.GetPayloadAssignment(payload, data);
        }
    }
}
