using System.IO;
using System.Collections.Generic;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class Profile
    {
        [JsonProperty(PropertyName = "WeatherCode")]
        public string WeatherCode { get; set; }

        [JsonProperty(PropertyName = "ProfilesDay")]
        public List<string> ProfilesDay { get; set; }

        [JsonProperty(PropertyName = "ProfilesNight")]
        public List<string> ProfilesNight { get; set; }

        [JsonIgnore()]
        public string ProfilePath;

        public Profile() { }

        public Profile(string weatherCode)
        {
            WeatherCode = weatherCode;
            ProfilePath = $"{Application.StartupPath}\\profiles\\{weatherCode}-profiles.json";
            CheckIfProfilesExists();
        }

        private void CheckIfProfilesExists()
        {
            if (!File.Exists(ProfilePath))
            {
                ProfilesDay = new List<string>();
                ProfilesNight = new List<string>();
                File.WriteAllText(ProfilePath, JsonConvert.SerializeObject(this));
            }
            else
            {
                var profiles = JsonConvert.DeserializeObject<Profile>(File.ReadAllText(ProfilePath));
                ProfilesDay = profiles.ProfilesDay;
                ProfilesNight = profiles.ProfilesNight;
            }
        }

        private void Save()
            => File.WriteAllText(ProfilePath, JsonConvert.SerializeObject(this));

        public void AddProfile(string profileName, bool isNight)
        {
            if (isNight)
                ProfilesNight.Add(profileName);
            else
                ProfilesDay.Add(profileName);

            Save();
        }

        public void RemoveProfile(string profileName, bool isNight)
        {
            if (isNight)
                ProfilesNight.Remove(profileName);
            else
                ProfilesDay.Remove(profileName);
            
            Save();
        }

        public void ClearProfiles()
        {
            ProfilesNight.Clear();
            ProfilesDay.Clear();
            Save();
        }
    }
}
