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
            this.btn_Save = new System.Windows.Forms.Button();
            this.tabControl_Principal = new System.Windows.Forms.TabControl();
            this.Home = new System.Windows.Forms.TabPage();
            this.picBox_Weather = new System.Windows.Forms.PictureBox();
            this.label_ActualWeather = new System.Windows.Forms.Label();
            this.label_ActualWeatherHeader = new System.Windows.Forms.Label();
            this.btn_GetWeather = new System.Windows.Forms.Button();
            this.btn_Stop = new System.Windows.Forms.Button();
            this.btn_Start = new System.Windows.Forms.Button();
            this.Options = new System.Windows.Forms.TabPage();
            this.tabControl_Configuration = new System.Windows.Forms.TabControl();
            this.Profiles = new System.Windows.Forms.TabPage();
            this.chkBox_IsNight = new System.Windows.Forms.CheckBox();
            this.chkBox_SimplifiedMode = new System.Windows.Forms.CheckBox();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.btn_Add = new System.Windows.Forms.Button();
            this.label_Weather = new System.Windows.Forms.Label();
            this.label_ProfileName = new System.Windows.Forms.Label();
            this.txtBx_ProfileName = new System.Windows.Forms.TextBox();
            this.cbx_Weathers = new System.Windows.Forms.ComboBox();
            this.listBox_Profiles = new System.Windows.Forms.ListBox();
            this.Settings = new System.Windows.Forms.TabPage();
            this.chkBox_StartWithWindows = new System.Windows.Forms.CheckBox();
            this.chkBox_AutoStart = new System.Windows.Forms.CheckBox();
            this.chkBox_StartMinimized = new System.Windows.Forms.CheckBox();
            this.txtBox_SecondHourNight = new System.Windows.Forms.MaskedTextBox();
            this.txtBox_FirstHourNight = new System.Windows.Forms.MaskedTextBox();
            this.label_Until = new System.Windows.Forms.Label();
            this.label_NightInterval = new System.Windows.Forms.Label();
            this.label_ApiToken = new System.Windows.Forms.Label();
            this.txtBx_ApiToken = new System.Windows.Forms.TextBox();
            this.txtBx_Interval = new System.Windows.Forms.TextBox();
            this.label_Interval = new System.Windows.Forms.Label();
            this.btn_FindExecutable = new System.Windows.Forms.Button();
            this.label_Language = new System.Windows.Forms.Label();
            this.cbx_Language = new System.Windows.Forms.ComboBox();
            this.label_WallpaperEngineExecutable = new System.Windows.Forms.Label();
            this.txtBx_WallpaperEngineExecutable = new System.Windows.Forms.TextBox();
            this.label_City = new System.Windows.Forms.Label();
            this.cbx_City = new System.Windows.Forms.ComboBox();
            this.label_State = new System.Windows.Forms.Label();
            this.cbx_State = new System.Windows.Forms.ComboBox();
            this.label_Country = new System.Windows.Forms.Label();
            this.cbx_Country = new System.Windows.Forms.ComboBox();
            this.WallpaperEngine = new System.Windows.Forms.OpenFileDialog();
            this.Notify = new System.Windows.Forms.NotifyIcon(this.components);
            this.notify_ContextMenu = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.context_Start = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Stop = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Options = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Profiles = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Settings = new System.Windows.Forms.ToolStripMenuItem();
            this.context_Exit = new System.Windows.Forms.ToolStripMenuItem();
            this.label_Powered = new System.Windows.Forms.Label();
            this.imageList = new System.Windows.Forms.ImageList(this.components);
            this.label_RainIntensity = new System.Windows.Forms.Label();
            this.label_SnowIntensity = new System.Windows.Forms.Label();
            this.label_Temperature = new System.Windows.Forms.Label();
            this.label_LocationWeather = new System.Windows.Forms.Label();
            this.tabControl_Principal.SuspendLayout();
            this.Home.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Weather)).BeginInit();
            this.Options.SuspendLayout();
            this.tabControl_Configuration.SuspendLayout();
            this.Profiles.SuspendLayout();
            this.Settings.SuspendLayout();
            this.notify_ContextMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_Save
            // 
            this.btn_Save.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Save.Location = new System.Drawing.Point(3, 340);
            this.btn_Save.Name = "btn_Save";
            this.btn_Save.Size = new System.Drawing.Size(549, 23);
            this.btn_Save.TabIndex = 2;
            this.btn_Save.Text = "Save";
            this.btn_Save.UseVisualStyleBackColor = true;
            this.btn_Save.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // tabControl_Principal
            // 
            this.tabControl_Principal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Principal.Controls.Add(this.Home);
            this.tabControl_Principal.Controls.Add(this.Options);
            this.tabControl_Principal.Location = new System.Drawing.Point(12, 12);
            this.tabControl_Principal.Name = "tabControl_Principal";
            this.tabControl_Principal.SelectedIndex = 0;
            this.tabControl_Principal.Size = new System.Drawing.Size(583, 430);
            this.tabControl_Principal.TabIndex = 3;
            // 
            // Home
            // 
            this.Home.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Home.Controls.Add(this.label_LocationWeather);
            this.Home.Controls.Add(this.label_Temperature);
            this.Home.Controls.Add(this.label_SnowIntensity);
            this.Home.Controls.Add(this.label_RainIntensity);
            this.Home.Controls.Add(this.picBox_Weather);
            this.Home.Controls.Add(this.label_ActualWeather);
            this.Home.Controls.Add(this.label_ActualWeatherHeader);
            this.Home.Controls.Add(this.btn_GetWeather);
            this.Home.Controls.Add(this.btn_Stop);
            this.Home.Controls.Add(this.btn_Start);
            this.Home.Location = new System.Drawing.Point(4, 22);
            this.Home.Name = "Home";
            this.Home.Padding = new System.Windows.Forms.Padding(3);
            this.Home.Size = new System.Drawing.Size(575, 404);
            this.Home.TabIndex = 0;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = true;
            // 
            // picBox_Weather
            // 
            this.picBox_Weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.picBox_Weather.Image = global::WeBe___WeatherVibe.Properties.Resources.sunny;
            this.picBox_Weather.Location = new System.Drawing.Point(215, 53);
            this.picBox_Weather.Name = "picBox_Weather";
            this.picBox_Weather.Size = new System.Drawing.Size(144, 144);
            this.picBox_Weather.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picBox_Weather.TabIndex = 5;
            this.picBox_Weather.TabStop = false;
            // 
            // label_ActualWeather
            // 
            this.label_ActualWeather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ActualWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ActualWeather.Location = new System.Drawing.Point(9, 206);
            this.label_ActualWeather.Name = "label_ActualWeather";
            this.label_ActualWeather.Size = new System.Drawing.Size(560, 16);
            this.label_ActualWeather.TabIndex = 4;
            this.label_ActualWeather.Text = "Desconhecido";
            this.label_ActualWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ActualWeatherHeader
            // 
            this.label_ActualWeatherHeader.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ActualWeatherHeader.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_ActualWeatherHeader.Location = new System.Drawing.Point(6, 25);
            this.label_ActualWeatherHeader.Name = "label_ActualWeatherHeader";
            this.label_ActualWeatherHeader.Size = new System.Drawing.Size(563, 18);
            this.label_ActualWeatherHeader.TabIndex = 3;
            this.label_ActualWeatherHeader.Text = "Actual Weather";
            this.label_ActualWeatherHeader.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btn_GetWeather
            // 
            this.btn_GetWeather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_GetWeather.Enabled = false;
            this.btn_GetWeather.Location = new System.Drawing.Point(244, 338);
            this.btn_GetWeather.Name = "btn_GetWeather";
            this.btn_GetWeather.Size = new System.Drawing.Size(91, 23);
            this.btn_GetWeather.TabIndex = 2;
            this.btn_GetWeather.Text = "Get Weather";
            this.btn_GetWeather.UseVisualStyleBackColor = true;
            this.btn_GetWeather.Visible = false;
            this.btn_GetWeather.Click += new System.EventHandler(this.btn_GetWeather_Click);
            // 
            // btn_Stop
            // 
            this.btn_Stop.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Stop.Enabled = false;
            this.btn_Stop.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Stop.Location = new System.Drawing.Point(3, 333);
            this.btn_Stop.Name = "btn_Stop";
            this.btn_Stop.Size = new System.Drawing.Size(569, 34);
            this.btn_Stop.TabIndex = 1;
            this.btn_Stop.Text = "STOP";
            this.btn_Stop.UseVisualStyleBackColor = true;
            this.btn_Stop.Visible = false;
            this.btn_Stop.Click += new System.EventHandler(this.btn_Stop_Click);
            // 
            // btn_Start
            // 
            this.btn_Start.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.btn_Start.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Start.Location = new System.Drawing.Point(3, 367);
            this.btn_Start.Name = "btn_Start";
            this.btn_Start.Size = new System.Drawing.Size(569, 34);
            this.btn_Start.TabIndex = 0;
            this.btn_Start.Text = "START";
            this.btn_Start.UseVisualStyleBackColor = true;
            this.btn_Start.Click += new System.EventHandler(this.btn_Start_Click);
            // 
            // Options
            // 
            this.Options.Controls.Add(this.tabControl_Configuration);
            this.Options.Location = new System.Drawing.Point(4, 22);
            this.Options.Name = "Options";
            this.Options.Padding = new System.Windows.Forms.Padding(3);
            this.Options.Size = new System.Drawing.Size(575, 404);
            this.Options.TabIndex = 1;
            this.Options.Text = "Options";
            this.Options.UseVisualStyleBackColor = true;
            // 
            // tabControl_Configuration
            // 
            this.tabControl_Configuration.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControl_Configuration.Controls.Add(this.Profiles);
            this.tabControl_Configuration.Controls.Add(this.Settings);
            this.tabControl_Configuration.Location = new System.Drawing.Point(6, 6);
            this.tabControl_Configuration.Name = "tabControl_Configuration";
            this.tabControl_Configuration.SelectedIndex = 0;
            this.tabControl_Configuration.Size = new System.Drawing.Size(563, 392);
            this.tabControl_Configuration.TabIndex = 0;
            // 
            // Profiles
            // 
            this.Profiles.Controls.Add(this.chkBox_IsNight);
            this.Profiles.Controls.Add(this.chkBox_SimplifiedMode);
            this.Profiles.Controls.Add(this.btn_Clear);
            this.Profiles.Controls.Add(this.btn_Add);
            this.Profiles.Controls.Add(this.label_Weather);
            this.Profiles.Controls.Add(this.label_ProfileName);
            this.Profiles.Controls.Add(this.txtBx_ProfileName);
            this.Profiles.Controls.Add(this.cbx_Weathers);
            this.Profiles.Controls.Add(this.listBox_Profiles);
            this.Profiles.Location = new System.Drawing.Point(4, 22);
            this.Profiles.Name = "Profiles";
            this.Profiles.Padding = new System.Windows.Forms.Padding(3);
            this.Profiles.Size = new System.Drawing.Size(555, 366);
            this.Profiles.TabIndex = 0;
            this.Profiles.Text = "Profiles";
            this.Profiles.UseVisualStyleBackColor = true;
            // 
            // chkBox_IsNight
            // 
            this.chkBox_IsNight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_IsNight.AutoSize = true;
            this.chkBox_IsNight.Location = new System.Drawing.Point(365, 155);
            this.chkBox_IsNight.Name = "chkBox_IsNight";
            this.chkBox_IsNight.Size = new System.Drawing.Size(83, 17);
            this.chkBox_IsNight.TabIndex = 9;
            this.chkBox_IsNight.Text = "Night Profile";
            this.chkBox_IsNight.UseVisualStyleBackColor = true;
            this.chkBox_IsNight.CheckStateChanged += new System.EventHandler(this.chkBox_IsNight_CheckStateChanged);
            // 
            // chkBox_SimplifiedMode
            // 
            this.chkBox_SimplifiedMode.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_SimplifiedMode.AutoSize = true;
            this.chkBox_SimplifiedMode.Location = new System.Drawing.Point(365, 91);
            this.chkBox_SimplifiedMode.Name = "chkBox_SimplifiedMode";
            this.chkBox_SimplifiedMode.Size = new System.Drawing.Size(100, 17);
            this.chkBox_SimplifiedMode.TabIndex = 7;
            this.chkBox_SimplifiedMode.Text = "Simplified Mode";
            this.chkBox_SimplifiedMode.UseVisualStyleBackColor = true;
            this.chkBox_SimplifiedMode.Click += new System.EventHandler(this.btn_Save_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_Clear.Location = new System.Drawing.Point(6, 331);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(164, 23);
            this.btn_Clear.TabIndex = 6;
            this.btn_Clear.Text = "Clear";
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Clear_Click);
            // 
            // btn_Add
            // 
            this.btn_Add.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_Add.Location = new System.Drawing.Point(265, 198);
            this.btn_Add.Name = "btn_Add";
            this.btn_Add.Size = new System.Drawing.Size(211, 23);
            this.btn_Add.TabIndex = 5;
            this.btn_Add.Text = "Add";
            this.btn_Add.UseVisualStyleBackColor = true;
            this.btn_Add.Click += new System.EventHandler(this.btn_Add_Click);
            // 
            // label_Weather
            // 
            this.label_Weather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Weather.AutoSize = true;
            this.label_Weather.Location = new System.Drawing.Point(263, 92);
            this.label_Weather.Name = "label_Weather";
            this.label_Weather.Size = new System.Drawing.Size(48, 13);
            this.label_Weather.TabIndex = 4;
            this.label_Weather.Text = "Weather";
            // 
            // label_ProfileName
            // 
            this.label_ProfileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ProfileName.AutoSize = true;
            this.label_ProfileName.Location = new System.Drawing.Point(264, 156);
            this.label_ProfileName.Name = "label_ProfileName";
            this.label_ProfileName.Size = new System.Drawing.Size(67, 13);
            this.label_ProfileName.TabIndex = 3;
            this.label_ProfileName.Text = "Profile Name";
            // 
            // txtBx_ProfileName
            // 
            this.txtBx_ProfileName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBx_ProfileName.Location = new System.Drawing.Point(266, 172);
            this.txtBx_ProfileName.Name = "txtBx_ProfileName";
            this.txtBx_ProfileName.Size = new System.Drawing.Size(210, 20);
            this.txtBx_ProfileName.TabIndex = 2;
            // 
            // cbx_Weathers
            // 
            this.cbx_Weathers.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_Weathers.FormattingEnabled = true;
            this.cbx_Weathers.Location = new System.Drawing.Point(265, 108);
            this.cbx_Weathers.Name = "cbx_Weathers";
            this.cbx_Weathers.Size = new System.Drawing.Size(211, 21);
            this.cbx_Weathers.TabIndex = 1;
            this.cbx_Weathers.SelectedIndexChanged += new System.EventHandler(this.cbx_Weathers_SelectedIndexChanged);
            // 
            // listBox_Profiles
            // 
            this.listBox_Profiles.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.listBox_Profiles.FormattingEnabled = true;
            this.listBox_Profiles.Location = new System.Drawing.Point(6, 6);
            this.listBox_Profiles.Name = "listBox_Profiles";
            this.listBox_Profiles.Size = new System.Drawing.Size(164, 316);
            this.listBox_Profiles.TabIndex = 0;
            this.listBox_Profiles.KeyDown += new System.Windows.Forms.KeyEventHandler(this.listBox_Profiles_KeyDown);
            // 
            // Settings
            // 
            this.Settings.Controls.Add(this.chkBox_StartWithWindows);
            this.Settings.Controls.Add(this.chkBox_AutoStart);
            this.Settings.Controls.Add(this.chkBox_StartMinimized);
            this.Settings.Controls.Add(this.txtBox_SecondHourNight);
            this.Settings.Controls.Add(this.txtBox_FirstHourNight);
            this.Settings.Controls.Add(this.label_Until);
            this.Settings.Controls.Add(this.label_NightInterval);
            this.Settings.Controls.Add(this.label_ApiToken);
            this.Settings.Controls.Add(this.txtBx_ApiToken);
            this.Settings.Controls.Add(this.txtBx_Interval);
            this.Settings.Controls.Add(this.label_Interval);
            this.Settings.Controls.Add(this.btn_FindExecutable);
            this.Settings.Controls.Add(this.label_Language);
            this.Settings.Controls.Add(this.cbx_Language);
            this.Settings.Controls.Add(this.label_WallpaperEngineExecutable);
            this.Settings.Controls.Add(this.txtBx_WallpaperEngineExecutable);
            this.Settings.Controls.Add(this.label_City);
            this.Settings.Controls.Add(this.cbx_City);
            this.Settings.Controls.Add(this.label_State);
            this.Settings.Controls.Add(this.cbx_State);
            this.Settings.Controls.Add(this.label_Country);
            this.Settings.Controls.Add(this.cbx_Country);
            this.Settings.Controls.Add(this.btn_Save);
            this.Settings.Location = new System.Drawing.Point(4, 22);
            this.Settings.Name = "Settings";
            this.Settings.Padding = new System.Windows.Forms.Padding(3);
            this.Settings.Size = new System.Drawing.Size(555, 366);
            this.Settings.TabIndex = 1;
            this.Settings.Text = "Settings";
            this.Settings.UseVisualStyleBackColor = true;
            // 
            // chkBox_StartWithWindows
            // 
            this.chkBox_StartWithWindows.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_StartWithWindows.AutoSize = true;
            this.chkBox_StartWithWindows.Location = new System.Drawing.Point(221, 145);
            this.chkBox_StartWithWindows.Name = "chkBox_StartWithWindows";
            this.chkBox_StartWithWindows.Size = new System.Drawing.Size(117, 17);
            this.chkBox_StartWithWindows.TabIndex = 26;
            this.chkBox_StartWithWindows.Text = "Start with Windows";
            this.chkBox_StartWithWindows.UseVisualStyleBackColor = true;
            // 
            // chkBox_AutoStart
            // 
            this.chkBox_AutoStart.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_AutoStart.AutoSize = true;
            this.chkBox_AutoStart.Location = new System.Drawing.Point(221, 122);
            this.chkBox_AutoStart.Name = "chkBox_AutoStart";
            this.chkBox_AutoStart.Size = new System.Drawing.Size(87, 17);
            this.chkBox_AutoStart.TabIndex = 25;
            this.chkBox_AutoStart.Text = "Auto START";
            this.chkBox_AutoStart.UseVisualStyleBackColor = true;
            // 
            // chkBox_StartMinimized
            // 
            this.chkBox_StartMinimized.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.chkBox_StartMinimized.AutoSize = true;
            this.chkBox_StartMinimized.Location = new System.Drawing.Point(221, 98);
            this.chkBox_StartMinimized.Name = "chkBox_StartMinimized";
            this.chkBox_StartMinimized.Size = new System.Drawing.Size(97, 17);
            this.chkBox_StartMinimized.TabIndex = 24;
            this.chkBox_StartMinimized.Text = "Start Minimized";
            this.chkBox_StartMinimized.UseVisualStyleBackColor = true;
            // 
            // txtBox_SecondHourNight
            // 
            this.txtBox_SecondHourNight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_SecondHourNight.Location = new System.Drawing.Point(510, 237);
            this.txtBox_SecondHourNight.Mask = "00:00";
            this.txtBox_SecondHourNight.Name = "txtBox_SecondHourNight";
            this.txtBox_SecondHourNight.Size = new System.Drawing.Size(33, 20);
            this.txtBox_SecondHourNight.TabIndex = 23;
            this.txtBox_SecondHourNight.ValidatingType = typeof(System.DateTime);
            // 
            // txtBox_FirstHourNight
            // 
            this.txtBox_FirstHourNight.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBox_FirstHourNight.Location = new System.Drawing.Point(436, 237);
            this.txtBox_FirstHourNight.Mask = "00:00";
            this.txtBox_FirstHourNight.Name = "txtBox_FirstHourNight";
            this.txtBox_FirstHourNight.Size = new System.Drawing.Size(33, 20);
            this.txtBox_FirstHourNight.TabIndex = 22;
            this.txtBox_FirstHourNight.ValidatingType = typeof(System.DateTime);
            // 
            // label_Until
            // 
            this.label_Until.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Until.AutoSize = true;
            this.label_Until.Location = new System.Drawing.Point(476, 240);
            this.label_Until.Name = "label_Until";
            this.label_Until.Size = new System.Drawing.Size(28, 13);
            this.label_Until.TabIndex = 21;
            this.label_Until.Text = "Until";
            // 
            // label_NightInterval
            // 
            this.label_NightInterval.Location = new System.Drawing.Point(436, 220);
            this.label_NightInterval.Name = "label_NightInterval";
            this.label_NightInterval.Size = new System.Drawing.Size(107, 14);
            this.label_NightInterval.TabIndex = 18;
            this.label_NightInterval.Text = "Night Interval";
            this.label_NightInterval.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_ApiToken
            // 
            this.label_ApiToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_ApiToken.AutoSize = true;
            this.label_ApiToken.Location = new System.Drawing.Point(6, 156);
            this.label_ApiToken.Name = "label_ApiToken";
            this.label_ApiToken.Size = new System.Drawing.Size(56, 13);
            this.label_ApiToken.TabIndex = 17;
            this.label_ApiToken.Text = "Api Token";
            // 
            // txtBx_ApiToken
            // 
            this.txtBx_ApiToken.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBx_ApiToken.Location = new System.Drawing.Point(6, 172);
            this.txtBx_ApiToken.Name = "txtBx_ApiToken";
            this.txtBx_ApiToken.Size = new System.Drawing.Size(541, 20);
            this.txtBx_ApiToken.TabIndex = 16;
            // 
            // txtBx_Interval
            // 
            this.txtBx_Interval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBx_Interval.Location = new System.Drawing.Point(412, 119);
            this.txtBx_Interval.Name = "txtBx_Interval";
            this.txtBx_Interval.Size = new System.Drawing.Size(135, 20);
            this.txtBx_Interval.TabIndex = 15;
            this.txtBx_Interval.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label_Interval
            // 
            this.label_Interval.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Interval.AutoSize = true;
            this.label_Interval.Location = new System.Drawing.Point(409, 102);
            this.label_Interval.Name = "label_Interval";
            this.label_Interval.Size = new System.Drawing.Size(92, 13);
            this.label_Interval.TabIndex = 14;
            this.label_Interval.Text = "Execution Interval";
            // 
            // btn_FindExecutable
            // 
            this.btn_FindExecutable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_FindExecutable.Location = new System.Drawing.Point(6, 64);
            this.btn_FindExecutable.Name = "btn_FindExecutable";
            this.btn_FindExecutable.Size = new System.Drawing.Size(541, 23);
            this.btn_FindExecutable.TabIndex = 13;
            this.btn_FindExecutable.Text = "Find Executable";
            this.btn_FindExecutable.UseVisualStyleBackColor = true;
            this.btn_FindExecutable.Click += new System.EventHandler(this.btn_FindExecutable_Click);
            // 
            // label_Language
            // 
            this.label_Language.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Language.AutoSize = true;
            this.label_Language.Location = new System.Drawing.Point(6, 102);
            this.label_Language.Name = "label_Language";
            this.label_Language.Size = new System.Drawing.Size(55, 13);
            this.label_Language.TabIndex = 12;
            this.label_Language.Text = "Language";
            // 
            // cbx_Language
            // 
            this.cbx_Language.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_Language.FormattingEnabled = true;
            this.cbx_Language.Location = new System.Drawing.Point(8, 118);
            this.cbx_Language.Name = "cbx_Language";
            this.cbx_Language.Size = new System.Drawing.Size(136, 21);
            this.cbx_Language.TabIndex = 11;
            this.cbx_Language.DropDown += new System.EventHandler(this.cbx_Language_DropDown);
            // 
            // label_WallpaperEngineExecutable
            // 
            this.label_WallpaperEngineExecutable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_WallpaperEngineExecutable.AutoSize = true;
            this.label_WallpaperEngineExecutable.Location = new System.Drawing.Point(6, 22);
            this.label_WallpaperEngineExecutable.Name = "label_WallpaperEngineExecutable";
            this.label_WallpaperEngineExecutable.Size = new System.Drawing.Size(147, 13);
            this.label_WallpaperEngineExecutable.TabIndex = 10;
            this.label_WallpaperEngineExecutable.Text = "Wallpaper Engine Executable";
            // 
            // txtBx_WallpaperEngineExecutable
            // 
            this.txtBx_WallpaperEngineExecutable.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtBx_WallpaperEngineExecutable.Location = new System.Drawing.Point(6, 38);
            this.txtBx_WallpaperEngineExecutable.Name = "txtBx_WallpaperEngineExecutable";
            this.txtBx_WallpaperEngineExecutable.Size = new System.Drawing.Size(541, 20);
            this.txtBx_WallpaperEngineExecutable.TabIndex = 9;
            // 
            // label_City
            // 
            this.label_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_City.AutoSize = true;
            this.label_City.Location = new System.Drawing.Point(291, 220);
            this.label_City.Name = "label_City";
            this.label_City.Size = new System.Drawing.Size(24, 13);
            this.label_City.TabIndex = 8;
            this.label_City.Text = "City";
            // 
            // cbx_City
            // 
            this.cbx_City.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_City.FormattingEnabled = true;
            this.cbx_City.Location = new System.Drawing.Point(290, 236);
            this.cbx_City.Name = "cbx_City";
            this.cbx_City.Size = new System.Drawing.Size(136, 21);
            this.cbx_City.TabIndex = 7;
            // 
            // label_State
            // 
            this.label_State.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_State.AutoSize = true;
            this.label_State.Location = new System.Drawing.Point(148, 220);
            this.label_State.Name = "label_State";
            this.label_State.Size = new System.Drawing.Size(32, 13);
            this.label_State.TabIndex = 6;
            this.label_State.Text = "State";
            // 
            // cbx_State
            // 
            this.cbx_State.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_State.FormattingEnabled = true;
            this.cbx_State.Location = new System.Drawing.Point(148, 236);
            this.cbx_State.Name = "cbx_State";
            this.cbx_State.Size = new System.Drawing.Size(136, 21);
            this.cbx_State.TabIndex = 5;
            this.cbx_State.DropDown += new System.EventHandler(this.cbx_State_DropDown);
            this.cbx_State.SelectedIndexChanged += new System.EventHandler(this.cbx_State_SelectedIndexChanged);
            this.cbx_State.DropDownClosed += new System.EventHandler(this.cbx_State_DropDownClosed);
            // 
            // label_Country
            // 
            this.label_Country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Country.AutoSize = true;
            this.label_Country.Location = new System.Drawing.Point(6, 220);
            this.label_Country.Name = "label_Country";
            this.label_Country.Size = new System.Drawing.Size(43, 13);
            this.label_Country.TabIndex = 4;
            this.label_Country.Text = "Country";
            // 
            // cbx_Country
            // 
            this.cbx_Country.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.cbx_Country.FormattingEnabled = true;
            this.cbx_Country.Location = new System.Drawing.Point(6, 236);
            this.cbx_Country.Name = "cbx_Country";
            this.cbx_Country.Size = new System.Drawing.Size(136, 21);
            this.cbx_Country.TabIndex = 3;
            this.cbx_Country.DropDown += new System.EventHandler(this.cbx_Country_DropDown);
            this.cbx_Country.SelectedIndexChanged += new System.EventHandler(this.cbx_Country_SelectedIndexChanged);
            this.cbx_Country.DropDownClosed += new System.EventHandler(this.cbx_Country_DropDownClosed);
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
            this.context_Options,
            this.context_Exit});
            this.notify_ContextMenu.Name = "notify_ContextMenu";
            this.notify_ContextMenu.Size = new System.Drawing.Size(117, 92);
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
            // context_Options
            // 
            this.context_Options.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.context_Profiles,
            this.context_Settings});
            this.context_Options.Name = "context_Options";
            this.context_Options.Size = new System.Drawing.Size(116, 22);
            this.context_Options.Text = "Options";
            this.context_Options.Click += new System.EventHandler(this.context_Options_Click);
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
            this.label_Powered.Location = new System.Drawing.Point(16, 438);
            this.label_Powered.Name = "label_Powered";
            this.label_Powered.Size = new System.Drawing.Size(575, 13);
            this.label_Powered.TabIndex = 5;
            this.label_Powered.Text = "Icons and API powered by Tomorrow.io";
            this.label_Powered.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // imageList
            // 
            this.imageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList.ImageStream")));
            this.imageList.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList.Images.SetKeyName(0, "10000_clear_large@2x.png");
            this.imageList.Images.SetKeyName(1, "10001_clear_large@2x.png");
            this.imageList.Images.SetKeyName(2, "10010_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(3, "11000_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(4, "11001_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(5, "11010_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(6, "11011_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(7, "11020_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(8, "11021_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(9, "11030_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(10, "11031_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(11, "20000_fog_large@2x.png");
            this.imageList.Images.SetKeyName(12, "21000_fog_light_large@2x.png");
            this.imageList.Images.SetKeyName(13, "21010_fog_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(14, "21011_fog_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(15, "21020_fog_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(16, "21021_fog_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(17, "21030_fog_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(18, "21031_fog_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(19, "21060_fog_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(20, "21061_fog_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(21, "21070_fog_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(22, "21071_fog_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(23, "21080_fog_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(24, "21081_fog_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(25, "40000_drizzle_large@2x.png");
            this.imageList.Images.SetKeyName(26, "40010_rain_large@2x.png");
            this.imageList.Images.SetKeyName(27, "42000_rain_light_large@2x.png");
            this.imageList.Images.SetKeyName(28, "42010_rain_heavy_large@2x.png");
            this.imageList.Images.SetKeyName(29, "42020_rain_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(30, "42021_rain_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(31, "42030_drizzle_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(32, "42031_drizzle_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(33, "42040_drizzle_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(34, "42041_drizzle_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(35, "42050_drizzle_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(36, "42051_drizzle_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(37, "42080_rain_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(38, "42081_rain_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(39, "42090_rain_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(40, "42091_rain_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(41, "42100_rain_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(42, "42101_rain_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(43, "42110_rain_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(44, "42111_rain_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(45, "42120_rain_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(46, "42121_rain_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(47, "42130_rain_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(48, "42131_rain_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(49, "42140_rain_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(50, "42141_rain_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(51, "42150_rain_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(52, "42151_rain_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(53, "50000_snow_large@2x.png");
            this.imageList.Images.SetKeyName(54, "50010_flurries_large@2x.png");
            this.imageList.Images.SetKeyName(55, "51000_snow_light_large@2x.png");
            this.imageList.Images.SetKeyName(56, "51010_snow_heavy_large@2x.png");
            this.imageList.Images.SetKeyName(57, "51020_snow_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(58, "51021_snow_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(59, "51030_snow_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(60, "51031_snow_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(61, "51040_snow_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(62, "51041_snow_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(63, "51050_snow_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(64, "51051_snow_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(65, "51060_snow_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(66, "51061_snow_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(67, "51070_snow_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(68, "51071_snow_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(69, "51080_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(70, "51100_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(71, "51120_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(72, "51140_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(73, "51150_flurries_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(74, "51151_flurries_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(75, "51160_flurries_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(76, "51161_flurries_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(77, "51170_flurries_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(78, "51171_flurries_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(79, "51190_snow_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(80, "51191_snow_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(81, "51200_snow_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(82, "51201_snow_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(83, "51210_snow_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(84, "51211_snow_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(85, "51220_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(86, "60000_freezing_rain_drizzle_large@2x.png");
            this.imageList.Images.SetKeyName(87, "60010_freezing_rain_large@2x.png");
            this.imageList.Images.SetKeyName(88, "60020_freezing_rain_drizzle_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(89, "60021_freezing_rain_drizzle_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(90, "60030_freezing_rain_drizzle_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(91, "60031_freezing_rain_drizzle_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(92, "60040_freezing_rain_drizzle_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(93, "60041_freezing_rain_drizzle_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(94, "62000_freezing_rain_light_large@2x.png");
            this.imageList.Images.SetKeyName(95, "62010_freezing_rain_heavy_large@2x.png");
            this.imageList.Images.SetKeyName(96, "62020_freezing_rain_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(97, "62021_freezing_rain_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(98, "62030_freezing_rain_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(99, "62031_freezing_rain_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(100, "62040_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(101, "62050_freezing_rain_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(102, "62051_freezing_rain_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(103, "62060_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(104, "62070_freezing_rain_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(105, "62071_freezing_rain_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(106, "62080_freezing_rain_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(107, "62081_freezing_rain_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(108, "62090_freezing_rain_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(109, "62091_freezing_rain_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(110, "62120_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(111, "62130_freezing_rain_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(112, "62131_freezing_rain_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(113, "62140_freezing_rain_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(114, "62141_freezing_rain_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(115, "62150_freezing_rain_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(116, "62151_freezing_rain_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(117, "62200_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(118, "62220_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(119, "70000_ice_pellets_large@2x.png");
            this.imageList.Images.SetKeyName(120, "71010_ice_pellets_heavy_large@2x.png");
            this.imageList.Images.SetKeyName(121, "71020_ice_pellets_light_large@2x.png");
            this.imageList.Images.SetKeyName(122, "71030_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(123, "71050_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(124, "71060_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(125, "71070_ice_pellets_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(126, "71071_ice_pellets_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(127, "71080_ice_pellets_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(128, "71081_ice_pellets_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(129, "71090_ice_pellets_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(130, "71091_ice_pellets_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(131, "71100_ice_pellets_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(132, "71101_ice_pellets_light_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(133, "71110_ice_pellets_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(134, "71111_ice_pellets_light_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(135, "71120_ice_pellets_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(136, "71121_ice_pellets_light_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(137, "71130_ice_pellets_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(138, "71131_ice_pellets_heavy_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(139, "71140_ice_pellets_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(140, "71141_ice_pellets_heavy_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(141, "71150_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(142, "71160_ice_pellets_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(143, "71161_ice_pellets_heavy_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(144, "71170_wintry_mix_large@2x.png");
            this.imageList.Images.SetKeyName(145, "80000_tstorm_large@2x.png");
            this.imageList.Images.SetKeyName(146, "80010_tstorm_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(147, "80011_tstorm_mostly_clear_large@2x.png");
            this.imageList.Images.SetKeyName(148, "80020_tstorm_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(149, "80021_tstorm_mostly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(150, "80030_tstorm_partly_cloudy_large@2x.png");
            this.imageList.Images.SetKeyName(151, "80031_tstorm_partly_cloudy_large@2x.png");
            // 
            // label_RainIntensity
            // 
            this.label_RainIntensity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_RainIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_RainIntensity.Location = new System.Drawing.Point(9, 228);
            this.label_RainIntensity.Name = "label_RainIntensity";
            this.label_RainIntensity.Size = new System.Drawing.Size(560, 16);
            this.label_RainIntensity.TabIndex = 6;
            this.label_RainIntensity.Text = "Rain Intensity: 0";
            this.label_RainIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_SnowIntensity
            // 
            this.label_SnowIntensity.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_SnowIntensity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_SnowIntensity.Location = new System.Drawing.Point(9, 244);
            this.label_SnowIntensity.Name = "label_SnowIntensity";
            this.label_SnowIntensity.Size = new System.Drawing.Size(560, 16);
            this.label_SnowIntensity.TabIndex = 7;
            this.label_SnowIntensity.Text = "Snow Intensity: 0";
            this.label_SnowIntensity.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_Temperature
            // 
            this.label_Temperature.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_Temperature.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Temperature.Location = new System.Drawing.Point(9, 259);
            this.label_Temperature.Name = "label_Temperature";
            this.label_Temperature.Size = new System.Drawing.Size(560, 16);
            this.label_Temperature.TabIndex = 8;
            this.label_Temperature.Text = "Temperature: 0";
            this.label_Temperature.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label_LocationWeather
            // 
            this.label_LocationWeather.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label_LocationWeather.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_LocationWeather.Location = new System.Drawing.Point(9, 285);
            this.label_LocationWeather.Name = "label_LocationWeather";
            this.label_LocationWeather.Size = new System.Drawing.Size(560, 44);
            this.label_LocationWeather.TabIndex = 9;
            this.label_LocationWeather.Text = "Desconhecido";
            this.label_LocationWeather.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WeBe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 453);
            this.Controls.Add(this.label_Powered);
            this.Controls.Add(this.tabControl_Principal);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "WeBe";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WeBe - WeatherVibe";
            this.Deactivate += new System.EventHandler(this.WeBe_Deactivate);
            this.tabControl_Principal.ResumeLayout(false);
            this.Home.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.picBox_Weather)).EndInit();
            this.Options.ResumeLayout(false);
            this.tabControl_Configuration.ResumeLayout(false);
            this.Profiles.ResumeLayout(false);
            this.Profiles.PerformLayout();
            this.Settings.ResumeLayout(false);
            this.Settings.PerformLayout();
            this.notify_ContextMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TabPage Home;
        private System.Windows.Forms.TabPage Options;
        private System.Windows.Forms.TabPage Profiles;
        private System.Windows.Forms.TabPage Settings;
        public System.Windows.Forms.ComboBox cbx_Country;
        public System.Windows.Forms.ComboBox cbx_State;
        public System.Windows.Forms.ComboBox cbx_City;
        public System.Windows.Forms.Label label_City;
        public System.Windows.Forms.Label label_State;
        public System.Windows.Forms.Label label_Country;
        public System.Windows.Forms.Button btn_Save;
        public System.Windows.Forms.Label label_WallpaperEngineExecutable;
        public System.Windows.Forms.TextBox txtBx_WallpaperEngineExecutable;
        public System.Windows.Forms.Label label_Language;
        public System.Windows.Forms.ComboBox cbx_Language;
        private System.Windows.Forms.OpenFileDialog WallpaperEngine;
        public System.Windows.Forms.Button btn_FindExecutable;
        public System.Windows.Forms.TabControl tabControl_Principal;
        public System.Windows.Forms.TabControl tabControl_Configuration;
        public System.Windows.Forms.Button btn_Start;
        public System.Windows.Forms.Button btn_Stop;
        public System.Windows.Forms.Label label_Interval;
        public System.Windows.Forms.TextBox txtBx_Interval;
        public System.Windows.Forms.ComboBox cbx_Weathers;
        public System.Windows.Forms.Label label_Weather;
        public System.Windows.Forms.Label label_ProfileName;
        public System.Windows.Forms.TextBox txtBx_ProfileName;
        public System.Windows.Forms.Button btn_Add;
        public System.Windows.Forms.ListBox listBox_Profiles;
        public System.Windows.Forms.Button btn_Clear;
        public System.Windows.Forms.Label label_ActualWeather;
        public System.Windows.Forms.Label label_ActualWeatherHeader;
        public System.Windows.Forms.Button btn_GetWeather;
        public System.Windows.Forms.Label label_ApiToken;
        public System.Windows.Forms.TextBox txtBx_ApiToken;
        public System.Windows.Forms.NotifyIcon Notify;
        public System.Windows.Forms.ContextMenuStrip notify_ContextMenu;
        public System.Windows.Forms.ToolStripMenuItem context_Stop;
        public System.Windows.Forms.ToolStripMenuItem context_Start;
        public System.Windows.Forms.CheckBox chkBox_SimplifiedMode;
        public System.Windows.Forms.CheckBox chkBox_IsNight;
        public System.Windows.Forms.Label label_NightInterval;
        public System.Windows.Forms.Label label_Until;
        public System.Windows.Forms.MaskedTextBox txtBox_SecondHourNight;
        public System.Windows.Forms.MaskedTextBox txtBox_FirstHourNight;
        public System.Windows.Forms.ToolStripMenuItem context_Options;
        public System.Windows.Forms.ToolStripMenuItem context_Profiles;
        public System.Windows.Forms.ToolStripMenuItem context_Settings;
        public System.Windows.Forms.CheckBox chkBox_StartMinimized;
        public System.Windows.Forms.CheckBox chkBox_StartWithWindows;
        public System.Windows.Forms.CheckBox chkBox_AutoStart;
        public System.Windows.Forms.ToolStripMenuItem context_Exit;
        public System.Windows.Forms.ImageList imageList;
        public System.Windows.Forms.PictureBox picBox_Weather;
        public System.Windows.Forms.Label label_Powered;
        public System.Windows.Forms.Label label_RainIntensity;
        public System.Windows.Forms.Label label_LocationWeather;
        public System.Windows.Forms.Label label_Temperature;
        public System.Windows.Forms.Label label_SnowIntensity;
    }
}

