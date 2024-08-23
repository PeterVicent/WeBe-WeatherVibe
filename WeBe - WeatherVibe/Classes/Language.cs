using System.IO;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class Language
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public string Save { get; set; }
        public string WallpaperEngineExecutable { get; set; }
        [JsonProperty(PropertyName="Language")]
        public string LanguageText { get; set; }
        public string FindExecutable { get; set; }
        public string Home { get; set; }
        public string Options { get; set; }
        public string Settings { get; set; }
        public string Profiles { get; set; }
        public string Start { get; set; }
        public string Stop { get; set; }
        public string ExecutionInterval { get; set; }
        public string Weather { get; set; }
        public string ProfileName { get; set; }
        public string Add { get; set; }
        public string Clear { get; set; }
        public string GetWeather { get; set; }
        public string Unknown { get; set; }
        public string ActualWeather { get; set; }
        public string SimplifiedMode { get; set; }
        public string NightProfile { get; set; }
        public string NightInterval { get; set; }
        public string Until { get; set; }
        public string Successful { get; set; }
        public string StartedMinimized { get; set; }
        public string StartMinimized { get; set; }
        public string AutoStart { get; set; }
        public string StartWithWindows { get; set; }
        public string Exit { get; set; }
        public string RainIntensity { get; set; }
        public string SnowIntensity { get; set; }
        public string Temperature { get; set; }
        public string Powered { get; set; }

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
