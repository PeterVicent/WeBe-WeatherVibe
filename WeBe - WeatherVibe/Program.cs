using System;
using System.Globalization;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WeBe___WeatherVibe.Classes;

namespace WeBe___WeatherVibe
{
    internal static class Program
    {
        public const string DefaultWeatherCode = "0";

        public static WeBe WeBe;
        public static Thread Thread;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            WeBe = new WeBe();
            LoadVariables();
            Application.Run(WeBe);
        }

        public static void LoadVariables()
        {
            SaveSystem.CheckIfSaveExists();
            Language.InstantiateDataBase();

            Weather.WeatherCodes = Weather.GetWeatherCodesByLanguage();
            WallpaperEngine.ExecutablePath = SaveSystem.SaveData.WallpaperEngineExecutablePath;

            WeBe.chkBox_SimplifiedMode.Checked = SaveSystem.SaveData.SimplifiedMode;
            WeBe.txtBx_WallpaperEngineExecutable.Text = WallpaperEngine.ExecutablePath;
            WeBe.txtBx_ApiToken.Text = SaveSystem.SaveData.ApiToken;
            WeBe.txtBx_Interval.Text = (SaveSystem.SaveData.Interval / 60000).ToString();
            WeBe.txtBox_FirstHourNight.Text = SaveSystem.SaveData.FirstHourNight;
            WeBe.txtBox_SecondHourNight.Text = SaveSystem.SaveData.SecondHourNight;

            SetLanguageInButtonsAndLabels();
            LoadComboBoxsAndSetLanguage();
        }

        internal static void SetLanguageInButtonsAndLabels()
        {
            WeBe.label_ActualWeatherHeader.Text = Language.DataBase.ActualWeather;
            WeBe.label_ActualWeather.Text = Language.DataBase.Unknown;

            WeBe.btn_GetWeather.Text = Language.DataBase.GetWeather;
            WeBe.btn_Save.Text = Language.DataBase.Save;
            WeBe.btn_FindExecutable.Text = Language.DataBase.FindExecutable;
            WeBe.btn_Start.Text = Language.DataBase.Start;
            WeBe.context_Start.Text = Language.DataBase.Start;
            WeBe.btn_Stop.Text = Language.DataBase.Stop;
            WeBe.context_Stop.Text = Language.DataBase.Stop;

            WeBe.tabControl_Principal.TabPages[0].Text = Language.DataBase.Home;
            WeBe.tabControl_Principal.TabPages[1].Text = Language.DataBase.Options;
            WeBe.tabControl_Configuration.TabPages[0].Text = Language.DataBase.Profiles;
            WeBe.tabControl_Configuration.TabPages[1].Text = Language.DataBase.Settings;
            
            WeBe.label_WallpaperEngineExecutable.Text = Language.DataBase.WallpaperEngineExecutable;
            WeBe.label_Interval.Text = Language.DataBase.ExecutionInterval;
            WeBe.label_NightInterval.Text = Language.DataBase.NightInterval;
            WeBe.label_Until.Text = Language.DataBase.Until;

            WeBe.label_Weather.Text = Language.DataBase.Weather;
            WeBe.chkBox_SimplifiedMode.Text = Language.DataBase.SimplifiedMode;
            WeBe.chkBox_IsNight.Text = Language.DataBase.NightProfile;
            WeBe.label_ProfileName.Text = Language.DataBase.ProfileName;
            WeBe.btn_Add.Text = Language.DataBase.Add;
            WeBe.btn_Clear.Text = Language.DataBase.Clear;
        }

        internal static void LoadComboBoxsAndSetLanguage()
        {
            WeBe.cbx_Country.Items.Clear();
            WeBe.cbx_State.Items.Clear();
            WeBe.cbx_City.Items.Clear();
            WeBe.cbx_Language.Items.Clear();
            WeBe.cbx_Weathers.Items.Clear();

            WeBe.label_Country.Text = Language.DataBase.Country;
            WeBe.cbx_Country.Items.Add(SaveSystem.SaveData.Country);
            WeBe.cbx_Country.SelectedIndex = 0;

            WeBe.label_State.Text = Language.DataBase.State;
            WeBe.cbx_State.Items.Add(SaveSystem.SaveData.State);
            WeBe.cbx_State.SelectedIndex = 0;
            
            WeBe.label_City.Text = Language.DataBase.City;
            WeBe.cbx_City.Items.Add(SaveSystem.SaveData.City);
            WeBe.cbx_City.SelectedIndex = 0;

            WeBe.label_Language.Text = Language.DataBase.LanguageText;
            WeBe.cbx_Language.Items.Add(SaveSystem.SaveData.Language.Key);
            WeBe.cbx_Language.SelectedIndex = 0;

            var weatherCodes = SaveSystem.SaveData.SimplifiedMode
                ? Weather.WeatherCodes.WeatherCodeSimplified.Values.ToArray()
                : Weather.WeatherCodes.WeatherCodeFullDay.Values.ToArray();
            WeBe.cbx_Weathers.Items.AddRange(weatherCodes);
        }

        internal static void CheckIfComboBoxCountryIsLoaded()
        {
            if (Country.DataBase == null)
                Country.InstantiateDataBase();

            if (WeBe.cbx_Country.Items.Count <= 1)
            {
                WeBe.cbx_Country.Items.Clear();
                foreach (var country in Country.DataBase)
                    WeBe.cbx_Country.Items.Add(country.Name);

                WeBe.cbx_State.Items.Clear();
                WeBe.cbx_State.SelectedItem = string.Empty;
                WeBe.cbx_City.Items.Clear();
                WeBe.cbx_City.SelectedItem = string.Empty;
                WeBe.cbx_City.Enabled = false;
            }
        }

        internal static void LoadComboBoxStateBySelectedCountry(string countryName)
        {
            if (Country.DataBase == null)
                Country.InstantiateDataBase();

            WeBe.cbx_State.Items.Clear();
            WeBe.cbx_City.Items.Clear();
            foreach (var state in Country.GetStatesByCountry(countryName))
            {
                if (state.Name == null)
                    continue;

                WeBe.cbx_State.Items.Add(state.Name);
            }

            if (WeBe.cbx_State.Items.Count == 0)
            {
                WeBe.cbx_State.Items.Clear();
                WeBe.cbx_State.SelectedItem = string.Empty;
                WeBe.cbx_State.Enabled = false;
                WeBe.cbx_City.Items.Clear();
                WeBe.cbx_City.SelectedItem = string.Empty;
                WeBe.cbx_City.Enabled = false;
            }
            else
            {
                WeBe.cbx_State.Enabled = true;
            }
        }

        internal static void CheckIfComboBoxStateIsLoaded(string countryName)
        {
            if (Country.DataBase == null)
                Country.InstantiateDataBase();

            if (WeBe.cbx_State.Items.Count <= 1)
            {
                WeBe.cbx_State.Items.Clear();
                foreach (var state in Country.GetStatesByCountry(countryName))
                {
                    if (state.Name == null)
                        continue;

                    WeBe.cbx_State.Items.Add(state.Name);
                }
            }
        }

        internal static void LoadComboBoxCityBySelectedState(string countryName, string stateName)
        {
            if (Country.DataBase == null)
                Country.InstantiateDataBase();

            WeBe.cbx_City.Items.Clear();
            foreach (var city in Country.GetCitiesByState(countryName, stateName))
            {
                if (city.Name == null)
                    continue;

                WeBe.cbx_City.Items.Add(city.Name);
            }

            if (WeBe.cbx_City.Items.Count == 0)
            {
                WeBe.cbx_City.SelectedItem = string.Empty;
                WeBe.cbx_City.Enabled = false;
            }
            else
            {
                WeBe.cbx_City.Enabled = true;
            }
        }

        internal static void CreateThreadAndStart()
        {
            Thread =
            new Thread(async =>
            {
                var location = string.Empty;
                if (SaveSystem.SaveData.City.Length > 0)
                    location = SaveSystem.SaveData.City;
                else if (SaveSystem.SaveData.State.Length > 0)
                    location = SaveSystem.SaveData.State;
                else if (SaveSystem.SaveData.Country.Length > 0)
                    location = SaveSystem.SaveData.Country;
                else
                    return;

                Weather weather = null;
                Profile profile = null;
                var actualProfileName = string.Empty;
                while (true)
                {
                    try
                    {
                        var hourNow = DateTime.Now.TimeOfDay;
                        var isNight = hourNow > TimeSpan.Parse(SaveSystem.SaveData.FirstHourNight) 
                                   && hourNow < TimeSpan.Parse(SaveSystem.SaveData.SecondHourNight);

                        var actualWeather = Weather.GetWeatherByLocation(location);
                        if (weather == null || !weather.Equals(actualWeather))
                        {
                            weather = actualWeather;
                            if (weather?.Data?.Values?.WeatherCode > 0)
                                profile = new Profile(weather.Data.Values.WeatherCode.ToString());
                        }

                        if (profile == null || weather == null)
                            profile = new Profile(DefaultWeatherCode);

                        if ((!isNight && profile.ProfilesDay.Count > 0)  
                        || (isNight && profile.ProfilesNight.Count > 0))
                        {
                            var random = new Random();
                            var profileName = isNight 
                                ? profile.ProfilesNight[random.Next(profile.ProfilesNight.Count - 1)]
                                : profile.ProfilesDay[random.Next(profile.ProfilesDay.Count - 1)];
                            if (!profileName.Equals(actualProfileName))
                            {
                                actualProfileName = profileName;
                                WallpaperEngine.StartAndSetProfile(profileName);
                            }
                        }

                        Thread.Sleep(SaveSystem.SaveData.Interval);
                    } catch { }
                }
            })
            { IsBackground = true };

            Thread.Start();
        }

        internal static void StartThread()
        {
            CreateThreadAndStart();

            ConfigureStartAndStopButtons(started: true);
        }

        internal static void StopThread()
        {
            Thread.Abort();

            ConfigureStartAndStopButtons(started: false);
        }

        internal static void ConfigureStartAndStopButtons(bool started)
        {
            WeBe.btn_Start.Enabled = !started;
            WeBe.btn_Start.Visible = !started;
            WeBe.btn_Stop.Enabled = started;
            WeBe.btn_Stop.Visible = started;

            WeBe.context_Start.Enabled = !started;
            WeBe.context_Start.Visible = !started;
            WeBe.context_Stop.Enabled = started;
            WeBe.context_Stop.Visible = started;
        }
    }
}
