using System.Windows.Forms;
using WeBe___WeatherVibe.Classes;

namespace WeBe___WeatherVibe
{
    partial class WeBe
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WeBe));
            this.txtBox_SecondHourNight = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_FirstHourNight = new System.Windows.Forms.MaskedTextBox();
            this.listBox_Profiles = new System.Windows.Forms.ListBox();
            this.picBox_Weather = new System.Windows.Forms.PictureBox();
            this.WallpaperEngine = new System.Windows.Forms.OpenFileDialog();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Profiles = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Powered = new System.Windows.Forms.Label();
            this.tabControl_Principal = new MetroFramework.Controls.MetroTabControl();
            this.tabPage_Home = new MetroFramework.Controls.MetroTabPage();
            this.label_LocationWeather = new MetroFramework.Controls.MetroLabel();
            this.label_Temperature = new MetroFramework.Controls.MetroLabel();
            this.label_SnowIntensity = new MetroFramework.Controls.MetroLabel();
            this.label_RainIntensity = new MetroFramework.Controls.MetroLabel();
            this.label_ActualWeather = new MetroFramework.Controls.MetroLabel();
            this.btn_GetWeather = new MetroFramework.Controls.MetroButton();
            this.label_ActualWeatherHeader = new MetroFramework.Controls.MetroLabel();
            this.btn_Stop = new MetroFramework.Controls.MetroButton();
            this.btn_Start = new MetroFramework.Controls.MetroButton();
            this.tabPage_Profiles = new MetroFramework.Controls.MetroTabPage();
            this.btn_Add = new MetroFramework.Controls.MetroButton();
            this.chkBox_IsNight = new MetroFramework.Controls.MetroCheckBox();
            this.btn_Clear = new MetroFramework.Controls.MetroButton();
            this.txtBx_ProfileName = new MetroFramework.Controls.MetroTextBox();
            this.label_Weather = new MetroFramework.Controls.MetroLabel();
            this.label_ProfileName = new MetroFramework.Controls.MetroLabel();
            this.cbx_Weathers = new MetroFramework.Controls.MetroComboBox();
            this.chkBox_SimplifiedMode = new MetroFramework.Controls.MetroCheckBox();
            this.tabPage_Settings = new MetroFramework.Controls.MetroTabPage();
            this.btn_Save = new MetroFramework.Controls.MetroButton();
            this.label_DarkMode = new MetroFramework.Controls.MetroLabel();
            this.txtBx_WallpaperEngineExecutable = new MetroFramework.Controls.MetroTextBox();
            this.toggle_DarkMode = new MetroFramework.Controls.MetroToggle();
            this.label_WallpaperEngineExecutable = new MetroFramework.Controls.MetroLabel();
            this.label_Language = new MetroFramework.Controls.MetroLabel();
            this.btn_FindExecutable = new MetroFramework.Controls.MetroButton();
            this.cbx_Language = new MetroFramework.Controls.MetroComboBox();
            this.chkBox_StartMinimized = new MetroFramework.Controls.MetroCheckBox();
            this.label_NightInterval = new MetroFramework.Controls.MetroLabel();
            this.label_Interval = new MetroFramework.Controls.MetroLabel();
            this.txtBx_Interval = new MetroFramework.Controls.MetroTextBox();
            this.label_Until = new MetroFramework.Controls.MetroLabel();
            this.chkBox_AutoStart = new MetroFramework.Controls.MetroCheckBox();
            this.cbx_City = new MetroFramework.Controls.MetroComboBox();
            this.chkBox_StartWithWindows = new MetroFramework.Controls.MetroCheckBox();
            this.label_City = new MetroFramework.Controls.MetroLabel();
            this.label_ApiToken = new MetroFramework.Controls.MetroLabel();
            this.cbx_State = new MetroFramework.Controls.MetroComboBox();
            this.txtBx_ApiToken = new MetroFramework.Controls.MetroTextBox();
            this.label_State = new MetroFramework.Controls.MetroLabel();
            this.label_Country = new MetroFramework.Controls.MetroLabel();
            this.cbx_Country = new MetroFramework.Controls.MetroComboBox();
            this.StyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Weather)).BeginInit();
            this.notify_ContextMenu.SuspendLayout();
            this.tabControl_Principal.SuspendLayout();
            this.tabPage_Home.SuspendLayout();
            this.tabPage_Profiles.SuspendLayout();
            this.tabPage_Settings.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBox_SecondHourNight
            // 
            this.txtBox_SecondHourNight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_SecondHourNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_SecondHourNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_SecondHourNight.Location = new System.Drawing.Point(521, 299);
            this.txtBox_SecondHourNight.Mask = "00:00";
            this.txtBox_SecondHourNight.Name = "txtBox_SecondHourNight";
            this.txtBox_SecondHourNight.Size = new System.Drawing.Size(42, 17);
            this.txtBox_SecondHourNight.TabIndex = 23;
            this.txtBox_SecondHourNight.Text = "1800";
            this.txtBox_SecondHourNight.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_FirstHourNight
            // 
            this.txtBox_FirstHourNight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_FirstHourNight.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBox_FirstHourNight.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_FirstHourNight.Location = new System.Drawing.Point(425, 299);
            this.txtBox_FirstHourNight.Mask = "00:00";
            this.txtBox_FirstHourNight.Name = "txtBox_FirstHourNight";
            this.txtBox_FirstHourNight.Size = new System.Drawing.Size(42, 17);
            this.txtBox_FirstHourNight.TabIndex = 22;
            this.txtBox_FirstHourNight.Text = "1800";
            this.txtBox_FirstHourNight.ValidatingType = typeof(System.DateTime);
            // 
            // listBox_Profiles
            // 
            this.listBox_Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Profiles.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.listBox_Profiles.FormattingEnabled = true;
            this.listBox_Profiles.ItemHeight = 16;
            this.listBox_Profiles.Location = new System.Drawing.Point(3, 13);
            this.listBox_Profiles.Name = "listBox_Profiles";
            this.listBox_Profiles.Size = new System.Drawing.Size(212, 416);
            this.listBox_Profiles.TabIndex = 0;
            this.listBox_Profiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Profiles_KeyDown);
            // 
            // picBox_Weather
            // 
            this.picBox_Weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox_Weather.BackColor = System.Drawing.Color.Transparent;
            this.picBox_Weather.ErrorImage = global::WeBe___WeatherVibe.Properties.Resources.sunny;
            this.picBox_Weather.Image = global::WeBe___WeatherVibe.Properties.Resources.sunny;
            this.picBox_Weather.InitialImage = global::WeBe___WeatherVibe.Properties.Resources.sunny;
            this.picBox_Weather.Location = new System.Drawing.Point(215, 46);
            this.picBox_Weather.Name = "picBox_Weather";
            this.picBox_Weather.Size = new System.Drawing.Size(144, 144);
            this.picBox_Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Weather.TabIndex = 5;
            this.picBox_Weather.TabStop = false;
            // 
            // WallpaperEngine
            // 
            this.WallpaperEngine.FileName = "openFileDialog_WalpaperEngine";
            this.WallpaperEngine.Filter = "WallpaperEngine|*.exe";
            // 
            // Notify
            // 
            this.Notify.BalloonTipTitle = "WeBe - WeatherVibe";
            this.Notify.ContextMenuStrip = this.notify_ContextMenu;
            this.Notify.Icon = ((System.Drawing.Icon)(resources.GetObject("Notify.Icon")));
            this.Notify.Text = "WeBe - WeatherVibe";
            this.Notify.Visible = true;
            this.Notify.MouseClick += new System.Windows.Forms.MouseEventHandler(this.Notify_MouseClick);
            // 
            // notify_ContextMenu
            // 
            this.notify_ContextMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_Start,
            this.context_Stop,
            this.context_Profiles,
            this.context_Settings,
            this.context_Exit});
            this.notify_ContextMenu.Name = "notify_ContextMenu";
            this.notify_ContextMenu.Size = new System.Drawing.Size(117, 114);
            // 
            // context_Start
            // 
            this.context_Start.Name = "context_Start";
            this.context_Start.Size = new System.Drawing.Size(116, 22);
            this.context_Start.Text = "START";
            this.context_Start.Click += new System.EventHandler(this.context_Start_Click);
            // 
            // context_Stop
            // 
            this.context_Stop.Name = "context_Stop";
            this.context_Stop.Size = new System.Drawing.Size(116, 22);
            this.context_Stop.Text = "STOP";
            this.context_Stop.Visible = false;
            this.context_Stop.Click += new System.EventHandler(this.context_Stop_Click);
            // 
            // context_Profiles
            // 
            this.context_Profiles.Name = "context_Profiles";
            this.context_Profiles.Size = new System.Drawing.Size(116, 22);
            this.context_Profiles.Text = "Profiles";
            this.context_Profiles.Click += new System.EventHandler(this.context_Profiles_Click);
            // 
            // context_Settings
            // 
            this.context_Settings.Name = "context_Settings";
            this.context_Settings.Size = new System.Drawing.Size(116, 22);
            this.context_Settings.Text = "Settings";
            this.context_Settings.Click += new System.EventHandler(this.context_Settings_Click);
            // 
            // context_Exit
            // 
            this.context_Exit.Name = "context_Exit";
            this.context_Exit.Size = new System.Drawing.Size(116, 22);
            this.context_Exit.Text = "Exit";
            this.context_Exit.Click += new System.EventHandler(this.context_Exit_Click);
            // 
            // label_Powered
            // 
            this.label_Powered.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_Powered.BackColor = System.Drawing.Color.Transparent;
            this.label_Powered.ForeColor = System.Drawing.Color.Black;
            this.label_Powered.Location = new System.Drawing.Point(16, 563);
            this.label_Powered.Name = "label_Powered";
            this.label_Powered.Size = new System.Drawing.Size(590, 13);
            this.label_Powered.TabIndex = 5;
            this.label_Powered.Text = "Icons and API powered by Tomorrow.io";
            this.label_Powered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabControl_Principal
            // 
            this.tabControl_Principal.Appearance = System.Windows.Forms.TabAppearance.FlatButtons;
            this.tabControl_Principal.Controls.Add(this.tabPage_Home);
            this.tabControl_Principal.Controls.Add(this.tabPage_Profiles);
            this.tabControl_Principal.Controls.Add(this.tabPage_Settings);
            this.tabControl_Principal.Location = new System.Drawing.Point(19, 56);
            this.tabControl_Principal.Multiline = true;
            this.tabControl_Principal.Name = "tabControl_Principal";
            this.tabControl_Principal.SelectedIndex = 2;
            this.tabControl_Principal.Size = new System.Drawing.Size(583, 504);
            this.tabControl_Principal.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabControl_Principal.TabIndex = 6;
            this.tabControl_Principal.UseStyleColors = true;
            // 
            // tabPage_Home
            // 
            this.tabPage_Home.Controls.Add(this.label_LocationWeather);
            this.tabPage_Home.Controls.Add(this.label_Temperature);
            this.tabPage_Home.Controls.Add(this.label_SnowIntensity);
            this.tabPage_Home.Controls.Add(this.label_RainIntensity);
            this.tabPage_Home.Controls.Add(this.label_ActualWeather);
            this.tabPage_Home.Controls.Add(this.btn_GetWeather);
            this.tabPage_Home.Controls.Add(this.label_ActualWeatherHeader);
            this.tabPage_Home.Controls.Add(this.btn_Stop);
            this.tabPage_Home.Controls.Add(this.btn_Start);
            this.tabPage_Home.Controls.Add(this.picBox_Weather);
            this.tabPage_Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Home.HorizontalScrollbarBarColor = true;
            this.tabPage_Home.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Home.Name = "tabPage_Home";
            this.tabPage_Home.Size = new System.Drawing.Size(575, 462);
            this.tabPage_Home.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabPage_Home.TabIndex = 0;
            this.tabPage_Home.Text = "Home";
            this.tabPage_Home.VerticalScrollbarBarColor = true;
            // 
            // label_LocationWeather
            // 
            this.label_LocationWeather.FontSize = MetroFramework.MetroLabelSize.Small;
            this.label_LocationWeather.Location = new System.Drawing.Point(3, 295);
            this.label_LocationWeather.Name = "label_LocationWeather";
            this.label_LocationWeather.Size = new System.Drawing.Size(569, 103);
            this.label_LocationWeather.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_LocationWeather.TabIndex = 11;
            this.label_LocationWeather.Text = "Desconhecido";
            this.label_LocationWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Temperature
            // 
            this.label_Temperature.Location = new System.Drawing.Point(3, 272);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(569, 23);
            this.label_Temperature.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Temperature.TabIndex = 10;
            this.label_Temperature.Text = "Temperature: 0";
            this.label_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SnowIntensity
            // 
            this.label_SnowIntensity.Location = new System.Drawing.Point(3, 249);
            this.label_SnowIntensity.Name = "label_SnowIntensity";
            this.label_SnowIntensity.Size = new System.Drawing.Size(569, 23);
            this.label_SnowIntensity.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_SnowIntensity.TabIndex = 9;
            this.label_SnowIntensity.Text = "Snow Intensity: 0";
            this.label_SnowIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_RainIntensity
            // 
            this.label_RainIntensity.Location = new System.Drawing.Point(3, 226);
            this.label_RainIntensity.Name = "label_RainIntensity";
            this.label_RainIntensity.Size = new System.Drawing.Size(569, 23);
            this.label_RainIntensity.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_RainIntensity.TabIndex = 8;
            this.label_RainIntensity.Text = "Rain Intensity: 0";
            this.label_RainIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ActualWeather
            // 
            this.label_ActualWeather.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_ActualWeather.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_ActualWeather.Location = new System.Drawing.Point(3, 198);
            this.label_ActualWeather.Name = "label_ActualWeather";
            this.label_ActualWeather.Size = new System.Drawing.Size(569, 23);
            this.label_ActualWeather.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_ActualWeather.TabIndex = 7;
            this.label_ActualWeather.Text = "Desconhecido";
            this.label_ActualWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GetWeather
            // 
            this.btn_GetWeather.Location = new System.Drawing.Point(238, 400);
            this.btn_GetWeather.Name = "btn_GetWeather";
            this.btn_GetWeather.Size = new System.Drawing.Size(99, 23);
            this.btn_GetWeather.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_GetWeather.TabIndex = 6;
            this.btn_GetWeather.Text = "Get Weather";
            this.btn_GetWeather.Click += new System.EventHandler(this.btn_GetWeather_Click);
            // 
            // label_ActualWeatherHeader
            // 
            this.label_ActualWeatherHeader.FontSize = MetroFramework.MetroLabelSize.Tall;
            this.label_ActualWeatherHeader.FontWeight = MetroFramework.MetroLabelWeight.Bold;
            this.label_ActualWeatherHeader.Location = new System.Drawing.Point(3, 16);
            this.label_ActualWeatherHeader.Name = "label_ActualWeatherHeader";
            this.label_ActualWeatherHeader.Size = new System.Drawing.Size(569, 23);
            this.label_ActualWeatherHeader.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_ActualWeatherHeader.TabIndex = 4;
            this.label_ActualWeatherHeader.Text = "Actual Weather";
            this.label_ActualWeatherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_Stop
            // 
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Location = new System.Drawing.Point(0, 396);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(575, 33);
            this.btn_Stop.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Stop.TabIndex = 3;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.Visible = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Start.Location = new System.Drawing.Point(0, 429);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(575, 33);
            this.btn_Start.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Start.TabIndex = 2;
            this.btn_Start.Text = "START";
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // tabPage_Profiles
            // 
            this.tabPage_Profiles.Controls.Add(this.btn_Add);
            this.tabPage_Profiles.Controls.Add(this.listBox_Profiles);
            this.tabPage_Profiles.Controls.Add(this.chkBox_IsNight);
            this.tabPage_Profiles.Controls.Add(this.btn_Clear);
            this.tabPage_Profiles.Controls.Add(this.txtBx_ProfileName);
            this.tabPage_Profiles.Controls.Add(this.label_Weather);
            this.tabPage_Profiles.Controls.Add(this.label_ProfileName);
            this.tabPage_Profiles.Controls.Add(this.cbx_Weathers);
            this.tabPage_Profiles.Controls.Add(this.chkBox_SimplifiedMode);
            this.tabPage_Profiles.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage_Profiles.HorizontalScrollbarBarColor = true;
            this.tabPage_Profiles.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Profiles.Name = "tabPage_Profiles";
            this.tabPage_Profiles.Size = new System.Drawing.Size(575, 462);
            this.tabPage_Profiles.Style = MetroFramework.MetroColorStyle.Orange;
            this.tabPage_Profiles.TabIndex = 1;
            this.tabPage_Profiles.Text = "Profiles";
            this.tabPage_Profiles.VerticalScrollbarBarColor = true;
            // 
            // btn_Add
            // 
            this.btn_Add.Location = new System.Drawing.Point(277, 237);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(236, 23);
            this.btn_Add.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Add.TabIndex = 9;
            this.btn_Add.Text = "Add";
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // chkBox_IsNight
            // 
            this.chkBox_IsNight.AutoSize = true;
            this.chkBox_IsNight.Location = new System.Drawing.Point(388, 189);
            this.chkBox_IsNight.Name = "chkBox_IsNight";
            this.chkBox_IsNight.Size = new System.Drawing.Size(90, 15);
            this.chkBox_IsNight.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkBox_IsNight.TabIndex = 8;
            this.chkBox_IsNight.Text = "Night Profile";
            this.chkBox_IsNight.UseVisualStyleBackColor = true;
            this.chkBox_IsNight.CheckStateChanged += new System.EventHandler(this.chkBox_IsNight_CheckStateChanged);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Location = new System.Drawing.Point(3, 439);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(212, 23);
            this.btn_Clear.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Clear.TabIndex = 2;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // txtBx_ProfileName
            // 
            this.txtBx_ProfileName.Location = new System.Drawing.Point(277, 208);
            this.txtBx_ProfileName.Name = "txtBx_ProfileName";
            this.txtBx_ProfileName.Size = new System.Drawing.Size(236, 23);
            this.txtBx_ProfileName.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtBx_ProfileName.TabIndex = 7;
            // 
            // label_Weather
            // 
            this.label_Weather.AutoSize = true;
            this.label_Weather.Location = new System.Drawing.Point(277, 120);
            this.label_Weather.Name = "label_Weather";
            this.label_Weather.Size = new System.Drawing.Size(58, 19);
            this.label_Weather.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Weather.TabIndex = 3;
            this.label_Weather.Text = "Weather";
            // 
            // label_ProfileName
            // 
            this.label_ProfileName.AutoSize = true;
            this.label_ProfileName.Location = new System.Drawing.Point(277, 185);
            this.label_ProfileName.Name = "label_ProfileName";
            this.label_ProfileName.Size = new System.Drawing.Size(87, 19);
            this.label_ProfileName.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_ProfileName.TabIndex = 6;
            this.label_ProfileName.Text = "Profile Name";
            // 
            // cbx_Weathers
            // 
            this.cbx_Weathers.FormattingEnabled = true;
            this.cbx_Weathers.ItemHeight = 23;
            this.cbx_Weathers.Location = new System.Drawing.Point(277, 142);
            this.cbx_Weathers.Name = "cbx_Weathers";
            this.cbx_Weathers.Size = new System.Drawing.Size(236, 29);
            this.cbx_Weathers.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbx_Weathers.TabIndex = 4;
            this.cbx_Weathers.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.cbx_Weathers.SelectedIndexChanged += new System.EventHandler(this.cbx_Weathers_SelectedIndexChanged);
            // 
            // chkBox_SimplifiedMode
            // 
            this.chkBox_SimplifiedMode.AutoSize = true;
            this.chkBox_SimplifiedMode.Location = new System.Drawing.Point(388, 121);
            this.chkBox_SimplifiedMode.Name = "chkBox_SimplifiedMode";
            this.chkBox_SimplifiedMode.Size = new System.Drawing.Size(110, 15);
            this.chkBox_SimplifiedMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkBox_SimplifiedMode.TabIndex = 5;
            this.chkBox_SimplifiedMode.Text = "Simplified Mode";
            this.chkBox_SimplifiedMode.UseVisualStyleBackColor = true;
            this.chkBox_SimplifiedMode.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tabPage_Settings
            // 
            this.tabPage_Settings.Controls.Add(this.btn_Save);
            this.tabPage_Settings.Controls.Add(this.label_DarkMode);
            this.tabPage_Settings.Controls.Add(this.txtBx_WallpaperEngineExecutable);
            this.tabPage_Settings.Controls.Add(this.toggle_DarkMode);
            this.tabPage_Settings.Controls.Add(this.label_WallpaperEngineExecutable);
            this.tabPage_Settings.Controls.Add(this.label_Language);
            this.tabPage_Settings.Controls.Add(this.btn_FindExecutable);
            this.tabPage_Settings.Controls.Add(this.cbx_Language);
            this.tabPage_Settings.Controls.Add(this.txtBox_SecondHourNight);
            this.tabPage_Settings.Controls.Add(this.chkBox_StartMinimized);
            this.tabPage_Settings.Controls.Add(this.label_NightInterval);
            this.tabPage_Settings.Controls.Add(this.label_Interval);
            this.tabPage_Settings.Controls.Add(this.txtBox_FirstHourNight);
            this.tabPage_Settings.Controls.Add(this.txtBx_Interval);
            this.tabPage_Settings.Controls.Add(this.label_Until);
            this.tabPage_Settings.Controls.Add(this.chkBox_AutoStart);
            this.tabPage_Settings.Controls.Add(this.cbx_City);
            this.tabPage_Settings.Controls.Add(this.chkBox_StartWithWindows);
            this.tabPage_Settings.Controls.Add(this.label_City);
            this.tabPage_Settings.Controls.Add(this.label_ApiToken);
            this.tabPage_Settings.Controls.Add(this.cbx_State);
            this.tabPage_Settings.Controls.Add(this.txtBx_ApiToken);
            this.tabPage_Settings.Controls.Add(this.label_State);
            this.tabPage_Settings.Controls.Add(this.label_Country);
            this.tabPage_Settings.Controls.Add(this.cbx_Country);
            this.tabPage_Settings.HorizontalScrollbarBarColor = true;
            this.tabPage_Settings.Location = new System.Drawing.Point(4, 38);
            this.tabPage_Settings.Name = "tabPage_Settings";
            this.tabPage_Settings.Size = new System.Drawing.Size(575, 462);
            this.tabPage_Settings.TabIndex = 2;
            this.tabPage_Settings.Text = "Settings";
            this.tabPage_Settings.VerticalScrollbarBarColor = true;
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(0, 439);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(575, 23);
            this.btn_Save.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_Save.TabIndex = 32;
            this.btn_Save.Text = "Save";
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // label_DarkMode
            // 
            this.label_DarkMode.BackColor = System.Drawing.Color.Transparent;
            this.label_DarkMode.Location = new System.Drawing.Point(230, 352);
            this.label_DarkMode.Name = "label_DarkMode";
            this.label_DarkMode.Size = new System.Drawing.Size(111, 23);
            this.label_DarkMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_DarkMode.TabIndex = 34;
            this.label_DarkMode.Text = "Dark Mode";
            this.label_DarkMode.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtBx_WallpaperEngineExecutable
            // 
            this.txtBx_WallpaperEngineExecutable.Location = new System.Drawing.Point(10, 53);
            this.txtBx_WallpaperEngineExecutable.Name = "txtBx_WallpaperEngineExecutable";
            this.txtBx_WallpaperEngineExecutable.Size = new System.Drawing.Size(555, 23);
            this.txtBx_WallpaperEngineExecutable.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtBx_WallpaperEngineExecutable.TabIndex = 2;
            // 
            // toggle_DarkMode
            // 
            this.toggle_DarkMode.AutoSize = true;
            this.toggle_DarkMode.DisplayStatus = false;
            this.toggle_DarkMode.Location = new System.Drawing.Point(260, 378);
            this.toggle_DarkMode.Name = "toggle_DarkMode";
            this.toggle_DarkMode.Size = new System.Drawing.Size(50, 17);
            this.toggle_DarkMode.Style = MetroFramework.MetroColorStyle.Orange;
            this.toggle_DarkMode.TabIndex = 33;
            this.toggle_DarkMode.Text = "Off";
            this.toggle_DarkMode.UseVisualStyleBackColor = true;
            this.toggle_DarkMode.CheckedChanged += new System.EventHandler(this.toggle_DarkMode_CheckedChanged);
            // 
            // label_WallpaperEngineExecutable
            // 
            this.label_WallpaperEngineExecutable.AutoSize = true;
            this.label_WallpaperEngineExecutable.BackColor = System.Drawing.Color.Transparent;
            this.label_WallpaperEngineExecutable.Location = new System.Drawing.Point(11, 31);
            this.label_WallpaperEngineExecutable.Name = "label_WallpaperEngineExecutable";
            this.label_WallpaperEngineExecutable.Size = new System.Drawing.Size(178, 19);
            this.label_WallpaperEngineExecutable.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_WallpaperEngineExecutable.TabIndex = 3;
            this.label_WallpaperEngineExecutable.Text = "Wallpaper Engine Executable";
            // 
            // label_Language
            // 
            this.label_Language.AutoSize = true;
            this.label_Language.BackColor = System.Drawing.Color.Transparent;
            this.label_Language.Location = new System.Drawing.Point(9, 133);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(66, 19);
            this.label_Language.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Language.TabIndex = 4;
            this.label_Language.Text = "Language";
            // 
            // btn_FindExecutable
            // 
            this.btn_FindExecutable.Location = new System.Drawing.Point(10, 83);
            this.btn_FindExecutable.Name = "btn_FindExecutable";
            this.btn_FindExecutable.Size = new System.Drawing.Size(555, 23);
            this.btn_FindExecutable.Style = MetroFramework.MetroColorStyle.Orange;
            this.btn_FindExecutable.TabIndex = 31;
            this.btn_FindExecutable.Text = "Find Executable";
            this.btn_FindExecutable.Click += new System.EventHandler(this.btn_FindExecutable_Click);
            // 
            // cbx_Language
            // 
            this.cbx_Language.FormattingEnabled = true;
            this.cbx_Language.ItemHeight = 23;
            this.cbx_Language.Location = new System.Drawing.Point(10, 154);
            this.cbx_Language.Name = "cbx_Language";
            this.cbx_Language.Size = new System.Drawing.Size(162, 29);
            this.cbx_Language.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbx_Language.TabIndex = 5;
            this.cbx_Language.DropDown += new System.EventHandler(this.cbx_Language_DropDown);
            // 
            // chkBox_StartMinimized
            // 
            this.chkBox_StartMinimized.AutoSize = true;
            this.chkBox_StartMinimized.BackColor = System.Drawing.Color.Transparent;
            this.chkBox_StartMinimized.Location = new System.Drawing.Point(395, 161);
            this.chkBox_StartMinimized.Name = "chkBox_StartMinimized";
            this.chkBox_StartMinimized.Size = new System.Drawing.Size(106, 15);
            this.chkBox_StartMinimized.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkBox_StartMinimized.TabIndex = 6;
            this.chkBox_StartMinimized.Text = "Start Minimized";
            this.chkBox_StartMinimized.UseVisualStyleBackColor = false;
            // 
            // label_NightInterval
            // 
            this.label_NightInterval.BackColor = System.Drawing.Color.Transparent;
            this.label_NightInterval.Location = new System.Drawing.Point(422, 271);
            this.label_NightInterval.Name = "label_NightInterval";
            this.label_NightInterval.Size = new System.Drawing.Size(143, 19);
            this.label_NightInterval.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_NightInterval.TabIndex = 30;
            this.label_NightInterval.Text = "Night Interval";
            this.label_NightInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Interval
            // 
            this.label_Interval.AutoSize = true;
            this.label_Interval.BackColor = System.Drawing.Color.Transparent;
            this.label_Interval.Location = new System.Drawing.Point(213, 133);
            this.label_Interval.Name = "label_Interval";
            this.label_Interval.Size = new System.Drawing.Size(111, 19);
            this.label_Interval.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Interval.TabIndex = 7;
            this.label_Interval.Text = "Execution Interval";
            // 
            // txtBx_Interval
            // 
            this.txtBx_Interval.Location = new System.Drawing.Point(213, 157);
            this.txtBx_Interval.Name = "txtBx_Interval";
            this.txtBx_Interval.Size = new System.Drawing.Size(152, 23);
            this.txtBx_Interval.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtBx_Interval.TabIndex = 8;
            // 
            // label_Until
            // 
            this.label_Until.BackColor = System.Drawing.Color.Transparent;
            this.label_Until.Location = new System.Drawing.Point(471, 296);
            this.label_Until.Name = "label_Until";
            this.label_Until.Size = new System.Drawing.Size(46, 23);
            this.label_Until.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Until.TabIndex = 29;
            this.label_Until.Text = "Until";
            this.label_Until.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // chkBox_AutoStart
            // 
            this.chkBox_AutoStart.AutoSize = true;
            this.chkBox_AutoStart.BackColor = System.Drawing.Color.Transparent;
            this.chkBox_AutoStart.Location = new System.Drawing.Point(395, 182);
            this.chkBox_AutoStart.Name = "chkBox_AutoStart";
            this.chkBox_AutoStart.Size = new System.Drawing.Size(83, 15);
            this.chkBox_AutoStart.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkBox_AutoStart.TabIndex = 9;
            this.chkBox_AutoStart.Text = "Auto START";
            this.chkBox_AutoStart.UseVisualStyleBackColor = false;
            // 
            // cbx_City
            // 
            this.cbx_City.FormattingEnabled = true;
            this.cbx_City.ItemHeight = 23;
            this.cbx_City.Location = new System.Drawing.Point(284, 293);
            this.cbx_City.Name = "cbx_City";
            this.cbx_City.Size = new System.Drawing.Size(132, 29);
            this.cbx_City.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbx_City.TabIndex = 18;
            // 
            // chkBox_StartWithWindows
            // 
            this.chkBox_StartWithWindows.AutoSize = true;
            this.chkBox_StartWithWindows.BackColor = System.Drawing.Color.Transparent;
            this.chkBox_StartWithWindows.Location = new System.Drawing.Point(395, 140);
            this.chkBox_StartWithWindows.Name = "chkBox_StartWithWindows";
            this.chkBox_StartWithWindows.Size = new System.Drawing.Size(125, 15);
            this.chkBox_StartWithWindows.Style = MetroFramework.MetroColorStyle.Orange;
            this.chkBox_StartWithWindows.TabIndex = 10;
            this.chkBox_StartWithWindows.Text = "Start with Windows";
            this.chkBox_StartWithWindows.UseVisualStyleBackColor = false;
            // 
            // label_City
            // 
            this.label_City.AutoSize = true;
            this.label_City.BackColor = System.Drawing.Color.Transparent;
            this.label_City.Location = new System.Drawing.Point(284, 271);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(31, 19);
            this.label_City.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_City.TabIndex = 17;
            this.label_City.Text = "City";
            // 
            // label_ApiToken
            // 
            this.label_ApiToken.AutoSize = true;
            this.label_ApiToken.BackColor = System.Drawing.Color.Transparent;
            this.label_ApiToken.Location = new System.Drawing.Point(9, 201);
            this.label_ApiToken.Name = "label_ApiToken";
            this.label_ApiToken.Size = new System.Drawing.Size(66, 19);
            this.label_ApiToken.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_ApiToken.TabIndex = 11;
            this.label_ApiToken.Text = "Api Token";
            // 
            // cbx_State
            // 
            this.cbx_State.FormattingEnabled = true;
            this.cbx_State.ItemHeight = 23;
            this.cbx_State.Location = new System.Drawing.Point(147, 293);
            this.cbx_State.Name = "cbx_State";
            this.cbx_State.Size = new System.Drawing.Size(131, 29);
            this.cbx_State.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbx_State.TabIndex = 16;
            this.cbx_State.DropDown += new System.EventHandler(this.cbx_State_DropDown);
            this.cbx_State.SelectedIndexChanged += new System.EventHandler(this.cbx_State_SelectedIndexChanged);
            this.cbx_State.DropDownClosed += new System.EventHandler(this.cbx_State_DropDownClosed);
            // 
            // txtBx_ApiToken
            // 
            this.txtBx_ApiToken.Location = new System.Drawing.Point(10, 223);
            this.txtBx_ApiToken.Name = "txtBx_ApiToken";
            this.txtBx_ApiToken.Size = new System.Drawing.Size(555, 23);
            this.txtBx_ApiToken.Style = MetroFramework.MetroColorStyle.Orange;
            this.txtBx_ApiToken.TabIndex = 12;
            // 
            // label_State
            // 
            this.label_State.AutoSize = true;
            this.label_State.BackColor = System.Drawing.Color.Transparent;
            this.label_State.Location = new System.Drawing.Point(147, 271);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(38, 19);
            this.label_State.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_State.TabIndex = 15;
            this.label_State.Text = "State";
            // 
            // label_Country
            // 
            this.label_Country.AutoSize = true;
            this.label_Country.BackColor = System.Drawing.Color.Transparent;
            this.label_Country.Location = new System.Drawing.Point(9, 271);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(56, 19);
            this.label_Country.Style = MetroFramework.MetroColorStyle.Orange;
            this.label_Country.TabIndex = 13;
            this.label_Country.Text = "Country";
            // 
            // cbx_Country
            // 
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.ItemHeight = 23;
            this.cbx_Country.Location = new System.Drawing.Point(10, 293);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(131, 29);
            this.cbx_Country.Style = MetroFramework.MetroColorStyle.Orange;
            this.cbx_Country.TabIndex = 14;
            this.cbx_Country.DropDown += new System.EventHandler(this.cbx_Country_DropDown);
            this.cbx_Country.SelectedIndexChanged += new System.EventHandler(this.cbx_Country_SelectedIndexChanged);
            this.cbx_Country.DropDownClosed += new System.EventHandler(this.cbx_Country_DropDownClosed);
            // 
            // StyleManager
            // 
            this.StyleManager.Owner = this;
            this.StyleManager.Style = MetroFramework.MetroColorStyle.Orange;
            this.StyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // WeBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(622, 578);
            this.Controls.Add(this.tabControl_Principal);
            this.Controls.Add(this.label_Powered);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeBe";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Orange;
            this.Text = "WeBe - WeatherVibe";
            this.Resize += new System.EventHandler(this.WeBe_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Weather)).EndInit();
            this.notify_ContextMenu.ResumeLayout(false);
            this.tabControl_Principal.ResumeLayout(false);
            this.tabPage_Home.ResumeLayout(false);
            this.tabPage_Profiles.ResumeLayout(false);
            this.tabPage_Profiles.PerformLayout();
            this.tabPage_Settings.ResumeLayout(false);
            this.tabPage_Settings.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.StyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog WallpaperEngine;
        public System.Windows.Forms.ListBox listBox_Profiles;
        public System.Windows.Forms.NotifyIcon Notify;
        public System.Windows.Forms.ContextMenuStrip notify_ContextMenu;
        public System.Windows.Forms.ToolStripMenuItem context_Stop;
        public System.Windows.Forms.ToolStripMenuItem context_Start;
        public System.Windows.Forms.MaskedTextBox txtBox_SecondHourNight;
        public System.Windows.Forms.MaskedTextBox txtBox_FirstHourNight;
        public System.Windows.Forms.ToolStripMenuItem context_Exit;
        public System.Windows.Forms.PictureBox picBox_Weather;
        public System.Windows.Forms.Label label_Powered;
        public MetroFramework.Controls.MetroButton btn_Stop;
        public MetroFramework.Controls.MetroButton btn_Start;
        public MetroFramework.Controls.MetroLabel label_ActualWeatherHeader;
        public MetroFramework.Controls.MetroButton btn_GetWeather;
        public MetroFramework.Controls.MetroLabel label_RainIntensity;
        public MetroFramework.Controls.MetroLabel label_ActualWeather;
        public MetroFramework.Controls.MetroLabel label_LocationWeather;
        public MetroFramework.Controls.MetroLabel label_Temperature;
        public MetroFramework.Controls.MetroLabel label_SnowIntensity;
        public MetroFramework.Controls.MetroTabPage tabPage_Home;
        public MetroFramework.Controls.MetroTabControl tabControl_Principal;
        public MetroFramework.Controls.MetroTabPage tabPage_Profiles;
        public MetroFramework.Controls.MetroButton btn_Clear;
        public MetroFramework.Controls.MetroButton btn_Add;
        public MetroFramework.Controls.MetroCheckBox chkBox_IsNight;
        public MetroFramework.Controls.MetroTextBox txtBx_ProfileName;
        public MetroFramework.Controls.MetroLabel label_ProfileName;
        public MetroFramework.Controls.MetroCheckBox chkBox_SimplifiedMode;
        public MetroFramework.Controls.MetroComboBox cbx_Weathers;
        public MetroFramework.Controls.MetroLabel label_Weather;
        public MetroFramework.Controls.MetroCheckBox chkBox_StartWithWindows;
        public MetroFramework.Controls.MetroCheckBox chkBox_AutoStart;
        public MetroFramework.Controls.MetroTextBox txtBx_Interval;
        public MetroFramework.Controls.MetroLabel label_Interval;
        public MetroFramework.Controls.MetroCheckBox chkBox_StartMinimized;
        public MetroFramework.Controls.MetroComboBox cbx_Language;
        public MetroFramework.Controls.MetroLabel label_Language;
        public MetroFramework.Controls.MetroLabel label_WallpaperEngineExecutable;
        public MetroFramework.Controls.MetroTextBox txtBx_WallpaperEngineExecutable;
        public MetroFramework.Controls.MetroLabel label_NightInterval;
        public MetroFramework.Controls.MetroLabel label_Until;
        public MetroFramework.Controls.MetroComboBox cbx_City;
        public MetroFramework.Controls.MetroLabel label_City;
        public MetroFramework.Controls.MetroComboBox cbx_State;
        public MetroFramework.Controls.MetroLabel label_State;
        public MetroFramework.Controls.MetroComboBox cbx_Country;
        public MetroFramework.Controls.MetroLabel label_Country;
        public MetroFramework.Controls.MetroTextBox txtBx_ApiToken;
        public MetroFramework.Controls.MetroLabel label_ApiToken;
        public MetroFramework.Controls.MetroButton btn_FindExecutable;
        public MetroFramework.Controls.MetroButton btn_Save;
        public MetroFramework.Controls.MetroLabel label_DarkMode;
        public MetroFramework.Components.MetroStyleManager StyleManager;
        public System.Windows.Forms.ToolStripMenuItem context_Profiles;
        public System.Windows.Forms.ToolStripMenuItem context_Settings;
        public MetroFramework.Controls.MetroTabPage tabPage_Settings;
        public MetroFramework.Controls.MetroToggle toggle_DarkMode;
    }
}

