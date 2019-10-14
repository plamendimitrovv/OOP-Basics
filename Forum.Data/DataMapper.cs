using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace Forum.Data
{
    class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG_PATH = "config.ini";

        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";
        private static readonly Dictionary<string, string> config;

        public DataMapper()
        {
            Directory.CreateDirectory(DATA_PATH);
            config = LoadConfig(DATA_PATH + CONFIG_PATH); 
        }

        private static void EnsureConfigFile(string configPath)
        {
            if (!File.Exists(configPath))
            {
                File.WriteAllText(configPath, DEFAULT_CONFIG);
            }
        }

        private static void EnsureFile(string path)
        {
            if (!File.Exists(path))
            {
                File.Create(path).Close();
            }
        }

        private static string[] ReadLines(string path)
        {
            EnsureFile(path);
            var lines = File.ReadAllLines(path);
            return lines; 
        }


        private static Dictionary<string, string> LoadConfig(string configPath)
        {
            EnsureConfigFile(configPath); 
            var lines = ReadLines(configPath);

            var result = lines.Select(l => l.Split('=')).ToDictionary(t => t[0], t => DATA_PATH + t[1]);

            return result;
        }
    }

    public static List<Category> LoadCategories()
    {
        var lines = ReadLines(config)
    }
}
