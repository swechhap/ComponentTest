using System.IO;
using Newtonsoft.Json.Linq;
namespace UCXComponentTest.Utils
{
    public static class TestConfigReader
    {
        private static JObject _config;
        static TestConfigReader()
        {
            var env = System.Environment.GetEnvironmentVariable("TEST_ENV") ?? "in1";
            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "Environments", $"{env}.json");
            _config = JObject.Parse(File.ReadAllText(configPath));
        }

        public static string GetAppUrl()
        {
            return _config["AppUrl"].ToString();
        }
    }
}
