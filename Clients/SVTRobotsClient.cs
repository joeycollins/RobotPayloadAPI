using Newtonsoft.Json;
using RobotAPI.Models;
using System.Net.Http.Headers;
using System.Text.Json;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace RobotAPI.Clients
{
    public class SVTRobotsClient : ISVTRobotsClient
    {
        HttpClient client { get; }
        const string basePath = "https://60c8ed887dafc90017ffbd56.mockapi.io/";
        const string apiPath = "robots";
        public SVTRobotsClient()
        {
            client = new HttpClient();
            client.BaseAddress = new Uri(basePath);
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(
                new MediaTypeWithQualityHeaderValue("application/json"));

        }


        public async Task<IEnumerable<Robot>> GetRobotData()
        {
            IEnumerable<Robot> result = Enumerable.Empty<Robot>();
            HttpResponseMessage response = await client.GetAsync(apiPath);
            if (response.IsSuccessStatusCode)
            {
                string resultString = await response.Content.ReadAsStringAsync();
                result = JsonConvert.DeserializeObject<IEnumerable<Robot>>(resultString);
            }
            return result;
        }
    }
}
