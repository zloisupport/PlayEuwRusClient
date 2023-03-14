﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using YamlDotNet.Serialization;
using YamlDotNet.Serialization.NamingConventions;

namespace PlayEuwRusClient
{
   public class Localization
    {
        public string select_action { get; set; } 
        public string action_set_russian_server { get; set; }
        public string action_set_euw_server { get; set; }
        public string action_set_game_path { get; set; }
        public string action_kill_riot_client  { get; set; } 
        public string action_kill_leagueflegends_client  { get; set; }
        public string action_kill_leagueflegends_game  { get; set; } 
        public string action_kill_riot_all { get; set; } 
        public string action_exit { get; set; } 
        public string server { get; set; } 
        public string locale { get; set; } 
        public string parameter_applying { get; set; } 
        public string current_config { get; set; } 
        public string enter_command { get; set; } 
        public string message_success { get; set; } 
        public string warning_please_close_riot_apps { get; set; }


        public  Localization ReadLocalization()
        {
            var localeFile = Reader("", "en.yaml");

            var localizationDeserializer = new DeserializerBuilder()
            .WithNamingConvention(UnderscoredNamingConvention.Instance)
            .Build();

            var localization = localizationDeserializer.Deserialize<Localization>(localeFile);

            return localization;
        }

        private static string Reader(string path, string name)
        {
            StreamReader reader = new StreamReader(path + name);
            string content = reader.ReadToEnd();
            reader.Close();
            return content;
        }
    }
}
