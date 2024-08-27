using Microsoft.Win32;
using System;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using WeBe___WeatherVibe.Classes;

namespace WeBe___WeatherVibe
{
    public partial class WeBe : MetroFramework.Forms.MetroForm
    {
        private Profile Profile;

        public WeBe()
        {
            InitializeComponent();

            if (!SaveSystem.SaveData.StartMinimized)
            {
                WindowState = FormWindowState.Normal;
                SetVisible(true);
            }
            else
            {
                SetVisible(false);
                ShowSuccessfulNotification(Language.DataBase.Successful, Language.DataBase.StartedMinimized);
            }
        }

        internal void ShowSuccessfulNotification(string title, string message)
        {
            Notify.ShowBalloonTip(1000, title, message, ToolTipIcon.Info);
        }

        internal void BringToFontTheWindows()
        {
            SetVisible(true);
            WindowState = FormWindowState.Normal;
            BringToFront();
            CenterToScreen();
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
                StartWithWindows = chkBox_StartWithWindows.Checked,
                DarkMode = toggle_DarkMode.Checked
            };
            SaveSystem.Save();

            Program.LoadVariables();
            Program.SetVariables(saveCall: true);
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

            foreach (var profileDay in Profile.ProfilesDay)
                listBox_Profiles.Items.Add($"{profileDay} ({Language.DataBase.Day})");

            foreach (var profileNight in Profile.ProfilesNight)
                listBox_Profiles.Items.Add($"{profileNight} ({Language.DataBase.Night})");
        }

        public void btn_Add_Click(object sender, EventArgs e)
        {
            var isNightProfile = chkBox_IsNight.Checked;
            var profileName = txtBx_ProfileName.Text;
            var profileNameWithNight = string.Concat(profileName, " (", isNightProfile ? Language.DataBase.Night : Language.DataBase.Day, ")");
            if (profileName.Length <= 0 || listBox_Profiles.Items.Contains(profileNameWithNight))
                return;

            listBox_Profiles.Items.Add(profileNameWithNight);
            Profile.AddProfile(profileName, isNightProfile);
        }

        private void btn_Clear_Click(object sender, EventArgs e)
        {
            listBox_Profiles.Items.Clear();
            Profile.ClearProfiles();
        }

        private void listBox_Profiles_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete && listBox_Profiles.SelectedIndex != -1)
            {
                var selectedItem = listBox_Profiles.Items[listBox_Profiles.SelectedIndex].ToString();
                listBox_Profiles.Items.Remove(selectedItem);
                var textToRemove = selectedItem.Contains(Language.DataBase.Night) ? Language.DataBase.Night : Language.DataBase.Day;
                Profile.RemoveProfile(selectedItem.Replace($" ({textToRemove})", ""), chkBox_IsNight.Checked);
            }
        }

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

            Program.SetWeatherInHome(Weather.GetWeatherByLocation(location));
        }

        private void Notify_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Left)
                return;

            BringToFontTheWindows();
        }
        
        private void context_Profiles_Click(object sender, EventArgs e)
        {
            BringToFontTheWindows();
            tabControl_Principal.SelectedIndex = 1;
        }

        private void context_Settings_Click(object sender, EventArgs e)
        {
            BringToFontTheWindows();
            tabControl_Principal.SelectedIndex = 2;
        }

        private void context_Exit_Click(object sender, EventArgs e)
            => Application.Exit();

        private void toggle_DarkMode_CheckedChanged(object sender, EventArgs e)
            => Program.SetFormTheme(toggle_DarkMode.Checked);

        private void WeBe_Resize(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Minimized)
                SetVisible(false);
            else
                SetVisible(true);
        }

        private void WeBe_Shown(object sender, EventArgs e)
        {
            SetVisible(!SaveSystem.SaveData.StartMinimized);
        }

        public void SetVisible(bool visible)
            => SetVisibleCore(visible);
    }
}
