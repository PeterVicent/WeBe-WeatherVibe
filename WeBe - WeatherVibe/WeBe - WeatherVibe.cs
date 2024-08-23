using Microsoft.Win32;
using System;
using System.Drawing;
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

        internal void BringToFontTheWindows()
        {
            ShowInTaskbar = true;
            WindowState = FormWindowState.Normal;
            BringToFront();
        }

        private void cbx_Country_DropDown(object sender, EventArgs e)
            => Program.CheckIfComboBoxCountryIsLoaded();

        private void cbx_Country_DropDownClosed(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null || cbx_Country.Text.Equals(SaveSystem.SaveData.Country))
                return;

            Program.LoadComboBoxStateBySelectedCountry(cbx_Country.SelectedItem.ToString());
        }

        private void cbx_Country_SelectedIndexChanged(object sender, EventArgs e)
            => cbx_Country_DropDownClosed(sender, e);

        private void cbx_State_DropDown(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null)
                return;

            Program.CheckIfComboBoxStateIsLoaded(cbx_Country.SelectedItem.ToString());
        }

        private void cbx_State_DropDownClosed(object sender, EventArgs e)
        {
            if (cbx_Country.SelectedItem == null || cbx_State.SelectedItem == null || cbx_State.Text.Equals(SaveSystem.SaveData.State))
                return;

            Program.LoadComboBoxCityBySelectedState(cbx_Country.SelectedItem.ToString(), cbx_State.SelectedItem.ToString());
        }

        private void cbx_State_SelectedIndexChanged(object sender, EventArgs e)
            => cbx_State_DropDownClosed(sender, e);

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
            CheckIfNeedToStartWithWindows();

            SaveSystem.SaveData = new SaveData()
            {
                Country = cbx_Country.Text,
                State = cbx_State.Text,
                City = cbx_City.Text,
                Language = Language.SupportedLanguages.FirstOrDefault(language => language.Key == cbx_Language.SelectedItem.ToString()),
                Interval = Convert.ToInt32(txtBx_Interval.Text) * 60000,
                WallpaperEngineExecutablePath = txtBx_WallpaperEngineExecutable.Text,
                ApiToken = txtBx_ApiToken.Text,
                FirstHourNight = txtBox_FirstHourNight.Text,
                SecondHourNight = txtBox_SecondHourNight.Text,
                SimplifiedMode = chkBox_SimplifiedMode.Checked,
                StartMinimized = chkBox_StartMinimized.Checked,
                AutoStart = chkBox_AutoStart.Checked,
                StartWithWindows = chkBox_StartWithWindows.Checked
            };
            SaveSystem.Save();

            Program.LoadVariables();
        }

        private void CheckIfNeedToStartWithWindows()
        {
            if (SaveSystem.SaveData.StartWithWindows.Equals(chkBox_StartWithWindows.Checked))
                return;

            var projectTitle = "WeBe - WeatherVibe";
            var register = Registry.CurrentUser.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\Run", true);
            if (chkBox_StartWithWindows.Checked)
                register.SetValue(projectTitle, Application.ExecutablePath.ToString());
            else
                register.DeleteValue(projectTitle, false);
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
            string location;
            if (SaveSystem.SaveData.City.Length > 0)
                location = SaveSystem.SaveData.City;
            else if (SaveSystem.SaveData.State.Length > 0)
                location = SaveSystem.SaveData.State;
            else if (SaveSystem.SaveData.Country.Length > 0)
                location = SaveSystem.SaveData.Country;
            else
                return;

            var actualWeather = Weather.GetWeatherByLocation(location);
            var weatherCode = Weather.WeatherCodes.WeatherCodeFullDay.FirstOrDefault(w => w.Key.Equals(actualWeather.Data.Values.WeatherCode.ToString()));
            Program.SetWeatherInHome(weatherCode.Key);
        }

        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            BringToFontTheWindows();
        }

        private void WeBe_Deactivate(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                ShowInTaskbar = false;
        }

        private void context_Options_Click(object sender, EventArgs e)
        {
            BringToFontTheWindows();
            tabControl_Principal.SelectedIndex = 1;
        }

        private void context_Profiles_Click(object sender, EventArgs e)
        {
            context_Options_Click(sender, e);
            tabControl_Configuration.SelectedIndex = 0;
        }

        private void context_Settings_Click(object sender, EventArgs e)
        {
            context_Options_Click(sender, e);
            tabControl_Configuration.SelectedIndex = 1;
        }

        private void context_Exit_Click(object sender, EventArgs e)
            => Application.Exit();
    }
}
