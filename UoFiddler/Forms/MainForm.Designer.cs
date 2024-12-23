/***************************************************************************
 *
 * $Author: Turley
 * 
 * "THE BEER-WARE LICENSE"
 * As long as you retain this notice you can do whatever you want with 
 * this stuff. If we meet some day, and you think this stuff is worth it,
 * you can buy me a beer in return.
 *
 ***************************************************************************/

using UoFiddler.Controls.UserControls;

namespace UoFiddler.Forms
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            TabPanel = new System.Windows.Forms.TabControl();
            contextMenuStripMainForm = new System.Windows.Forms.ContextMenuStrip(components);
            UnDockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            SwitchLogoImageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripComboBoxImage = new System.Windows.Forms.ToolStripComboBox();
            ColorBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ResetBackgroundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            ultimaOnlineDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            DirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            TempDirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            NotesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            ScreenshotToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            soundPlayToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            stopSoundToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            newDirLoadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            StartTab = new System.Windows.Forms.TabPage();
            Versionlabel = new System.Windows.Forms.Label();
            MultisTab = new System.Windows.Forms.TabPage();
            multisControl = new MultisControl();
            AnimationTab = new System.Windows.Forms.TabPage();
            animationsControl = new AnimationListControl();
            ItemsTab = new System.Windows.Forms.TabPage();
            LandTilesTab = new System.Windows.Forms.TabPage();
            landTilesControl = new LandTilesControl();
            TextureTab = new System.Windows.Forms.TabPage();
            textureControl = new TexturesControl();
            GumpsTab = new System.Windows.Forms.TabPage();
            gumpsControl = new GumpControl();
            SoundsTab = new System.Windows.Forms.TabPage();
            soundControl = new SoundsControl();
            HuesTab = new System.Windows.Forms.TabPage();
            hueControl = new HuesControl();
            FontsTab = new System.Windows.Forms.TabPage();
            fontsControl = new FontsControl();
            ClilocTab = new System.Windows.Forms.TabPage();
            clilocControl = new ClilocControl();
            MapTab = new System.Windows.Forms.TabPage();
            mapControl = new MapControl();
            LightTab = new System.Windows.Forms.TabPage();
            lightControl = new LightControl();
            SpeechTab = new System.Windows.Forms.TabPage();
            speechControl = new SpeechControl();
            SkillsTab = new System.Windows.Forms.TabPage();
            skillsControl = new SkillsControl();
            AnimDataTab = new System.Windows.Forms.TabPage();
            animdataControl = new AnimDataControl();
            MultiMapTab = new System.Windows.Forms.TabPage();
            multimapControl = new MultiMapControl();
            DressTab = new System.Windows.Forms.TabPage();
            dressControl = new DressControl();
            TileDataTab = new System.Windows.Forms.TabPage();
            RadarColTab = new System.Windows.Forms.TabPage();
            radarColControl = new RadarColorControl();
            SkillGrpTab = new System.Windows.Forms.TabPage();
            skillGroupControl = new SkillGroupControl();
            toolTip = new System.Windows.Forms.ToolTip(components);
            tsMainMenu = new System.Windows.Forms.ToolStrip();
            SettingsMenu = new System.Windows.Forms.ToolStripDropDownButton();
            AlwaysOnTopMenuitem = new System.Windows.Forms.ToolStripMenuItem();
            optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            pathSettingsMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            tsSettingsSeparator = new System.Windows.Forms.ToolStripSeparator();
            reloadFilesMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripDropDownButtonView = new System.Windows.Forms.ToolStripDropDownButton();
            ToggleViewStart = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewMulti = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewAnimations = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewItems = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewLandTiles = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewTexture = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewGumps = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewSounds = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewHue = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewFonts = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewCliloc = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewMap = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewLight = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewSpeech = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewSkills = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewAnimData = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewMultiMap = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewDress = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewTileData = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewRadarColor = new System.Windows.Forms.ToolStripMenuItem();
            ToggleViewSkillGrp = new System.Windows.Forms.ToolStripMenuItem();
            ExternToolsDropDown = new System.Windows.Forms.ToolStripDropDownButton();
            manageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripDropDownButtonPlugins = new System.Windows.Forms.ToolStripDropDownButton();
            manageToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            tsPluginsSeparator = new System.Windows.Forms.ToolStripSeparator();
            toolStripDropDownButtonHelp = new System.Windows.Forms.ToolStripDropDownButton();
            toolStripMenuItemHelp = new System.Windows.Forms.ToolStripMenuItem();
            fileFormatGermanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            fileFormatGermanToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            fileFormatEnglischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            animationsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            animationInstallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            animationInstallEnglischToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            binaryDecimalHexadecimalConverterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            convertLineToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            alarmClockToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            calendarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            notPadToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItemAbout = new System.Windows.Forms.ToolStripMenuItem();
            changelogToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            ToolStripMenuItemDiscordUO = new System.Windows.Forms.ToolStripMenuItem();
            ToolStripMenuItemDiscordUoFreeshardsDe = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItemLinks = new System.Windows.Forms.ToolStripMenuItem();
            uodevuofreeshardsdeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            toolStripMenuItemLink3 = new System.Windows.Forms.ToolStripMenuItem();
            TabPanel.SuspendLayout();
            contextMenuStripMainForm.SuspendLayout();
            StartTab.SuspendLayout();
            MultisTab.SuspendLayout();
            AnimationTab.SuspendLayout();
            LandTilesTab.SuspendLayout();
            TextureTab.SuspendLayout();
            GumpsTab.SuspendLayout();
            SoundsTab.SuspendLayout();
            HuesTab.SuspendLayout();
            FontsTab.SuspendLayout();
            ClilocTab.SuspendLayout();
            MapTab.SuspendLayout();
            LightTab.SuspendLayout();
            SpeechTab.SuspendLayout();
            SkillsTab.SuspendLayout();
            AnimDataTab.SuspendLayout();
            MultiMapTab.SuspendLayout();
            DressTab.SuspendLayout();
            RadarColTab.SuspendLayout();
            SkillGrpTab.SuspendLayout();
            tsMainMenu.SuspendLayout();
            SuspendLayout();
            // 
            // TabPanel
            // 
            TabPanel.ContextMenuStrip = contextMenuStripMainForm;
            TabPanel.Controls.Add(StartTab);
            TabPanel.Controls.Add(MultisTab);
            TabPanel.Controls.Add(AnimationTab);
            TabPanel.Controls.Add(ItemsTab);
            TabPanel.Controls.Add(LandTilesTab);
            TabPanel.Controls.Add(TextureTab);
            TabPanel.Controls.Add(GumpsTab);
            TabPanel.Controls.Add(SoundsTab);
            TabPanel.Controls.Add(HuesTab);
            TabPanel.Controls.Add(FontsTab);
            TabPanel.Controls.Add(ClilocTab);
            TabPanel.Controls.Add(MapTab);
            TabPanel.Controls.Add(LightTab);
            TabPanel.Controls.Add(SpeechTab);
            TabPanel.Controls.Add(SkillsTab);
            TabPanel.Controls.Add(AnimDataTab);
            TabPanel.Controls.Add(MultiMapTab);
            TabPanel.Controls.Add(DressTab);
            TabPanel.Controls.Add(TileDataTab);
            TabPanel.Controls.Add(RadarColTab);
            TabPanel.Controls.Add(SkillGrpTab);
            TabPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            TabPanel.Location = new System.Drawing.Point(0, 25);
            TabPanel.Margin = new System.Windows.Forms.Padding(0);
            TabPanel.Name = "TabPanel";
            TabPanel.SelectedIndex = 0;
            TabPanel.Size = new System.Drawing.Size(914, 626);
            TabPanel.TabIndex = 1;
            TabPanel.Tag = "20";
            // 
            // contextMenuStripMainForm
            // 
            contextMenuStripMainForm.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { UnDockToolStripMenuItem, SwitchLogoImageToolStripMenuItem, ColorBackgroundToolStripMenuItem, ResetBackgroundToolStripMenuItem, toolStripSeparator5, ultimaOnlineDirToolStripMenuItem, DirectoryToolStripMenuItem, TempDirToolStripMenuItem, toolStripSeparator6, NotesToolStripMenuItem, ScreenshotToolStripMenuItem, toolStripSeparator8, soundPlayToolStripMenuItem, stopSoundToolStripMenuItem, newDirLoadToolStripMenuItem });
            contextMenuStripMainForm.Name = "contextMenuStrip1";
            contextMenuStripMainForm.Size = new System.Drawing.Size(176, 286);
            // 
            // UnDockToolStripMenuItem
            // 
            UnDockToolStripMenuItem.Image = Properties.Resources.notepad;
            UnDockToolStripMenuItem.Name = "UnDockToolStripMenuItem";
            UnDockToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            UnDockToolStripMenuItem.Text = "UnDock";
            UnDockToolStripMenuItem.Click += OnClickUnDock;
            // 
            // SwitchLogoImageToolStripMenuItem
            // 
            SwitchLogoImageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripComboBoxImage });
            SwitchLogoImageToolStripMenuItem.Image = Properties.Resources._32x32;
            SwitchLogoImageToolStripMenuItem.Name = "SwitchLogoImageToolStripMenuItem";
            SwitchLogoImageToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            SwitchLogoImageToolStripMenuItem.Text = "Switch Logo Image";
            // 
            // toolStripComboBoxImage
            // 
            toolStripComboBoxImage.Name = "toolStripComboBoxImage";
            toolStripComboBoxImage.Size = new System.Drawing.Size(121, 23);
            toolStripComboBoxImage.SelectedIndexChanged += ImageSwitcher_SelectedIndexChanged;
            // 
            // ColorBackgroundToolStripMenuItem
            // 
            ColorBackgroundToolStripMenuItem.Image = Properties.Resources.Color;
            ColorBackgroundToolStripMenuItem.Name = "ColorBackgroundToolStripMenuItem";
            ColorBackgroundToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            ColorBackgroundToolStripMenuItem.Text = "Color Background";
            ColorBackgroundToolStripMenuItem.Click += ColorBackgroundToolStripMenuItem_Click;
            // 
            // ResetBackgroundToolStripMenuItem
            // 
            ResetBackgroundToolStripMenuItem.Image = Properties.Resources.reset_2_;
            ResetBackgroundToolStripMenuItem.Name = "ResetBackgroundToolStripMenuItem";
            ResetBackgroundToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            ResetBackgroundToolStripMenuItem.Text = "Reset Background";
            ResetBackgroundToolStripMenuItem.Click += ResetColorToolStripMenuItem_Click;
            // 
            // toolStripSeparator5
            // 
            toolStripSeparator5.Name = "toolStripSeparator5";
            toolStripSeparator5.Size = new System.Drawing.Size(172, 6);
            // 
            // ultimaOnlineDirToolStripMenuItem
            // 
            ultimaOnlineDirToolStripMenuItem.Image = Properties.Resources.ultima_online;
            ultimaOnlineDirToolStripMenuItem.Name = "ultimaOnlineDirToolStripMenuItem";
            ultimaOnlineDirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            ultimaOnlineDirToolStripMenuItem.Text = "Ultima Online Dir";
            ultimaOnlineDirToolStripMenuItem.Click += ultimaOnlineDirToolStripMenuItem_Click;
            // 
            // DirectoryToolStripMenuItem
            // 
            DirectoryToolStripMenuItem.Image = Properties.Resources.Directory;
            DirectoryToolStripMenuItem.Name = "DirectoryToolStripMenuItem";
            DirectoryToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            DirectoryToolStripMenuItem.Text = "Output Path";
            DirectoryToolStripMenuItem.ToolTipText = "Opens the directory in Explorer that was specified in Options.";
            DirectoryToolStripMenuItem.Click += DirectoryToolStripMenuItem_Click;
            // 
            // TempDirToolStripMenuItem
            // 
            TempDirToolStripMenuItem.Image = Properties.Resources.Directory;
            TempDirToolStripMenuItem.Name = "TempDirToolStripMenuItem";
            TempDirToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            TempDirToolStripMenuItem.Text = "Temp Dir";
            TempDirToolStripMenuItem.Click += TempDirToolStripMenuItem_Click;
            // 
            // toolStripSeparator6
            // 
            toolStripSeparator6.Name = "toolStripSeparator6";
            toolStripSeparator6.Size = new System.Drawing.Size(172, 6);
            // 
            // NotesToolStripMenuItem
            // 
            NotesToolStripMenuItem.Image = Properties.Resources.notepad;
            NotesToolStripMenuItem.Name = "NotesToolStripMenuItem";
            NotesToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            NotesToolStripMenuItem.Text = "Notes";
            NotesToolStripMenuItem.Click += NotesToolStripMenuItem_Click;
            // 
            // ScreenshotToolStripMenuItem
            // 
            ScreenshotToolStripMenuItem.Image = Properties.Resources.animation_edit_3_;
            ScreenshotToolStripMenuItem.Name = "ScreenshotToolStripMenuItem";
            ScreenshotToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            ScreenshotToolStripMenuItem.Text = "Screenshot";
            ScreenshotToolStripMenuItem.ToolTipText = "Takes a screenshot of the application and copies it to clipbord";
            ScreenshotToolStripMenuItem.Click += ScreenshotToolStripMenuItem_Click;
            // 
            // toolStripSeparator8
            // 
            toolStripSeparator8.Name = "toolStripSeparator8";
            toolStripSeparator8.Size = new System.Drawing.Size(172, 6);
            // 
            // soundPlayToolStripMenuItem
            // 
            soundPlayToolStripMenuItem.Image = Properties.Resources.play_musik_icon_1_;
            soundPlayToolStripMenuItem.Name = "soundPlayToolStripMenuItem";
            soundPlayToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            soundPlayToolStripMenuItem.Text = "Sound Play";
            soundPlayToolStripMenuItem.ToolTipText = "Sets the directory and plays Mp3.";
            soundPlayToolStripMenuItem.Click += soundPlayToolStripMenuItem_Click;
            // 
            // stopSoundToolStripMenuItem
            // 
            stopSoundToolStripMenuItem.Image = Properties.Resources.stop_musik_icon_1_;
            stopSoundToolStripMenuItem.Name = "stopSoundToolStripMenuItem";
            stopSoundToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            stopSoundToolStripMenuItem.Text = "Stop Sound";
            stopSoundToolStripMenuItem.ToolTipText = "Stop the music";
            stopSoundToolStripMenuItem.Click += stopSoundToolStripMenuItem_Click;
            // 
            // newDirLoadToolStripMenuItem
            // 
            newDirLoadToolStripMenuItem.Image = Properties.Resources.dir_musik_icon;
            newDirLoadToolStripMenuItem.Name = "newDirLoadToolStripMenuItem";
            newDirLoadToolStripMenuItem.Size = new System.Drawing.Size(175, 22);
            newDirLoadToolStripMenuItem.Text = "New Dir Load";
            newDirLoadToolStripMenuItem.ToolTipText = "Resets the directory";
            newDirLoadToolStripMenuItem.Click += newDirLoadToolStripMenuItem_Click;
            // 
            // StartTab
            // 
            StartTab.BackColor = System.Drawing.Color.White;
            StartTab.BackgroundImage = Properties.Resources.UOFiddler;
            StartTab.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            StartTab.Controls.Add(Versionlabel);
            StartTab.Location = new System.Drawing.Point(4, 24);
            StartTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartTab.Name = "StartTab";
            StartTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            StartTab.Size = new System.Drawing.Size(906, 598);
            StartTab.TabIndex = 10;
            StartTab.Tag = 0;
            StartTab.Text = "Start";
            // 
            // Versionlabel
            // 
            Versionlabel.Anchor = System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right;
            Versionlabel.AutoSize = true;
            Versionlabel.BackColor = System.Drawing.Color.Transparent;
            Versionlabel.ForeColor = System.Drawing.SystemColors.Info;
            Versionlabel.Location = new System.Drawing.Point(846, 576);
            Versionlabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            Versionlabel.Name = "Versionlabel";
            Versionlabel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            Versionlabel.Size = new System.Drawing.Size(45, 15);
            Versionlabel.TabIndex = 1;
            Versionlabel.Text = "Version";
            Versionlabel.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // MultisTab
            // 
            MultisTab.Controls.Add(multisControl);
            MultisTab.Location = new System.Drawing.Point(4, 24);
            MultisTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MultisTab.Name = "MultisTab";
            MultisTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MultisTab.Size = new System.Drawing.Size(906, 598);
            MultisTab.TabIndex = 1;
            MultisTab.Tag = 1;
            MultisTab.Text = "Multis";
            MultisTab.UseVisualStyleBackColor = true;
            // 
            // multisControl
            // 
            multisControl.Dock = System.Windows.Forms.DockStyle.Fill;
            multisControl.Location = new System.Drawing.Point(4, 3);
            multisControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            multisControl.Name = "multisControl";
            multisControl.Size = new System.Drawing.Size(898, 592);
            multisControl.TabIndex = 0;
            // 
            // AnimationTab
            // 
            AnimationTab.Controls.Add(animationsControl);
            AnimationTab.Location = new System.Drawing.Point(4, 24);
            AnimationTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AnimationTab.Name = "AnimationTab";
            AnimationTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AnimationTab.Size = new System.Drawing.Size(906, 598);
            AnimationTab.TabIndex = 0;
            AnimationTab.Tag = 2;
            AnimationTab.Text = "Animations";
            AnimationTab.UseVisualStyleBackColor = true;
            // 
            // animationsControl
            // 
            animationsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            animationsControl.Location = new System.Drawing.Point(4, 3);
            animationsControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            animationsControl.Name = "animationsControl";
            animationsControl.Size = new System.Drawing.Size(898, 592);
            animationsControl.TabIndex = 0;
            // 
            // ItemsTab
            // 
            ItemsTab.Location = new System.Drawing.Point(4, 24);
            ItemsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ItemsTab.Name = "ItemsTab";
            ItemsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ItemsTab.Size = new System.Drawing.Size(906, 598);
            ItemsTab.TabIndex = 2;
            ItemsTab.Tag = 3;
            ItemsTab.Text = "Items";
            ItemsTab.UseVisualStyleBackColor = true;
            // 
            // LandTilesTab
            // 
            LandTilesTab.Controls.Add(landTilesControl);
            LandTilesTab.Location = new System.Drawing.Point(4, 24);
            LandTilesTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LandTilesTab.Name = "LandTilesTab";
            LandTilesTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LandTilesTab.Size = new System.Drawing.Size(906, 598);
            LandTilesTab.TabIndex = 3;
            LandTilesTab.Tag = 4;
            LandTilesTab.Text = "Land Tiles";
            LandTilesTab.UseVisualStyleBackColor = true;
            // 
            // landTilesControl
            // 
            landTilesControl.Dock = System.Windows.Forms.DockStyle.Fill;
            landTilesControl.Location = new System.Drawing.Point(4, 3);
            landTilesControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            landTilesControl.Name = "landTilesControl";
            landTilesControl.SelectedGraphicId = 0;
            landTilesControl.Size = new System.Drawing.Size(898, 592);
            landTilesControl.TabIndex = 0;
            // 
            // TextureTab
            // 
            TextureTab.Controls.Add(textureControl);
            TextureTab.Location = new System.Drawing.Point(4, 24);
            TextureTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextureTab.Name = "TextureTab";
            TextureTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TextureTab.Size = new System.Drawing.Size(906, 598);
            TextureTab.TabIndex = 11;
            TextureTab.Tag = 5;
            TextureTab.Text = "Textures";
            TextureTab.UseVisualStyleBackColor = true;
            // 
            // textureControl
            // 
            textureControl.Dock = System.Windows.Forms.DockStyle.Fill;
            textureControl.Location = new System.Drawing.Point(4, 3);
            textureControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            textureControl.Name = "textureControl";
            textureControl.SelectedTextureId = 0;
            textureControl.Size = new System.Drawing.Size(898, 592);
            textureControl.TabIndex = 0;
            // 
            // GumpsTab
            // 
            GumpsTab.Controls.Add(gumpsControl);
            GumpsTab.Location = new System.Drawing.Point(4, 24);
            GumpsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GumpsTab.Name = "GumpsTab";
            GumpsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            GumpsTab.Size = new System.Drawing.Size(906, 598);
            GumpsTab.TabIndex = 4;
            GumpsTab.Tag = 6;
            GumpsTab.Text = "Gumps";
            GumpsTab.UseVisualStyleBackColor = true;
            // 
            // gumpsControl
            // 
            gumpsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            gumpsControl.Location = new System.Drawing.Point(4, 3);
            gumpsControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            gumpsControl.Name = "gumpsControl";
            gumpsControl.Size = new System.Drawing.Size(898, 592);
            gumpsControl.TabIndex = 0;
            // 
            // SoundsTab
            // 
            SoundsTab.Controls.Add(soundControl);
            SoundsTab.Location = new System.Drawing.Point(4, 24);
            SoundsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SoundsTab.Name = "SoundsTab";
            SoundsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SoundsTab.Size = new System.Drawing.Size(906, 598);
            SoundsTab.TabIndex = 5;
            SoundsTab.Tag = 7;
            SoundsTab.Text = "Sounds";
            SoundsTab.UseVisualStyleBackColor = true;
            // 
            // soundControl
            // 
            soundControl.Dock = System.Windows.Forms.DockStyle.Fill;
            soundControl.Location = new System.Drawing.Point(4, 3);
            soundControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            soundControl.Name = "soundControl";
            soundControl.Size = new System.Drawing.Size(898, 592);
            soundControl.TabIndex = 0;
            // 
            // HuesTab
            // 
            HuesTab.Controls.Add(hueControl);
            HuesTab.Location = new System.Drawing.Point(4, 24);
            HuesTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HuesTab.Name = "HuesTab";
            HuesTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            HuesTab.Size = new System.Drawing.Size(906, 598);
            HuesTab.TabIndex = 6;
            HuesTab.Tag = 8;
            HuesTab.Text = "Hues";
            HuesTab.UseVisualStyleBackColor = true;
            // 
            // hueControl
            // 
            hueControl.Dock = System.Windows.Forms.DockStyle.Fill;
            hueControl.ForeColor = System.Drawing.SystemColors.ControlText;
            hueControl.Location = new System.Drawing.Point(4, 3);
            hueControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            hueControl.Name = "hueControl";
            hueControl.Padding = new System.Windows.Forms.Padding(1);
            hueControl.Size = new System.Drawing.Size(898, 592);
            hueControl.TabIndex = 0;
            // 
            // FontsTab
            // 
            FontsTab.Controls.Add(fontsControl);
            FontsTab.Location = new System.Drawing.Point(4, 24);
            FontsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FontsTab.Name = "FontsTab";
            FontsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            FontsTab.Size = new System.Drawing.Size(906, 598);
            FontsTab.TabIndex = 7;
            FontsTab.Tag = 9;
            FontsTab.Text = "Fonts";
            FontsTab.UseVisualStyleBackColor = true;
            // 
            // fontsControl
            // 
            fontsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            fontsControl.Location = new System.Drawing.Point(4, 3);
            fontsControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            fontsControl.Name = "fontsControl";
            fontsControl.Size = new System.Drawing.Size(898, 592);
            fontsControl.TabIndex = 0;
            // 
            // ClilocTab
            // 
            ClilocTab.Controls.Add(clilocControl);
            ClilocTab.Location = new System.Drawing.Point(4, 24);
            ClilocTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ClilocTab.Name = "ClilocTab";
            ClilocTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            ClilocTab.Size = new System.Drawing.Size(906, 598);
            ClilocTab.TabIndex = 8;
            ClilocTab.Tag = 10;
            ClilocTab.Text = "CliLoc";
            ClilocTab.UseVisualStyleBackColor = true;
            // 
            // clilocControl
            // 
            clilocControl.Dock = System.Windows.Forms.DockStyle.Fill;
            clilocControl.Location = new System.Drawing.Point(4, 3);
            clilocControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            clilocControl.Name = "clilocControl";
            clilocControl.Size = new System.Drawing.Size(898, 592);
            clilocControl.TabIndex = 0;
            // 
            // MapTab
            // 
            MapTab.Controls.Add(mapControl);
            MapTab.Location = new System.Drawing.Point(4, 24);
            MapTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MapTab.Name = "MapTab";
            MapTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MapTab.Size = new System.Drawing.Size(906, 598);
            MapTab.TabIndex = 9;
            MapTab.Tag = 11;
            MapTab.Text = "Map";
            MapTab.UseVisualStyleBackColor = true;
            // 
            // mapControl
            // 
            mapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            mapControl.Location = new System.Drawing.Point(4, 3);
            mapControl.Margin = new System.Windows.Forms.Padding(0);
            mapControl.Name = "mapControl";
            mapControl.Size = new System.Drawing.Size(898, 592);
            mapControl.TabIndex = 0;
            // 
            // LightTab
            // 
            LightTab.Controls.Add(lightControl);
            LightTab.Location = new System.Drawing.Point(4, 24);
            LightTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            LightTab.Name = "LightTab";
            LightTab.Size = new System.Drawing.Size(906, 598);
            LightTab.TabIndex = 12;
            LightTab.Tag = 12;
            LightTab.Text = "Light";
            LightTab.UseVisualStyleBackColor = true;
            // 
            // lightControl
            // 
            lightControl.Dock = System.Windows.Forms.DockStyle.Fill;
            lightControl.Location = new System.Drawing.Point(0, 0);
            lightControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            lightControl.Name = "lightControl";
            lightControl.Size = new System.Drawing.Size(906, 598);
            lightControl.TabIndex = 0;
            // 
            // SpeechTab
            // 
            SpeechTab.Controls.Add(speechControl);
            SpeechTab.Location = new System.Drawing.Point(4, 24);
            SpeechTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SpeechTab.Name = "SpeechTab";
            SpeechTab.Size = new System.Drawing.Size(906, 598);
            SpeechTab.TabIndex = 17;
            SpeechTab.Tag = 13;
            SpeechTab.Text = "Speech";
            SpeechTab.UseVisualStyleBackColor = true;
            // 
            // speechControl
            // 
            speechControl.Dock = System.Windows.Forms.DockStyle.Fill;
            speechControl.Location = new System.Drawing.Point(0, 0);
            speechControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            speechControl.Name = "speechControl";
            speechControl.Size = new System.Drawing.Size(906, 598);
            speechControl.TabIndex = 0;
            // 
            // SkillsTab
            // 
            SkillsTab.Controls.Add(skillsControl);
            SkillsTab.Location = new System.Drawing.Point(4, 24);
            SkillsTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SkillsTab.Name = "SkillsTab";
            SkillsTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SkillsTab.Size = new System.Drawing.Size(906, 598);
            SkillsTab.TabIndex = 15;
            SkillsTab.Tag = 14;
            SkillsTab.Text = "Skills";
            SkillsTab.UseVisualStyleBackColor = true;
            // 
            // skillsControl
            // 
            skillsControl.Dock = System.Windows.Forms.DockStyle.Fill;
            skillsControl.Location = new System.Drawing.Point(4, 3);
            skillsControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            skillsControl.Name = "skillsControl";
            skillsControl.Size = new System.Drawing.Size(898, 592);
            skillsControl.TabIndex = 0;
            // 
            // AnimDataTab
            // 
            AnimDataTab.Controls.Add(animdataControl);
            AnimDataTab.Location = new System.Drawing.Point(4, 24);
            AnimDataTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            AnimDataTab.Name = "AnimDataTab";
            AnimDataTab.Size = new System.Drawing.Size(906, 598);
            AnimDataTab.TabIndex = 18;
            AnimDataTab.Tag = 15;
            AnimDataTab.Text = "AnimData";
            AnimDataTab.UseVisualStyleBackColor = true;
            // 
            // animdataControl
            // 
            animdataControl.Dock = System.Windows.Forms.DockStyle.Fill;
            animdataControl.Location = new System.Drawing.Point(0, 0);
            animdataControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            animdataControl.Name = "animdataControl";
            animdataControl.Size = new System.Drawing.Size(906, 598);
            animdataControl.TabIndex = 0;
            // 
            // MultiMapTab
            // 
            MultiMapTab.Controls.Add(multimapControl);
            MultiMapTab.Location = new System.Drawing.Point(4, 24);
            MultiMapTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MultiMapTab.Name = "MultiMapTab";
            MultiMapTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MultiMapTab.Size = new System.Drawing.Size(906, 598);
            MultiMapTab.TabIndex = 14;
            MultiMapTab.Tag = 16;
            MultiMapTab.Text = "MultiMap/Facets";
            MultiMapTab.UseVisualStyleBackColor = true;
            // 
            // multimapControl
            // 
            multimapControl.Dock = System.Windows.Forms.DockStyle.Fill;
            multimapControl.Location = new System.Drawing.Point(4, 3);
            multimapControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            multimapControl.Name = "multimapControl";
            multimapControl.Size = new System.Drawing.Size(898, 592);
            multimapControl.TabIndex = 0;
            // 
            // DressTab
            // 
            DressTab.Controls.Add(dressControl);
            DressTab.Location = new System.Drawing.Point(4, 24);
            DressTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DressTab.Name = "DressTab";
            DressTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            DressTab.Size = new System.Drawing.Size(906, 598);
            DressTab.TabIndex = 13;
            DressTab.Tag = 17;
            DressTab.Text = "Dress";
            DressTab.UseVisualStyleBackColor = true;
            // 
            // dressControl
            // 
            dressControl.Dock = System.Windows.Forms.DockStyle.Fill;
            dressControl.Location = new System.Drawing.Point(4, 3);
            dressControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            dressControl.Name = "dressControl";
            dressControl.Size = new System.Drawing.Size(898, 592);
            dressControl.TabIndex = 0;
            // 
            // TileDataTab
            // 
            TileDataTab.Location = new System.Drawing.Point(4, 24);
            TileDataTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            TileDataTab.Name = "TileDataTab";
            TileDataTab.Size = new System.Drawing.Size(906, 598);
            TileDataTab.TabIndex = 16;
            TileDataTab.Tag = 18;
            TileDataTab.Text = "TileData";
            TileDataTab.UseVisualStyleBackColor = true;
            // 
            // RadarColTab
            // 
            RadarColTab.Controls.Add(radarColControl);
            RadarColTab.Location = new System.Drawing.Point(4, 24);
            RadarColTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            RadarColTab.Name = "RadarColTab";
            RadarColTab.Size = new System.Drawing.Size(906, 598);
            RadarColTab.TabIndex = 19;
            RadarColTab.Tag = 19;
            RadarColTab.Text = "RadarColor";
            RadarColTab.UseVisualStyleBackColor = true;
            // 
            // radarColControl
            // 
            radarColControl.Dock = System.Windows.Forms.DockStyle.Fill;
            radarColControl.Location = new System.Drawing.Point(0, 0);
            radarColControl.Margin = new System.Windows.Forms.Padding(5);
            radarColControl.Name = "radarColControl";
            radarColControl.Size = new System.Drawing.Size(906, 598);
            radarColControl.TabIndex = 0;
            // 
            // SkillGrpTab
            // 
            SkillGrpTab.Controls.Add(skillGroupControl);
            SkillGrpTab.Location = new System.Drawing.Point(4, 24);
            SkillGrpTab.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SkillGrpTab.Name = "SkillGrpTab";
            SkillGrpTab.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            SkillGrpTab.Size = new System.Drawing.Size(906, 598);
            SkillGrpTab.TabIndex = 20;
            SkillGrpTab.Tag = 20;
            SkillGrpTab.Text = "SkillGrp";
            SkillGrpTab.UseVisualStyleBackColor = true;
            // 
            // skillGroupControl
            // 
            skillGroupControl.Dock = System.Windows.Forms.DockStyle.Fill;
            skillGroupControl.Location = new System.Drawing.Point(4, 3);
            skillGroupControl.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            skillGroupControl.Name = "skillGroupControl";
            skillGroupControl.Size = new System.Drawing.Size(898, 592);
            skillGroupControl.TabIndex = 0;
            // 
            // tsMainMenu
            // 
            tsMainMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] { SettingsMenu, toolStripDropDownButtonView, ExternToolsDropDown, toolStripDropDownButtonPlugins, toolStripDropDownButtonHelp });
            tsMainMenu.Location = new System.Drawing.Point(0, 0);
            tsMainMenu.Name = "tsMainMenu";
            tsMainMenu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            tsMainMenu.Size = new System.Drawing.Size(914, 25);
            tsMainMenu.TabIndex = 2;
            tsMainMenu.Text = "toolStrip1";
            // 
            // SettingsMenu
            // 
            SettingsMenu.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            SettingsMenu.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { AlwaysOnTopMenuitem, optionsToolStripMenuItem, pathSettingsMenuItem, tsSettingsSeparator, reloadFilesMenuItem });
            SettingsMenu.ImageTransparentColor = System.Drawing.Color.Magenta;
            SettingsMenu.Name = "SettingsMenu";
            SettingsMenu.Size = new System.Drawing.Size(62, 22);
            SettingsMenu.Text = "Settings";
            // 
            // AlwaysOnTopMenuitem
            // 
            AlwaysOnTopMenuitem.CheckOnClick = true;
            AlwaysOnTopMenuitem.Name = "AlwaysOnTopMenuitem";
            AlwaysOnTopMenuitem.Size = new System.Drawing.Size(152, 22);
            AlwaysOnTopMenuitem.Text = "Always On Top";
            AlwaysOnTopMenuitem.Click += OnClickAlwaysTop;
            // 
            // optionsToolStripMenuItem
            // 
            optionsToolStripMenuItem.Image = Properties.Resources.optionen;
            optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            optionsToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            optionsToolStripMenuItem.Text = "Options..";
            optionsToolStripMenuItem.Click += OnClickOptions;
            // 
            // pathSettingsMenuItem
            // 
            pathSettingsMenuItem.Image = Properties.Resources.path_settings;
            pathSettingsMenuItem.Name = "pathSettingsMenuItem";
            pathSettingsMenuItem.Size = new System.Drawing.Size(152, 22);
            pathSettingsMenuItem.Text = "Path Settings..";
            pathSettingsMenuItem.Click += Click_path;
            // 
            // tsSettingsSeparator
            // 
            tsSettingsSeparator.Name = "tsSettingsSeparator";
            tsSettingsSeparator.Size = new System.Drawing.Size(149, 6);
            // 
            // reloadFilesMenuItem
            // 
            reloadFilesMenuItem.ForeColor = System.Drawing.Color.DarkRed;
            reloadFilesMenuItem.Image = Properties.Resources.reload_files;
            reloadFilesMenuItem.Name = "reloadFilesMenuItem";
            reloadFilesMenuItem.Size = new System.Drawing.Size(152, 22);
            reloadFilesMenuItem.Text = "Reload Files";
            reloadFilesMenuItem.Click += ReloadFiles;
            // 
            // toolStripDropDownButtonView
            // 
            toolStripDropDownButtonView.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonView.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToggleViewStart, ToggleViewMulti, ToggleViewAnimations, ToggleViewItems, ToggleViewLandTiles, ToggleViewTexture, ToggleViewGumps, ToggleViewSounds, ToggleViewHue, ToggleViewFonts, ToggleViewCliloc, ToggleViewMap, ToggleViewLight, ToggleViewSpeech, ToggleViewSkills, ToggleViewAnimData, ToggleViewMultiMap, ToggleViewDress, ToggleViewTileData, ToggleViewRadarColor, ToggleViewSkillGrp });
            toolStripDropDownButtonView.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButtonView.Name = "toolStripDropDownButtonView";
            toolStripDropDownButtonView.Size = new System.Drawing.Size(45, 22);
            toolStripDropDownButtonView.Text = "View";
            // 
            // ToggleViewStart
            // 
            ToggleViewStart.Checked = true;
            ToggleViewStart.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewStart.Name = "ToggleViewStart";
            ToggleViewStart.Size = new System.Drawing.Size(164, 22);
            ToggleViewStart.Tag = 0;
            ToggleViewStart.Text = "Start";
            ToggleViewStart.Click += ToggleView;
            // 
            // ToggleViewMulti
            // 
            ToggleViewMulti.Checked = true;
            ToggleViewMulti.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewMulti.Name = "ToggleViewMulti";
            ToggleViewMulti.Size = new System.Drawing.Size(164, 22);
            ToggleViewMulti.Tag = 1;
            ToggleViewMulti.Text = "Multi";
            ToggleViewMulti.Click += ToggleView;
            // 
            // ToggleViewAnimations
            // 
            ToggleViewAnimations.Checked = true;
            ToggleViewAnimations.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewAnimations.Name = "ToggleViewAnimations";
            ToggleViewAnimations.Size = new System.Drawing.Size(164, 22);
            ToggleViewAnimations.Tag = 2;
            ToggleViewAnimations.Text = "Animations";
            ToggleViewAnimations.Click += ToggleView;
            // 
            // ToggleViewItems
            // 
            ToggleViewItems.Checked = true;
            ToggleViewItems.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewItems.Name = "ToggleViewItems";
            ToggleViewItems.Size = new System.Drawing.Size(164, 22);
            ToggleViewItems.Tag = 3;
            ToggleViewItems.Text = "Items";
            ToggleViewItems.Click += ToggleView;
            // 
            // ToggleViewLandTiles
            // 
            ToggleViewLandTiles.Checked = true;
            ToggleViewLandTiles.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewLandTiles.Name = "ToggleViewLandTiles";
            ToggleViewLandTiles.Size = new System.Drawing.Size(164, 22);
            ToggleViewLandTiles.Tag = 4;
            ToggleViewLandTiles.Text = "LandTiles";
            ToggleViewLandTiles.Click += ToggleView;
            // 
            // ToggleViewTexture
            // 
            ToggleViewTexture.Checked = true;
            ToggleViewTexture.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewTexture.Name = "ToggleViewTexture";
            ToggleViewTexture.Size = new System.Drawing.Size(164, 22);
            ToggleViewTexture.Tag = 5;
            ToggleViewTexture.Text = "Texture";
            ToggleViewTexture.Click += ToggleView;
            // 
            // ToggleViewGumps
            // 
            ToggleViewGumps.Checked = true;
            ToggleViewGumps.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewGumps.Name = "ToggleViewGumps";
            ToggleViewGumps.Size = new System.Drawing.Size(164, 22);
            ToggleViewGumps.Tag = 6;
            ToggleViewGumps.Text = "Gumps";
            ToggleViewGumps.Click += ToggleView;
            // 
            // ToggleViewSounds
            // 
            ToggleViewSounds.Checked = true;
            ToggleViewSounds.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewSounds.Name = "ToggleViewSounds";
            ToggleViewSounds.Size = new System.Drawing.Size(164, 22);
            ToggleViewSounds.Tag = 7;
            ToggleViewSounds.Text = "Sounds";
            ToggleViewSounds.Click += ToggleView;
            // 
            // ToggleViewHue
            // 
            ToggleViewHue.Checked = true;
            ToggleViewHue.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewHue.Name = "ToggleViewHue";
            ToggleViewHue.Size = new System.Drawing.Size(164, 22);
            ToggleViewHue.Tag = 8;
            ToggleViewHue.Text = "Hue";
            ToggleViewHue.Click += ToggleView;
            // 
            // ToggleViewFonts
            // 
            ToggleViewFonts.Checked = true;
            ToggleViewFonts.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewFonts.Name = "ToggleViewFonts";
            ToggleViewFonts.Size = new System.Drawing.Size(164, 22);
            ToggleViewFonts.Tag = 9;
            ToggleViewFonts.Text = "Fonts";
            ToggleViewFonts.Click += ToggleView;
            // 
            // ToggleViewCliloc
            // 
            ToggleViewCliloc.Checked = true;
            ToggleViewCliloc.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewCliloc.Name = "ToggleViewCliloc";
            ToggleViewCliloc.Size = new System.Drawing.Size(164, 22);
            ToggleViewCliloc.Tag = 10;
            ToggleViewCliloc.Text = "Cliloc";
            ToggleViewCliloc.Click += ToggleView;
            // 
            // ToggleViewMap
            // 
            ToggleViewMap.Checked = true;
            ToggleViewMap.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewMap.Name = "ToggleViewMap";
            ToggleViewMap.Size = new System.Drawing.Size(164, 22);
            ToggleViewMap.Tag = 11;
            ToggleViewMap.Text = "Map";
            ToggleViewMap.Click += ToggleView;
            // 
            // ToggleViewLight
            // 
            ToggleViewLight.Checked = true;
            ToggleViewLight.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewLight.Name = "ToggleViewLight";
            ToggleViewLight.Size = new System.Drawing.Size(164, 22);
            ToggleViewLight.Tag = 12;
            ToggleViewLight.Text = "Light";
            ToggleViewLight.Click += ToggleView;
            // 
            // ToggleViewSpeech
            // 
            ToggleViewSpeech.Checked = true;
            ToggleViewSpeech.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewSpeech.Name = "ToggleViewSpeech";
            ToggleViewSpeech.Size = new System.Drawing.Size(164, 22);
            ToggleViewSpeech.Tag = 13;
            ToggleViewSpeech.Text = "Speech";
            ToggleViewSpeech.Click += ToggleView;
            // 
            // ToggleViewSkills
            // 
            ToggleViewSkills.Checked = true;
            ToggleViewSkills.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewSkills.Name = "ToggleViewSkills";
            ToggleViewSkills.Size = new System.Drawing.Size(164, 22);
            ToggleViewSkills.Tag = 14;
            ToggleViewSkills.Text = "Skills";
            ToggleViewSkills.Click += ToggleView;
            // 
            // ToggleViewAnimData
            // 
            ToggleViewAnimData.Checked = true;
            ToggleViewAnimData.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewAnimData.Name = "ToggleViewAnimData";
            ToggleViewAnimData.Size = new System.Drawing.Size(164, 22);
            ToggleViewAnimData.Tag = 15;
            ToggleViewAnimData.Text = "AnimData";
            ToggleViewAnimData.Click += ToggleView;
            // 
            // ToggleViewMultiMap
            // 
            ToggleViewMultiMap.Checked = true;
            ToggleViewMultiMap.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewMultiMap.Name = "ToggleViewMultiMap";
            ToggleViewMultiMap.Size = new System.Drawing.Size(164, 22);
            ToggleViewMultiMap.Tag = 16;
            ToggleViewMultiMap.Text = "MultiMap/Facets";
            ToggleViewMultiMap.Click += ToggleView;
            // 
            // ToggleViewDress
            // 
            ToggleViewDress.Checked = true;
            ToggleViewDress.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewDress.Name = "ToggleViewDress";
            ToggleViewDress.Size = new System.Drawing.Size(164, 22);
            ToggleViewDress.Tag = 17;
            ToggleViewDress.Text = "Dress";
            ToggleViewDress.Click += ToggleView;
            // 
            // ToggleViewTileData
            // 
            ToggleViewTileData.Checked = true;
            ToggleViewTileData.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewTileData.Name = "ToggleViewTileData";
            ToggleViewTileData.Size = new System.Drawing.Size(164, 22);
            ToggleViewTileData.Tag = 18;
            ToggleViewTileData.Text = "TileData";
            ToggleViewTileData.Click += ToggleView;
            // 
            // ToggleViewRadarColor
            // 
            ToggleViewRadarColor.Checked = true;
            ToggleViewRadarColor.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewRadarColor.Name = "ToggleViewRadarColor";
            ToggleViewRadarColor.Size = new System.Drawing.Size(164, 22);
            ToggleViewRadarColor.Tag = 19;
            ToggleViewRadarColor.Text = "RadarColor";
            ToggleViewRadarColor.Click += ToggleView;
            // 
            // ToggleViewSkillGrp
            // 
            ToggleViewSkillGrp.Checked = true;
            ToggleViewSkillGrp.CheckState = System.Windows.Forms.CheckState.Checked;
            ToggleViewSkillGrp.Name = "ToggleViewSkillGrp";
            ToggleViewSkillGrp.Size = new System.Drawing.Size(164, 22);
            ToggleViewSkillGrp.Tag = 20;
            ToggleViewSkillGrp.Text = "SkillGrp";
            ToggleViewSkillGrp.Click += ToggleView;
            // 
            // ExternToolsDropDown
            // 
            ExternToolsDropDown.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            ExternToolsDropDown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { manageToolStripMenuItem });
            ExternToolsDropDown.ImageTransparentColor = System.Drawing.Color.Magenta;
            ExternToolsDropDown.Name = "ExternToolsDropDown";
            ExternToolsDropDown.Size = new System.Drawing.Size(83, 22);
            ExternToolsDropDown.Text = "Extern Tools";
            // 
            // manageToolStripMenuItem
            // 
            manageToolStripMenuItem.Image = Properties.Resources.path_settings;
            manageToolStripMenuItem.Name = "manageToolStripMenuItem";
            manageToolStripMenuItem.Size = new System.Drawing.Size(123, 22);
            manageToolStripMenuItem.Text = "Manage..";
            manageToolStripMenuItem.Click += OnClickToolManage;
            // 
            // toolStripDropDownButtonPlugins
            // 
            toolStripDropDownButtonPlugins.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonPlugins.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { manageToolStripMenuItem1, tsPluginsSeparator });
            toolStripDropDownButtonPlugins.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButtonPlugins.Name = "toolStripDropDownButtonPlugins";
            toolStripDropDownButtonPlugins.Size = new System.Drawing.Size(59, 22);
            toolStripDropDownButtonPlugins.Text = "Plugins";
            // 
            // manageToolStripMenuItem1
            // 
            manageToolStripMenuItem1.Image = Properties.Resources.path_settings;
            manageToolStripMenuItem1.Name = "manageToolStripMenuItem1";
            manageToolStripMenuItem1.Size = new System.Drawing.Size(123, 22);
            manageToolStripMenuItem1.Text = "Manage..";
            manageToolStripMenuItem1.Click += OnClickManagePlugins;
            // 
            // tsPluginsSeparator
            // 
            tsPluginsSeparator.Name = "tsPluginsSeparator";
            tsPluginsSeparator.Size = new System.Drawing.Size(120, 6);
            // 
            // toolStripDropDownButtonHelp
            // 
            toolStripDropDownButtonHelp.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            toolStripDropDownButtonHelp.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { toolStripMenuItemHelp, fileFormatGermanToolStripMenuItem, binaryDecimalHexadecimalConverterToolStripMenuItem, convertLineToolStripMenuItem, toolStripSeparator7, alarmClockToolStripMenuItem, calendarToolStripMenuItem, notPadToolStripMenuItem, toolStripSeparator1, toolStripMenuItemAbout, changelogToolStripMenuItem, toolStripSeparator2, ToolStripMenuItemDiscordUO, toolStripSeparator3, toolStripMenuItemLinks });
            toolStripDropDownButtonHelp.ImageTransparentColor = System.Drawing.Color.Magenta;
            toolStripDropDownButtonHelp.Name = "toolStripDropDownButtonHelp";
            toolStripDropDownButtonHelp.Size = new System.Drawing.Size(45, 22);
            toolStripDropDownButtonHelp.Text = "Help";
            toolStripDropDownButtonHelp.ToolTipText = "Help";
            // 
            // toolStripMenuItemHelp
            // 
            toolStripMenuItemHelp.Image = Properties.Resources.Help;
            toolStripMenuItemHelp.Name = "toolStripMenuItemHelp";
            toolStripMenuItemHelp.Size = new System.Drawing.Size(141, 22);
            toolStripMenuItemHelp.Text = "Help";
            toolStripMenuItemHelp.Click += ToolStripMenuItemHelp_Click;
            // 
            // fileFormatGermanToolStripMenuItem
            // 
            fileFormatGermanToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { fileFormatGermanToolStripMenuItem1, fileFormatEnglischToolStripMenuItem, animationsToolStripMenuItem, animationInstallToolStripMenuItem, animationInstallEnglischToolStripMenuItem });
            fileFormatGermanToolStripMenuItem.Image = Properties.Resources.Help;
            fileFormatGermanToolStripMenuItem.Name = "fileFormatGermanToolStripMenuItem";
            fileFormatGermanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            fileFormatGermanToolStripMenuItem.Text = "File Format";
            // 
            // fileFormatGermanToolStripMenuItem1
            // 
            fileFormatGermanToolStripMenuItem1.Image = Properties.Resources.Directory;
            fileFormatGermanToolStripMenuItem1.Name = "fileFormatGermanToolStripMenuItem1";
            fileFormatGermanToolStripMenuItem1.Size = new System.Drawing.Size(211, 22);
            fileFormatGermanToolStripMenuItem1.Text = "File Format German";
            fileFormatGermanToolStripMenuItem1.Click += ToolStripMenuItemFileFormatsGerman_Click;
            // 
            // fileFormatEnglischToolStripMenuItem
            // 
            fileFormatEnglischToolStripMenuItem.Image = Properties.Resources.Directory;
            fileFormatEnglischToolStripMenuItem.Name = "fileFormatEnglischToolStripMenuItem";
            fileFormatEnglischToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            fileFormatEnglischToolStripMenuItem.Text = "File Format Englisch";
            fileFormatEnglischToolStripMenuItem.Click += ToolStripMenuItemFileFormatsEnglisch_Click;
            // 
            // animationsToolStripMenuItem
            // 
            animationsToolStripMenuItem.Image = Properties.Resources.animation_monster_oder_pet;
            animationsToolStripMenuItem.Name = "animationsToolStripMenuItem";
            animationsToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            animationsToolStripMenuItem.Text = "Animations";
            animationsToolStripMenuItem.Click += AnimationsToolStripMenuItem_Click;
            // 
            // animationInstallToolStripMenuItem
            // 
            animationInstallToolStripMenuItem.Image = Properties.Resources.Directory;
            animationInstallToolStripMenuItem.Name = "animationInstallToolStripMenuItem";
            animationInstallToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            animationInstallToolStripMenuItem.Text = "Animation Install German";
            animationInstallToolStripMenuItem.Click += AnimationInstallToolStripMenuItem_Click;
            // 
            // animationInstallEnglischToolStripMenuItem
            // 
            animationInstallEnglischToolStripMenuItem.Image = Properties.Resources.Directory;
            animationInstallEnglischToolStripMenuItem.Name = "animationInstallEnglischToolStripMenuItem";
            animationInstallEnglischToolStripMenuItem.Size = new System.Drawing.Size(211, 22);
            animationInstallEnglischToolStripMenuItem.Text = "Animation Install Englisch";
            animationInstallEnglischToolStripMenuItem.Click += AnimationInstallEnglischToolStripMenuItem_Click;
            // 
            // binaryDecimalHexadecimalConverterToolStripMenuItem
            // 
            binaryDecimalHexadecimalConverterToolStripMenuItem.Image = Properties.Resources.calculator;
            binaryDecimalHexadecimalConverterToolStripMenuItem.Name = "binaryDecimalHexadecimalConverterToolStripMenuItem";
            binaryDecimalHexadecimalConverterToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            binaryDecimalHexadecimalConverterToolStripMenuItem.Text = "Converter";
            binaryDecimalHexadecimalConverterToolStripMenuItem.ToolTipText = "Calculator for Binary, Decimal, and Hexadecimal";
            binaryDecimalHexadecimalConverterToolStripMenuItem.Click += BinaryDecimalHexadecimalConverterToolStripMenuItem_Click_1;
            // 
            // convertLineToolStripMenuItem
            // 
            convertLineToolStripMenuItem.Image = Properties.Resources.calculator;
            convertLineToolStripMenuItem.Name = "convertLineToolStripMenuItem";
            convertLineToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            convertLineToolStripMenuItem.Text = "Convert Line";
            convertLineToolStripMenuItem.ToolTipText = "Paragraph-to-Line Converter";
            convertLineToolStripMenuItem.Click += ConvertLineToolStripMenuItem_Click;
            // 
            // toolStripSeparator7
            // 
            toolStripSeparator7.Name = "toolStripSeparator7";
            toolStripSeparator7.Size = new System.Drawing.Size(138, 6);
            // 
            // alarmClockToolStripMenuItem
            // 
            alarmClockToolStripMenuItem.Image = Properties.Resources.uhr;
            alarmClockToolStripMenuItem.Name = "alarmClockToolStripMenuItem";
            alarmClockToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            alarmClockToolStripMenuItem.Text = "Alarm Clock";
            alarmClockToolStripMenuItem.ToolTipText = "Alarm Clock";
            alarmClockToolStripMenuItem.Click += AlarmClockToolStripMenuItem_Click;
            // 
            // calendarToolStripMenuItem
            // 
            calendarToolStripMenuItem.Image = Properties.Resources.calendar_week;
            calendarToolStripMenuItem.Name = "calendarToolStripMenuItem";
            calendarToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            calendarToolStripMenuItem.Text = "Calendar";
            calendarToolStripMenuItem.ToolTipText = "Calendar";
            calendarToolStripMenuItem.Click += CalendarToolStripMenuItem_Click;
            // 
            // notPadToolStripMenuItem
            // 
            notPadToolStripMenuItem.Image = Properties.Resources.notepad;
            notPadToolStripMenuItem.Name = "notPadToolStripMenuItem";
            notPadToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            notPadToolStripMenuItem.Text = "NotPad";
            notPadToolStripMenuItem.ToolTipText = "NotePad";
            notPadToolStripMenuItem.Click += NotPadToolStripMenuItem_Click;
            // 
            // toolStripSeparator1
            // 
            toolStripSeparator1.Name = "toolStripSeparator1";
            toolStripSeparator1.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripMenuItemAbout
            // 
            toolStripMenuItemAbout.Image = Properties.Resources.About;
            toolStripMenuItemAbout.Name = "toolStripMenuItemAbout";
            toolStripMenuItemAbout.Size = new System.Drawing.Size(141, 22);
            toolStripMenuItemAbout.Text = "About";
            toolStripMenuItemAbout.ToolTipText = "About";
            toolStripMenuItemAbout.Click += ToolStripMenuItemAbout_Click;
            // 
            // changelogToolStripMenuItem
            // 
            changelogToolStripMenuItem.Image = Properties.Resources.Changelog;
            changelogToolStripMenuItem.Name = "changelogToolStripMenuItem";
            changelogToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            changelogToolStripMenuItem.Text = "Changelog";
            changelogToolStripMenuItem.ToolTipText = "Changelog";
            changelogToolStripMenuItem.Click += ChangelogToolStripMenuItem_Click;
            // 
            // toolStripSeparator2
            // 
            toolStripSeparator2.Name = "toolStripSeparator2";
            toolStripSeparator2.Size = new System.Drawing.Size(138, 6);
            // 
            // ToolStripMenuItemDiscordUO
            // 
            ToolStripMenuItemDiscordUO.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { ToolStripMenuItemDiscordUoFreeshardsDe });
            ToolStripMenuItemDiscordUO.Image = Properties.Resources.Discord;
            ToolStripMenuItemDiscordUO.Name = "ToolStripMenuItemDiscordUO";
            ToolStripMenuItemDiscordUO.Size = new System.Drawing.Size(141, 22);
            ToolStripMenuItemDiscordUO.Text = "Discord";
            // 
            // ToolStripMenuItemDiscordUoFreeshardsDe
            // 
            ToolStripMenuItemDiscordUoFreeshardsDe.Image = Properties.Resources.pngegg;
            ToolStripMenuItemDiscordUoFreeshardsDe.Name = "ToolStripMenuItemDiscordUoFreeshardsDe";
            ToolStripMenuItemDiscordUoFreeshardsDe.Size = new System.Drawing.Size(166, 22);
            ToolStripMenuItemDiscordUoFreeshardsDe.Text = "Uo-Freeshards.de";
            ToolStripMenuItemDiscordUoFreeshardsDe.Click += ToolStripMenuItemDiscordUoFreeshardsDe_Click;
            // 
            // toolStripSeparator3
            // 
            toolStripSeparator3.Name = "toolStripSeparator3";
            toolStripSeparator3.Size = new System.Drawing.Size(138, 6);
            // 
            // toolStripMenuItemLinks
            // 
            toolStripMenuItemLinks.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] { uodevuofreeshardsdeToolStripMenuItem, toolStripMenuItem1, toolStripMenuItem2, toolStripSeparator4, toolStripMenuItemLink3 });
            toolStripMenuItemLinks.Image = Properties.Resources.Links;
            toolStripMenuItemLinks.Name = "toolStripMenuItemLinks";
            toolStripMenuItemLinks.Size = new System.Drawing.Size(141, 22);
            toolStripMenuItemLinks.Text = "Links";
            // 
            // uodevuofreeshardsdeToolStripMenuItem
            // 
            uodevuofreeshardsdeToolStripMenuItem.Image = Properties.Resources.pngegg;
            uodevuofreeshardsdeToolStripMenuItem.Name = "uodevuofreeshardsdeToolStripMenuItem";
            uodevuofreeshardsdeToolStripMenuItem.Size = new System.Drawing.Size(199, 22);
            uodevuofreeshardsdeToolStripMenuItem.Text = "uodev.uo-freeshards.de";
            uodevuofreeshardsdeToolStripMenuItem.Click += UodevuofreeshardsdeToolStripMenuItem_Click;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Image = Properties.Resources.pngegg;
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new System.Drawing.Size(199, 22);
            toolStripMenuItem1.Text = "uo-freeshards.de";
            toolStripMenuItem1.Click += ToolStripMenuItem1_Click;
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Image = Properties.Resources.pngegg;
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new System.Drawing.Size(199, 22);
            toolStripMenuItem2.Text = "uo-pixel.de";
            toolStripMenuItem2.Click += ToolStripMenuItem2_Click;
            // 
            // toolStripSeparator4
            // 
            toolStripSeparator4.Name = "toolStripSeparator4";
            toolStripSeparator4.Size = new System.Drawing.Size(196, 6);
            // 
            // toolStripMenuItemLink3
            // 
            toolStripMenuItemLink3.Image = Properties.Resources.pngegg;
            toolStripMenuItemLink3.Name = "toolStripMenuItemLink3";
            toolStripMenuItemLink3.Size = new System.Drawing.Size(199, 22);
            toolStripMenuItemLink3.Text = "Servuo.com";
            toolStripMenuItemLink3.Click += ToolStripMenuItemLink3_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            ClientSize = new System.Drawing.Size(914, 651);
            Controls.Add(TabPanel);
            Controls.Add(tsMainMenu);
            DoubleBuffered = true;
            Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            MinimumSize = new System.Drawing.Size(750, 550);
            Name = "MainForm";
            Text = "UOFiddler";
            FormClosing += OnClosing;
            FormClosed += HelpDokuForm_FormClosed;
            TabPanel.ResumeLayout(false);
            contextMenuStripMainForm.ResumeLayout(false);
            StartTab.ResumeLayout(false);
            StartTab.PerformLayout();
            MultisTab.ResumeLayout(false);
            AnimationTab.ResumeLayout(false);
            LandTilesTab.ResumeLayout(false);
            TextureTab.ResumeLayout(false);
            GumpsTab.ResumeLayout(false);
            SoundsTab.ResumeLayout(false);
            HuesTab.ResumeLayout(false);
            FontsTab.ResumeLayout(false);
            ClilocTab.ResumeLayout(false);
            MapTab.ResumeLayout(false);
            LightTab.ResumeLayout(false);
            SpeechTab.ResumeLayout(false);
            SkillsTab.ResumeLayout(false);
            AnimDataTab.ResumeLayout(false);
            MultiMapTab.ResumeLayout(false);
            DressTab.ResumeLayout(false);
            RadarColTab.ResumeLayout(false);
            SkillGrpTab.ResumeLayout(false);
            tsMainMenu.ResumeLayout(false);
            tsMainMenu.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TabControl TabPanel;
        private System.Windows.Forms.TabPage AnimationTab;
        private System.Windows.Forms.ToolTip toolTip;
        private System.Windows.Forms.TabPage ItemsTab;
        private ItemsControl itemShowControl;
        private AnimationListControl animationsControl;
        private System.Windows.Forms.TabPage LandTilesTab;
        private LandTilesControl landTilesControl;
        private System.Windows.Forms.TabPage GumpsTab;
        private GumpControl gumpsControl;
        private System.Windows.Forms.TabPage SoundsTab;
        private SoundsControl soundControl;
        private System.Windows.Forms.ToolStrip tsMainMenu;
        private System.Windows.Forms.TabPage MultisTab;
        private MultisControl multisControl;
        private System.Windows.Forms.TabPage HuesTab;
        private HuesControl hueControl;
        private System.Windows.Forms.TabPage FontsTab;
        private FontsControl fontsControl;
        private System.Windows.Forms.TabPage ClilocTab;
        private ClilocControl clilocControl;
        private System.Windows.Forms.TabPage MapTab;
        private MapControl mapControl;
        private System.Windows.Forms.TabPage StartTab;
        private System.Windows.Forms.TabPage TextureTab;
        private TexturesControl textureControl;
        private System.Windows.Forms.TabPage LightTab;
        private LightControl lightControl;
        private System.Windows.Forms.Label Versionlabel;
        private System.Windows.Forms.TabPage DressTab;
        private DressControl dressControl;
        private System.Windows.Forms.ToolStripDropDownButton SettingsMenu;
        private System.Windows.Forms.ToolStripMenuItem AlwaysOnTopMenuitem;
        private System.Windows.Forms.ToolStripMenuItem pathSettingsMenuItem;
        private System.Windows.Forms.ToolStripSeparator tsSettingsSeparator;
        private System.Windows.Forms.ToolStripMenuItem reloadFilesMenuItem;
        private System.Windows.Forms.TabPage MultiMapTab;
        private MultiMapControl multimapControl;
        private System.Windows.Forms.TabPage SkillsTab;
        private SkillsControl skillsControl;
        private System.Windows.Forms.TabPage TileDataTab;
        private TileDataControl tileDataControl;
        private System.Windows.Forms.TabPage SpeechTab;
        private SpeechControl speechControl;
        private System.Windows.Forms.ToolStripDropDownButton ExternToolsDropDown;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStripMainForm;
        private System.Windows.Forms.ToolStripMenuItem UnDockToolStripMenuItem;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonPlugins;
        private System.Windows.Forms.ToolStripMenuItem manageToolStripMenuItem1;
        private System.Windows.Forms.ToolStripSeparator tsPluginsSeparator;
        private System.Windows.Forms.TabPage AnimDataTab;
        private AnimDataControl animdataControl;
        private System.Windows.Forms.TabPage RadarColTab;
        private RadarColorControl radarColControl;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonView;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewStart;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewMulti;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewAnimations;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewItems;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewLandTiles;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewTexture;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewGumps;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewSounds;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewHue;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewFonts;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewCliloc;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewMap;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewLight;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewSpeech;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewSkills;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewAnimData;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewMultiMap;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewDress;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewTileData;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewRadarColor;
        private System.Windows.Forms.TabPage SkillGrpTab;
        private SkillGroupControl skillGroupControl;
        private System.Windows.Forms.ToolStripMenuItem ToggleViewSkillGrp;
        private System.Windows.Forms.ToolStripDropDownButton toolStripDropDownButtonHelp;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemHelp;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemAbout;
        private System.Windows.Forms.ToolStripMenuItem changelogToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem SwitchLogoImageToolStripMenuItem;
        private System.Windows.Forms.ToolStripComboBox toolStripComboBoxImage;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem DirectoryToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem binaryDecimalHexadecimalConverterToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLinks;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItemLink3;
        private System.Windows.Forms.ToolStripMenuItem uodevuofreeshardsdeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDiscordUoFreeshardsDe;
        private System.Windows.Forms.ToolStripMenuItem ToolStripMenuItemDiscordUO;
        private System.Windows.Forms.ToolStripMenuItem TempDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem alarmClockToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem notPadToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem NotesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ScreenshotToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem calendarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileFormatGermanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem fileFormatGermanToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem fileFormatEnglischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationInstallToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem animationInstallEnglischToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ColorBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ResetBackgroundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem convertLineToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem ultimaOnlineDirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem soundPlayToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem stopSoundToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem newDirLoadToolStripMenuItem;
    }
}

