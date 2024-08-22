using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class Language
    {
        [JsonProperty("Country")]
        public string Country { get; set; }

        [JsonProperty("State")]
        public string State { get; set; }

        [JsonProperty("City")]
        public string City { get; set; }

        [JsonProperty("Save")]
        public string Save { get; set; }

        [JsonProperty("WallpaperEngineExecutable")]
        public string WallpaperEngineExecutable { get; set; }

        [JsonProperty("Language")]
        public string LanguageText { get; set; }

        [JsonProperty("FindExecutable")]
        public string FindExecutable { get; set; }

        [JsonProperty("Home")]
        public string Home { get; set; }

        [JsonProperty("Options")]
        public string Options { get; set; }

        [JsonProperty("Settings")]
        public string Settings { get; set; }

        [JsonProperty("Profiles")]
        public string Profiles { get; set; }

        [JsonProperty("Start")]
        public string Start { get; set; }

        [JsonProperty("Stop")]
        public string Stop { get; set; }

        [JsonProperty("ExecutionInterval")]
        public string ExecutionInterval { get; set; }

        [JsonProperty("Weather")]
        public string Weather { get; set; }

        [JsonProperty("ProfileName")]
        public string ProfileName { get; set; }

        [JsonProperty("Add")]
        public string Add { get; set; }

        [JsonProperty("Clear")]
        public string Clear { get; set; }

        [JsonProperty("GetWeather")]
        public string GetWeather { get; set; }

        [JsonProperty("Unknown")]
        public string Unknown { get; set; }

        [JsonProperty("ActualWeather")]
        public string ActualWeather { get; set; }

        [JsonProperty("SimplifiedMode")]
        public string SimplifiedMode { get; set; }

        [JsonIgnore()]
        public static Dictionary<string, string> SupportedLanguages { get; set; }

        [JsonIgnore()]
        private static readonly string FilePath = $"{Application.StartupPath}\\languages";

        [JsonIgnore()]
        public static Language DataBase { get; set; }

        internal static void InstantiateDataBase()
        {
            SupportedLanguages = JsonConvert.DeserializeObject<Dictionary<string, string>>(File.ReadAllText($"{FilePath}\\languages.json"));
            DataBase = JsonConvert.DeserializeObject<Language>(File.ReadAllText($"{FilePath}\\{SaveSystem.SaveData.Language.Value}\\{SaveSystem.SaveData.Language.Value}.json"));
        }
    }
}
