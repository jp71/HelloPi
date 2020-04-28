using System;
using System.Collections.Generic;
using System.IO;
using static System.Console;
using Newtonsoft.Json;

namespace HelloPi
{
    class Program
    {
        struct ConfigTest
        {
            public List<string> text;
        }

        List<string> strList = new List<string>();
        
        static void Main(string[] args)
        {
            WriteLine("Hello World!");
            string filePath = Path.GetFullPath(Directory.GetCurrentDirectory());
            WriteLine($"Current directtory: {filePath}");
            string configFile = Path.Combine(filePath, "config.json");
            WriteLine($"Config file: {configFile}");

            string json = File.ReadAllText(configFile);
            WriteLine($"Json: {json}");
            ConfigTest config = JsonConvert.DeserializeObject<ConfigTest>(json);

            int i = 0;
            foreach(string s in config.text)
            {
                i++;
                WriteLine("{i}. {s}");
            }

        }


    }
        
}
