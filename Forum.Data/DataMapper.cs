using System;
using System.Collections.Generic;
using System.Text;

namespace Forum.Data
{
    class DataMapper
    {
        private const string DATA_PATH = "../data/";
        private const string CONFIG = "config.ini";

        private const string DEFAULT_CONFIG = "users=users.csv\r\ncategories=categories.csv\r\nposts=posts.csv\r\nreplies=replies.csv";
        private static readonly Dictionary<string, string> config; 
    }
}
