using Newtonsoft.Json;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace WeBe___WeatherVibe.Classes
{
    public static class SaveSystem
    {
        public static readonly string SavePath = $"{Application.StartupPath}\\config.json";
        public static SaveData SaveData;

        internal static SaveData GetDefaultSaveData()
            => SaveData = new SaveData()
            {
                Country = string.Empty,
                State = string.Empty,
                City = string.Empty,
                Language = new KeyValuePair<string, string>("English", "enUS"),
                Interval = 600000,
                WallpaperEngineExecutablePath = string.Empty,
                ApiToken = string.Empty,
                FirstHourNight = "18:30",
                SecondHourNight = "06:00",
                SimplifiedMode = true,
                StartMinimized = false
            };

        internal static void CheckIfSaveExists()
        {
            if (File.Exists(SavePath))
                SaveData = JsonConvert.DeserializeObject<SaveData>(File.ReadAllText(SavePath));
            else
            {
                SaveData = GetDefaultSaveData();
                Save();
            }
        }

        public static void Save()
        {
            var saveDataInJson = JsonConvert.SerializeObject(SaveData);
            File.WriteAllText(SavePath, saveDataInJson.Replace("{", "{\n").Replace("}", "\n}").Replace(",", ",\n"));
        }
    }

    public class SaveData
    {
        public string Country { get; set; }
        public string State { get; set; }
        public string City { get; set; }
        public KeyValuePair<string, string> Language { get; set; }
        public int Interval { get; set; }
        public string WallpaperEngineExecutablePath { get; set; }
        public string ApiToken { get; set; }
        public string FirstHourNight { get; set; }
        public string SecondHourNight { get; set; }
        public bool SimplifiedMode { get; set; }
        public bool StartMinimized { get; set; }
        public bool AutoStart { get; set; }
        public bool StartWithWindows { get; set; }
    }
}
