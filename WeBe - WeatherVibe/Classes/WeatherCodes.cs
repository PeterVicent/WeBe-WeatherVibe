using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class WeatherCodes
    {
        [JsonProperty("weatherCode")]
        public Dictionary<string, string> WeatherCode { get; set; }

        [JsonProperty("weatherCodeFullDay")]
        public Dictionary<string, string> WeatherCodeFullDay { get; set; }

        [JsonProperty("weatherCodeDay")]
        public Dictionary<string, string> WeatherCodeDay { get; set; }

        [JsonProperty("weatherCodeNight")]
        public Dictionary<string, string> WeatherCodeNight { get; set; }

        [JsonProperty("weatherCodeSimplified")]
        public Dictionary<string, string> WeatherCodeSimplified { get; set; }

        [JsonProperty("detailedToSimplified")]
        public Dictionary<string, string> DetailedToSimplified { get; set; }
    }
}
