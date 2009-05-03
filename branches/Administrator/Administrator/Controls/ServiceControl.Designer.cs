namespace Administrator.Controls
{
    partial class ServiceControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.ServiceTree = new DevExpress.XtraTreeList.TreeList();
            this.columnName = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.MenuNew = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            this.SuspendLayout();
            // 
            // ServiceTree
            // 
            this.ServiceTree.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.columnName});
            this.ServiceTree.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceTree.KeyFieldName = "service_id";
            this.ServiceTree.Location = new System.Drawing.Point(0, 26);
            this.ServiceTree.Name = "ServiceTree";
            this.ServiceTree.OptionsSelection.MultiSelect = true;
            this.ServiceTree.OptionsView.ShowHorzLines = false;
            this.ServiceTree.OptionsView.ShowVertLines = false;
            this.ServiceTree.ParentFieldName = "service_type_id";
            this.ServiceTree.Size = new System.Drawing.Size(318, 318);
            this.ServiceTree.TabIndex = 0;
            this.ServiceTree.SelectionChanged += new System.EventHandler(this.ServiceTree_SelectionChanged);
            this.ServiceTree.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.ServiceTree_MouseDoubleClick);
            // 
            // columnName
            // 
            this.columnName.Caption = "Наименование";
            this.columnName.FieldName = "name";
            this.columnName.Name = "columnName";
            this.columnName.OptionsColumn.AllowEdit = false;
            this.columnName.OptionsColumn.AllowFocus = false;
            this.columnName.OptionsColumn.AllowMove = false;
            this.columnName.OptionsColumn.AllowMoveToCustomizationForm = false;
            this.columnName.OptionsColumn.ReadOnly = true;
            this.columnName.Visible = true;
            this.columnName.VisibleIndex = 0;
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuNew});
            this.BarManager.MaxItemId = 1;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuNew)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // MenuNew
            // 
            this.MenuNew.Caption = "Новая услуга";
            this.MenuNew.Glyph = global::Administrator.Properties.Resources.add_16_16;
            this.MenuNew.Id = 0;
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuNew_ItemClick);
            // 
            // ServiceControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ServiceTree);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "ServiceControl";
            this.Size = new System.Drawing.Size(318, 344);
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraTreeList.TreeList ServiceTree;
        private DevExpress.XtraTreeList.Columns.TreeListColumn columnName;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarButtonItem MenuNew;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
    }
}
