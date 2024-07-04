using Newtonsoft.Json.Linq;
using System;
using System.IO;

namespace AutomationProject
{
    public static class ConfigurationHelper
    {
        private static readonly Lazy<JObject> _config = new Lazy<JObject>(() =>
        {
            string configFile = "config.json";
            string configPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, configFile);

            if (!File.Exists(configPath))
            {
                throw new FileNotFoundException($"The configuration file '{configFile}' was not found at '{configPath}'.");
            }

            string json = File.ReadAllText(configPath);
            return JObject.Parse(json);
        });

        public static string GetConfigValue(string section, string key)
        {
            if (_config.Value.TryGetValue(section, StringComparison.OrdinalIgnoreCase, out var sectionObject))
            {
                if (sectionObject is JObject sectionJson)
                {
                    if (sectionJson.TryGetValue(key, StringComparison.OrdinalIgnoreCase, out var value))
                    {
                        return value?.ToString(); // Ensure value is not null before calling ToString()
                    }
                }
            }
            return null; // Return null if key or section is not found
        }
    }
}
