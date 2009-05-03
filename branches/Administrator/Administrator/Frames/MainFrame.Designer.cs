namespace Administrator.Frames
{
    partial class MainFrame
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainFrame));
            this.MdiManager = new DevExpress.XtraTabbedMdi.XtraTabbedMdiManager(this.components);
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.ToolBar = new DevExpress.XtraBars.Bar();
            this.MenuRefresh = new DevExpress.XtraBars.BarButtonItem();
            this.MenuBar = new DevExpress.XtraBars.Bar();
            this.menuFile = new DevExpress.XtraBars.BarSubItem();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.menuSettings = new DevExpress.XtraBars.BarSubItem();
            this.menuConnectionSettings = new DevExpress.XtraBars.BarButtonItem();
            this.StatusBar = new DevExpress.XtraBars.Bar();
            this.barDockControl1 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl2 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl3 = new DevExpress.XtraBars.BarDockControl();
            this.barDockControl4 = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            this.SuspendLayout();
            // 
            // MdiManager
            // 
            this.MdiManager.MdiParent = this;
            this.MdiManager.PageAdded += new DevExpress.XtraTabbedMdi.MdiTabPageEventHandler(this.MdiManager_PageAdded);
            // 
            // barManager
            // 
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.ToolBar,
            this.MenuBar,
            this.StatusBar});
            this.barManager.DockControls.Add(this.barDockControl1);
            this.barManager.DockControls.Add(this.barDockControl2);
            this.barManager.DockControls.Add(this.barDockControl3);
            this.barManager.DockControls.Add(this.barDockControl4);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.menuFile,
            this.barButtonItem1,
            this.MenuRefresh,
            this.menuSettings,
            this.menuConnectionSettings});
            this.barManager.MainMenu = this.MenuBar;
            this.barManager.MaxItemId = 5;
            this.barManager.StatusBar = this.StatusBar;
            // 
            // ToolBar
            // 
            this.ToolBar.BarName = "Tools";
            this.ToolBar.DockCol = 0;
            this.ToolBar.DockRow = 1;
            this.ToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.ToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MenuRefresh, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.ToolBar.OptionsBar.AllowQuickCustomization = false;
            this.ToolBar.OptionsBar.DrawDragBorder = false;
            this.ToolBar.OptionsBar.UseWholeRow = true;
            this.ToolBar.Text = "Tools";
            // 
            // MenuRefresh
            // 
            this.MenuRefresh.Caption = "Обновить";
            this.MenuRefresh.Glyph = global::Administrator.Properties.Resources.refresh;
            this.MenuRefresh.Id = 2;
            this.MenuRefresh.ItemShortcut = new DevExpress.XtraBars.BarShortcut(System.Windows.Forms.Keys.F5);
            this.MenuRefresh.Name = "MenuRefresh";
            this.MenuRefresh.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuRefresh_ItemClick);
            // 
            // MenuBar
            // 
            this.MenuBar.BarName = "Main menu";
            this.MenuBar.DockCol = 0;
            this.MenuBar.DockRow = 0;
            this.MenuBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.MenuBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuFile),
            new DevExpress.XtraBars.LinkPersistInfo(this.menuSettings)});
            this.MenuBar.OptionsBar.AllowQuickCustomization = false;
            this.MenuBar.OptionsBar.DrawDragBorder = false;
            this.MenuBar.OptionsBar.UseWholeRow = true;
            this.MenuBar.Text = "Main menu";
            // 
            // menuFile
            // 
            this.menuFile.Caption = "Файл";
            this.menuFile.Id = 0;
            this.menuFile.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1, true)});
            this.menuFile.Name = "menuFile";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Выход";
            this.barButtonItem1.Glyph = global::Administrator.Properties.Resources.exit;
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // menuSettings
            // 
            this.menuSettings.Caption = "Насторйки";
            this.menuSettings.Id = 3;
            this.menuSettings.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.menuConnectionSettings)});
            this.menuSettings.Name = "menuSettings";
            // 
            // menuConnectionSettings
            // 
            this.menuConnectionSettings.Caption = "Насторйка соединения..";
            this.menuConnectionSettings.Glyph = global::Administrator.Properties.Resources.database_refresh_16;
            this.menuConnectionSettings.Id = 4;
            this.menuConnectionSettings.Name = "menuConnectionSettings";
            this.menuConnectionSettings.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuConnectionSettings_ItemClick);
            // 
            // StatusBar
            // 
            this.StatusBar.BarName = "Status bar";
            this.StatusBar.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.StatusBar.DockCol = 0;
            this.StatusBar.DockRow = 0;
            this.StatusBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.StatusBar.OptionsBar.AllowQuickCustomization = false;
            this.StatusBar.OptionsBar.DrawDragBorder = false;
            this.StatusBar.OptionsBar.UseWholeRow = true;
            this.StatusBar.Text = "Status bar";
            // 
            // MainFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(817, 562);
            this.Controls.Add(this.barDockControl3);
            this.Controls.Add(this.barDockControl4);
            this.Controls.Add(this.barDockControl2);
            this.Controls.Add(this.barDockControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MinimumSize = new System.Drawing.Size(800, 600);
            this.Name = "MainFrame";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Администратор";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.MdiManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTabbedMdi.XtraTabbedMdiManager MdiManager;
        private DevExpress.XtraBars.BarDockControl barDockControl3;
        private DevExpress.XtraBars.BarDockControl barDockControl4;
        private DevExpress.XtraBars.BarDockControl barDockControl2;
        private DevExpress.XtraBars.BarDockControl barDockControl1;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar ToolBar;
        private DevExpress.XtraBars.Bar MenuBar;
        private DevExpress.XtraBars.BarSubItem menuFile;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.Bar StatusBar;
        private DevExpress.XtraBars.BarButtonItem MenuRefresh;
        private DevExpress.XtraBars.BarSubItem menuSettings;
        private DevExpress.XtraBars.BarButtonItem menuConnectionSettings;
    }
}