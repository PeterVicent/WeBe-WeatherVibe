﻿using System;
using System.Linq;
using System.Windows.Forms;
using WeBe___WeatherVibe.Classes;

namespace WeBe___WeatherVibe
{
    public partial class WeBe : Form
    {
        private Profile Profile;

        public WeBe()
        {
            InitializeComponent();
        }

        private void cbx_Country_DropDown(object sender, EventArgs e)
            => Program.CheckIfComboBoxCountryIsLoaded();

        private void cbx_Country_DropDownClosed(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null)
                return;

            Program.LoadComboBoxStateBySelectedCountry(cbx_Country.SelectedItem.ToString());
        }

        private void cbx_State_DropDown(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null)
                return;

            Program.CheckIfComboBoxStateIsLoaded(cbx_Country.SelectedItem.ToString());
        }

        private void cbx_State_DropDownClosed(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null || cbx_State.SelectedItem == null)
                return;

            Program.LoadComboBoxCityBySelectedState(cbx_Country.SelectedItem.ToString(), cbx_State.SelectedItem.ToString());
        }

        private void cbx_Language_DropDown(object sender, EventArgs e)
        {
            cbx_Language.Items.Clear();

            foreach (var language in Language.SupportedLanguages)
                cbx_Language.Items.Add(language.Key);
        }

        private void btn_FindExecutable_Click(object sender, EventArgs e)
        {
            if (WallpaperEngine.ShowDialog() == DialogResult.OK)
                txtBx_WallpaperEngineExecutable.Text = WallpaperEngine.FileName;
        }

        private void btn_Save_Click(object sender, EventArgs e)
        {
            SaveSystem.SaveData = new SaveData()
            {
                Country = cbx_Country.SelectedItem.ToString(),
                State = cbx_State.SelectedItem.ToString(),
                City = cbx_City.SelectedItem.ToString(),
                Language = Language.SupportedLanguages.FirstOrDefault(language => language.Key == cbx_Language.SelectedItem.ToString()),
                Interval = Convert.ToInt32(txtBx_Interval.Text) * 60000,
                WallpaperEngineExecutablePath = txtBx_WallpaperEngineExecutable.Text,
                ApiToken = txtBx_ApiToken.Text,
                FirstHourNight = txtBox_FirstHourNight.Text,
                SecondHourNight = txtBox_SecondHourNight.Text,
                SimplifiedMode = chkBox_SimplifiedMode.Checked
            };
            SaveSystem.Save();

            Program.LoadVariables();
        }

        private void btn_Start_Click(object sender, EventArgs e)
            => Program.StartThread();

        private void context_Start_Click(object sender, EventArgs e)
            => Program.StartThread();

        private void btn_Stop_Click(object sender, EventArgs e)
            => Program.StopThread();

        private void context_Stop_Click(object sender, EventArgs e)
            => Program.StopThread();

        private void cbx_Weathers_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbx_Weathers.SelectedItem == null)
                return;

            txtBx_ProfileName.Clear();

            var selectedWeather = cbx_Weathers.SelectedItem.ToString();
            var weather = SaveSystem.SaveData.SimplifiedMode 
                ? Weather.WeatherCodes.WeatherCodeSimplified.FirstOrDefault(w => w.Value.Equals(selectedWeather))
                : Weather.WeatherCodes.WeatherCodeFullDay.FirstOrDefault(w => w.Value.Equals(selectedWeather));
            Profile = new Profile(weather.Key);

            listBox_Profiles.Items.Clear();

            var profiles = chkBox_IsNight.Checked
                ? Profile.ProfilesNight
                : Profile.ProfilesDay;
            listBox_Profiles.Items.AddRange(profiles.ToArray());
        }

        public void btn_Add_Click(object sender, EventArgs e)
        {
            var profileName = txtBx_ProfileName.Text;
            if (profileName.Length <= 0 || listBox_Profiles.Items.Contains(profileName))
                return;

            listBox_Profiles.Items.Add(profileName);
            Profile.AddProfile(profileName, chkBox_IsNight.Checked);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox_Profiles.Items.Clear();
            Profile.ClearProfiles(chkBox_IsNight.Checked);
        }

        private void listBox_Profiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBox_Profiles.SelectedIndex != -1)
            {
                var selectedItem = listBox_Profiles.Items[listBox_Profiles.SelectedIndex];
                listBox_Profiles.Items.Remove(selectedItem);
                Profile.RemoveProfile(selectedItem.ToString(), chkBox_IsNight.Checked);
            }
        }

        private void chkBox_IsNight_CheckStateChanged(object sender, EventArgs e)
            => cbx_Weathers_SelectedIndexChanged(sender, e);

        private void btn_GetWeather_Click(object sender, EventArgs e)
        {
            var actualWeather = Weather.GetWeatherByLocation(SaveSystem.SaveData.City);
            var weatherCode = Weather.WeatherCodes.WeatherCodeFullDay.FirstOrDefault(w => w.Key.Equals(actualWeather.Data.Values.WeatherCode.ToString()));
            label_ActualWeather.Text = weatherCode.Value.ToString();
        }

        private void Notify_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Normal;
            BringToFront();
        }
    }
}
