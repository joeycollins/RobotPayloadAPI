using RobotAPI.Models;

namespace RobotAPI.Clients
{
    public interface ISVTRobotsClient
    {
        public Task<IEnumerable<Robot>> GetRobotData();
    }
}
