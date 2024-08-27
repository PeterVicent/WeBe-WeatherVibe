using System;
using System.IO;
using System.Drawing;
using System.Net.Http;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class Weather
    {
        [JsonProperty("data")]
        public Data Data { get; set; }

        [JsonIgnore()]
        public static WeatherCodes WeatherCodes { get; set; }

        [JsonProperty("location")]
        public Location Location { get; set; }

        internal static WeatherCodes GetWeatherCodesByLanguage()
        {
            var jsonLanguage = File.ReadAllText($"{Application.StartupPath}\\languages\\{SaveSystem.SaveData.Language.Value}\\{SaveSystem.SaveData.Language.Value}-Weather.json");

            return JsonConvert.DeserializeObject<WeatherCodes>(jsonLanguage);
        }

        internal static Weather GetWeatherByLocation(string location)
        {
            try
            {
                if (location == null || location.Length == 0
                    || SaveSystem.SaveData.ApiToken == null || SaveSystem.SaveData.ApiToken.Length <= 0)
                    return null;

                var url = $"https://api.tomorrow.io/v4/weather/realtime?location={location}&apikey={SaveSystem.SaveData.ApiToken}";
                var response = new HttpClient().SendAsync(new HttpRequestMessage() { Method = HttpMethod.Get, RequestUri = new Uri(url) }).Result;
                response.EnsureSuccessStatusCode();

                var retorno = response.Content.ReadAsStringAsync().Result;
                return JsonConvert.DeserializeObject<Weather>(retorno);
            } catch { return null; }
        }

        internal static bool IsNight()
        {
            var hourNow = DateTime.Now.TimeOfDay;
            return hourNow > TimeSpan.Parse(SaveSystem.SaveData.FirstHourNight) || hourNow < TimeSpan.Parse(SaveSystem.SaveData.SecondHourNight);
        }

        internal static Image GetActualWeatherImage(bool isNight, KeyValuePair<string, string> weatherCode)
        {
            if (isNight)
                foreach (var picture in Program.Pictures)
                    if (picture.Contains($"{weatherCode.Key}1"))
                        return Image.FromFile(picture);

            foreach (var picture in Program.Pictures)
                if (picture.Contains($"{weatherCode.Key}0"))
                    return Image.FromFile(picture);

            return null;
        }
    }

    public class Data
    {
        [JsonProperty("time")]
        public DateTime Time { get; set; }

        [JsonProperty("values")]
        public Values Values { get; set; }
    }

    public class Location
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Values
    {
        [JsonProperty("rainIntensity")]
        public float RainIntensity { get; set; }

        [JsonProperty("snowIntensity")]
        public float SnowIntensity { get; set; }

        [JsonProperty("temperature")]
        public float Temperature { get; set; }

        [JsonProperty("weatherCode")]
        public int WeatherCode { get; set; }
    }
}
