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

//using System;
//using System.IO;
//using Newtonsoft.Json;
//using Newtonsoft.Json.Linq;
//namespace UCXComponentTest.Utils
//{
//    public static class TestConfigReader
//    {
//        private static readonly dynamic config;
//        // Set your default environment here or get it from environment variables
//        private static readonly string env = Environment.GetEnvironmentVariable("TEST_ENV") ?? "qa";

//        static TestConfigReader()
//        {
//            // Get the current base directory where binaries are located (e.g., bin/Debug/net8.0)
//            string basePath = AppDomain.CurrentDomain.BaseDirectory;

//            // Build the full path to the environment config file
//            var configPath = Path.Combine(Directory.GetCurrentDirectory(), "Environments", $"{env}.json");

//            if (!File.Exists(configPath))
//            {
//                throw new FileNotFoundException($"Environment configuration file not found: {configPath}");
//            }

//            string json = File.ReadAllText(configPath);
//            config = JsonSerializer.Deserialize<dynamic>(json);
//        }

//        public static string GetAppUrl()
//        {
//            return config["appUrl"];
//        }

//        public static string GetApiBaseUrl()
//        {
//            return config["apiBaseUrl"];
//        }

//        // Add more accessors as needed
//    }
//}