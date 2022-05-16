
namespace RobotAPI
{
    public interface ISVTRobotsClient {
        public Task<IEnumerable<Robot>> GetRobotData();
    }
}
