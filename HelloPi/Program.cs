using Newtonsoft.Json;
using Newtonsoft.Json.Serialization;
using System.Collections.Generic;
using System.IO;
using static System.Console;

namespace HelloPi
{
    class Program
    {

        List<string> strList = new List<string>();

        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory());
            WriteLine($"Current directtory: {filePath}");
            string configFile = Path.Combine(filePath, "config.json");
            WriteLine($"Config file: {configFile}");

            string jsonString = File.ReadAllText(configFile);
            WriteLine($"Json: {jsonString}");
            ConfigTest config = new ConfigTest();

            config = JsonConvert.DeserializeObject<ConfigTest>(jsonString);

            int i = 0;
            foreach (string s in config.Welcome)
            {
                i++;
                WriteLine($"{i}. {s}");
            }

        }


    }

    public class ConfigTest
    {
        public List<string> Welcome;
    }


}
