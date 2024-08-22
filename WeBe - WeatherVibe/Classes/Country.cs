using System.IO;
using System.Linq;
using System.Windows.Forms;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace WeBe___WeatherVibe.Classes
{
    public class Country
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("region")]
        public string Region { get; set; }

        [JsonProperty("translations")]
        public Translations Translations { get; set; }

        [JsonProperty("states")]
        public List<State> States { get; set; }

        [JsonIgnore()]
        private static readonly string FilePath = $"{Application.StartupPath}\\database.json";

        [JsonIgnore()]
        public static List<Country> DataBase { get; set; }

        internal static void InstantiateDataBase()
            => DataBase = JsonConvert.DeserializeObject<List<Country>>(File.ReadAllText(FilePath));

        internal static List<State> GetStatesByCountry(string countryName)
            => DataBase.FindAll(country => country.Name == countryName).FirstOrDefault().States;

        internal static List<City> GetCitiesByState(string countryName, string stateName)
            => DataBase.FindAll(country => country.Name == countryName).FirstOrDefault()
            .States.FindAll(state => state.Name == stateName).FirstOrDefault().Cities;
    }

    public class State
    {
        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("state_code")]
        public string State_code { get; set; }

        [JsonProperty("cities")]
        public List<City> Cities { get; set; }
    }

    public class City
    {
        [JsonProperty("name")]
        public string Name { get; set; }
    }

    public class Translations
    {
        [JsonProperty("kr")]
        public string kr { get; set; }

        [JsonProperty("pt-BR")]
        public string ptBR { get; set; }

        [JsonProperty("pt")]
        public string pt { get; set; }

        [JsonProperty("nl")]
        public string nl { get; set; }

        [JsonProperty("hr")]
        public string hr { get; set; }

        [JsonProperty("fa")]
        public string fa { get; set; }

        [JsonProperty("de")]
        public string de { get; set; }

        [JsonProperty("es")]
        public string es { get; set; }

        [JsonProperty("fr")]
        public string fr { get; set; }

        [JsonProperty("ja")]
        public string ja { get; set; }

        [JsonProperty("it")]
        public string it { get; set; }

        [JsonProperty("cn")]
        public string cn { get; set; }

        [JsonProperty("tr")]
        public string tr { get; set; }
    }
}
