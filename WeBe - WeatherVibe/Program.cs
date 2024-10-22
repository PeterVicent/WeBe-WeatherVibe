﻿using System;
using System.Linq;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;
using System.Collections.Generic;
using WeBe___WeatherVibe.Classes;
using System.IO;

namespace WeBe___WeatherVibe
{
    internal static class Program
    {
        public const string DefaultWeatherCode = "0";

        public static WeBe WeBe;
        public static Thread Thread;
        public static List<string> Pictures;
        
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            LoadVariables();
            WeBe = new WeBe();
            SetVariables();

            Application.Run(WeBe);
        }

        public static void LoadVariables()
        {
            SaveSystem.CheckIfSaveExists();
            Language.InstantiateDataBase();
            Pictures = Directory.GetFiles($"{Application.StartupPath}\\icons", "*.png", SearchOption.AllDirectories).ToList();

            Weather.WeatherCodes = Weather.GetWeatherCodesByLanguage();
            WallpaperEngine.ExecutablePath = SaveSystem.SaveData.WallpaperEngineExecutablePath;
        }

        public static void SetVariables(bool saveCall = false)
        {
            SetSaveDataInTextBoxAndCheckBox();
            SetLanguageInButtonsAndLabels();
            LoadComboBoxsAndSetLanguage();

            if (saveCall)
                return;

            SetFormTheme(SaveSystem.SaveData.DarkMode);
            if (SaveSystem.SaveData.AutoStart)
                StartThread();
        }

        internal static void SetFormTheme(bool darkMode)
        {
            if (darkMode)
            {
                var darkGray = Color.FromArgb(34, 34, 34);
                WeBe.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
                WeBe.label_Powered.ForeColor = Color.Gray;
                WeBe.listBox_Profiles.BackColor = Color.Black;
                WeBe.listBox_Profiles.ForeColor = Color.Gray;
                WeBe.tabPage_Settings.BackColor = darkGray;
                WeBe.tabPage_Profiles.BackColor = darkGray;
                WeBe.txtBox_FirstHourNight.BackColor = darkGray;
                WeBe.txtBox_FirstHourNight.ForeColor = Color.Gray;
                WeBe.txtBox_SecondHourNight.BackColor = darkGray;
                WeBe.txtBox_SecondHourNight.ForeColor = Color.Gray;
            }
            else
            {
                var lightGray = Color.FromArgb(238, 238, 238);
                WeBe.StyleManager.Theme = MetroFramework.MetroThemeStyle.Light;
                WeBe.label_Powered.ForeColor = Color.Black;
                WeBe.listBox_Profiles.BackColor = lightGray;
                WeBe.listBox_Profiles.ForeColor = Color.Black;
                WeBe.tabPage_Settings.BackColor = Control.DefaultBackColor;
                WeBe.tabPage_Profiles.BackColor = Control.DefaultBackColor;
                WeBe.txtBox_FirstHourNight.BackColor = lightGray;
                WeBe.txtBox_FirstHourNight.ForeColor = Color.Black;
                WeBe.txtBox_SecondHourNight.BackColor = lightGray;
                WeBe.txtBox_SecondHourNight.ForeColor = Color.Black;
            }
        }

        internal static void SetSaveDataInTextBoxAndCheckBox()
        {
            WeBe.chkBox_SimplifiedMode.Checked = SaveSystem.SaveData.SimplifiedMode;
            WeBe.chkBox_StartMinimized.Checked = SaveSystem.SaveData.StartMinimized;
            WeBe.chkBox_AutoStart.Checked = SaveSystem.SaveData.AutoStart;
            WeBe.chkBox_StartWithWindows.Checked = SaveSystem.SaveData.StartWithWindows;
            WeBe.txtBx_WallpaperEngineExecutable.Text = WallpaperEngine.ExecutablePath;
            WeBe.txtBx_ApiToken.Text = SaveSystem.SaveData.ApiToken;
            WeBe.txtBx_Interval.Text = (SaveSystem.SaveData.Interval / 60000).ToString();
            WeBe.txtBox_FirstHourNight.Text = SaveSystem.SaveData.FirstHourNight;
            WeBe.txtBox_SecondHourNight.Text = SaveSystem.SaveData.SecondHourNight;
            WeBe.toggle_DarkMode.Checked = SaveSystem.SaveData.DarkMode;
        }

        internal static void SetLanguageInButtonsAndLabels()
        {
            WeBe.label_Powered.Text = $"{Language.DataBase.Powered} Tomorrow.io";

            WeBe.label_ActualWeatherHeader.Text = Language.DataBase.ActualWeather;
            WeBe.label_ActualWeather.Text = Language.DataBase.Unknown;
            WeBe.label_LocationWeather.Text = Language.DataBase.Unknown;

            WeBe.btn_GetWeather.Text = Language.DataBase.GetWeather;
            WeBe.btn_Save.Text = Language.DataBase.Save;
            WeBe.btn_FindExecutable.Text = Language.DataBase.FindExecutable;
            WeBe.btn_Start.Text = Language.DataBase.Start;
            WeBe.context_Start.Text = Language.DataBase.Start;
            WeBe.btn_Stop.Text = Language.DataBase.Stop;
            WeBe.context_Stop.Text = Language.DataBase.Stop;

            WeBe.tabPage_Home.Text = Language.DataBase.Home;
            WeBe.tabPage_Profiles.Text = Language.DataBase.Profiles;
            WeBe.context_Profiles.Text = Language.DataBase.Profiles;
            WeBe.tabPage_Settings.Text = Language.DataBase.Settings;
            WeBe.context_Settings.Text = Language.DataBase.Settings;
            WeBe.context_Exit.Text = Language.DataBase.Exit;

            WeBe.label_WallpaperEngineExecutable.Text = Language.DataBase.WallpaperEngineExecutable;
            WeBe.label_Interval.Text = Language.DataBase.ExecutionInterval;
            WeBe.label_NightInterval.Text = Language.DataBase.NightInterval;
            WeBe.label_Until.Text = Language.DataBase.Until;
            WeBe.chkBox_StartMinimized.Text = Language.DataBase.StartMinimized;
            WeBe.chkBox_AutoStart.Text = Language.DataBase.AutoStart;
            WeBe.chkBox_StartWithWindows.Text = Language.DataBase.StartWithWindows;
            WeBe.label_DarkMode.Text = Language.DataBase.DarkMode;

            WeBe.label_Weather.Text = Language.DataBase.Weather;
            WeBe.chkBox_SimplifiedMode.Text = Language.DataBase.SimplifiedMode;
            WeBe.chkBox_IsNight.Text = Language.DataBase.NightProfile;
            WeBe.label_ProfileName.Text = Language.DataBase.ProfileName;
            WeBe.btn_Add.Text = Language.DataBase.Add;
            WeBe.btn_Clear.Text = Language.DataBase.Clear;

            WeBe.btn_GetWeather.Enabled = true;
            WeBe.btn_GetWeather.Visible = true;
        }

        internal static void LoadComboBoxsAndSetLanguage()
        {
            WeBe.cbx_Country.Items.Clear();
            WeBe.cbx_Country.Text = string.Empty;
            WeBe.cbx_State.Items.Clear();
            WeBe.cbx_State.Text = string.Empty;
            WeBe.cbx_City.Items.Clear();
            WeBe.cbx_City.Text = string.Empty;
            WeBe.cbx_Language.Items.Clear();
            WeBe.cbx_Weathers.Items.Clear();

            WeBe.label_Country.Text = Language.DataBase.Country;
            if (!SaveSystem.SaveData.Country.Equals(string.Empty))
            {
                WeBe.cbx_Country.Items.Add(SaveSystem.SaveData.Country);
                WeBe.cbx_Country.Text += SaveSystem.SaveData.Country;
            }

            WeBe.label_State.Text = Language.DataBase.State;
            if (!SaveSystem.SaveData.State.Equals(string.Empty))
            {
                WeBe.cbx_State.Items.Add(SaveSystem.SaveData.State);
                WeBe.cbx_State.Text += SaveSystem.SaveData.State;
            }
            else
                WeBe.cbx_State.Enabled = false;

            WeBe.label_City.Text = Language.DataBase.City;
            if (!SaveSystem.SaveData.City.Equals(string.Empty))
            {
                WeBe.cbx_City.Items.Add(SaveSystem.SaveData.City);
                WeBe.cbx_City.Text += SaveSystem.SaveData.City;
            }
            else
                WeBe.cbx_City.Enabled = false;

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
            }
        }

        internal static void LoadComboBoxStateBySelectedCountry(string countryName)
        {
            if (Country.DataBase == null)
                Country.InstantiateDataBase();

            WeBe.cbx_State.Items.Clear();
            WeBe.cbx_State.Text = string.Empty;
            WeBe.cbx_City.Items.Clear();
            WeBe.cbx_City.Text = string.Empty;
            foreach (var state in Country.GetStatesByCountry(countryName))
            {
                if (state.Name == null)
                    continue;

                WeBe.cbx_State.Items.Add(state.Name);
            }

            if (WeBe.cbx_State.Items.Count == 0)
            {
                WeBe.cbx_State.Items.Clear();
                WeBe.cbx_State.Text = string.Empty;
                WeBe.cbx_State.SelectedItem = string.Empty;
                WeBe.cbx_State.Enabled = false;
                WeBe.cbx_City.Items.Clear();
                WeBe.cbx_City.Text = string.Empty;
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
            WeBe.cbx_City.Text = string.Empty;
            foreach (var city in Country.GetCitiesByState(countryName, stateName))
            {
                if (city.Name == null)
                    continue;

                WeBe.cbx_City.Items.Add(city.Name);
            }

            if (WeBe.cbx_City.Items.Count == 0)
            {
                WeBe.cbx_City.SelectedItem = string.Empty;
                WeBe.cbx_City.Text = string.Empty;
                WeBe.cbx_City.Enabled = false;
            }
            else
            {
                WeBe.cbx_City.Enabled = true;
            }
        }

        private static void ThreadLogic()
        {
            string location;
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
                    var isNight = Weather.IsNight();
                    var actualWeather = Weather.GetWeatherByLocation(location);
                    if (weather == null || !weather.Equals(actualWeather))
                    {
                        weather = actualWeather;
                        if (weather?.Data?.Values?.WeatherCode > 0)
                        {
                            var weatherCode = weather.Data.Values.WeatherCode.ToString();
                            if (SaveSystem.SaveData.SimplifiedMode)
                                Weather.WeatherCodes.DetailedToSimplified.TryGetValue(weatherCode, out weatherCode);

                            profile = new Profile(weatherCode);
                            
                            SetWeatherInHome(weather);
                        }
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
                } catch { }
                
                Thread.Sleep(SaveSystem.SaveData.Interval);
            }
        }

        internal static Thread GetThread()
            => new Thread(async => { ThreadLogic(); }) { IsBackground = true };

        internal static void StartThread()
        {
            Thread = GetThread();
            Thread.Start();

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

        internal static void SetWeatherInHome(Weather weather)
        {
            if (weather == null)
                return;

            var weatherCode = Weather.WeatherCodes.WeatherCodeFullDay.FirstOrDefault(w => w.Key == weather.Data.Values.WeatherCode.ToString());
            var isNight = Weather.IsNight();

            WeBe.label_ActualWeather.Text = weatherCode.Value;
            WeBe.label_RainIntensity.Text = $"{Language.DataBase.RainIntensity}: {weather.Data.Values.RainIntensity}";
            WeBe.label_SnowIntensity.Text = $"{Language.DataBase.SnowIntensity}: {weather.Data.Values.SnowIntensity}";
            WeBe.label_Temperature.Text = $"{Language.DataBase.Temperature}: {weather.Data.Values.Temperature}";
            WeBe.label_LocationWeather.Text = $"{weather.Location.Name.Replace(',', '\n')}";
            WeBe.picBox_Weather.Image = Weather.GetActualWeatherImage(isNight, weatherCode);
        }
    }
}
