namespace Administrator.Controls
{
    partial class OrganizationListControl
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
            DevExpress.XtraGrid.StyleFormatCondition styleFormatCondition1 = new DevExpress.XtraGrid.StyleFormatCondition();
            this.blackListColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.MenuNew = new DevExpress.XtraBars.BarButtonItem();
            this.MenuEdit = new DevExpress.XtraBars.BarButtonItem();
            this.menuBlackList = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.organizationGrid = new DevExpress.XtraGrid.GridControl();
            this.LinqSource = new DevExpress.Data.Linq.LinqServerModeSource();
            this.MainView = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.nameColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.shortNameColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.scopeOfActivityColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.directorNameColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.organizationIdColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.emailColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.phoneColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.postAddressColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.addressColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.legalAddressColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.discountColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.finishedColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.cancellationNumberColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.descriptionColumn = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.descriptionMemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.BandUnvisible = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinqSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoExEdit)).BeginInit();
            this.SuspendLayout();
            // 
            // blackListColumn
            // 
            this.blackListColumn.Caption = "В чёрном списке";
            this.blackListColumn.FieldName = "IsInBlackList";
            this.blackListColumn.Name = "blackListColumn";
            this.blackListColumn.OptionsColumn.AllowEdit = false;
            this.blackListColumn.OptionsColumn.AllowFocus = false;
            this.blackListColumn.RowIndex = 3;
            // 
            // barManager
            // 
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuNew,
            this.MenuEdit,
            this.menuBlackList});
            this.barManager.MaxItemId = 3;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MenuNew, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MenuEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.menuBlackList, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // MenuNew
            // 
            this.MenuNew.Caption = "Новая организация";
            this.MenuNew.Glyph = global::Administrator.Properties.Resources.office_building_add;
            this.MenuNew.Id = 0;
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuNew_ItemClick);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Caption = "Изменить Данные";
            this.MenuEdit.Glyph = global::Administrator.Properties.Resources.office_building_24_24;
            this.MenuEdit.Id = 1;
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuEdit_ItemClick);
            // 
            // menuBlackList
            // 
            this.menuBlackList.Caption = "В чёрный список";
            this.menuBlackList.Glyph = global::Administrator.Properties.Resources.sad_face_24;
            this.menuBlackList.Id = 2;
            this.menuBlackList.Name = "menuBlackList";
            this.menuBlackList.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.menuBlackList_ItemClick);
            // 
            // organizationGrid
            // 
            this.organizationGrid.DataSource = this.LinqSource;
            this.organizationGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizationGrid.Location = new System.Drawing.Point(0, 34);
            this.organizationGrid.MainView = this.MainView;
            this.organizationGrid.Name = "organizationGrid";
            this.organizationGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.descriptionMemoExEdit});
            this.organizationGrid.Size = new System.Drawing.Size(746, 429);
            this.organizationGrid.TabIndex = 4;
            this.organizationGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand1,
            this.gridBand2,
            this.gridBand3,
            this.gridBand4,
            this.BandUnvisible});
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.organizationIdColumn,
            this.nameColumn,
            this.shortNameColumn,
            this.legalAddressColumn,
            this.postAddressColumn,
            this.addressColumn,
            this.emailColumn,
            this.scopeOfActivityColumn,
            this.phoneColumn,
            this.cancellationNumberColumn,
            this.discountColumn,
            this.descriptionColumn,
            this.directorNameColumn,
            this.finishedColumn,
            this.blackListColumn});
            styleFormatCondition1.Appearance.BackColor = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.BackColor2 = System.Drawing.Color.White;
            styleFormatCondition1.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            styleFormatCondition1.Appearance.Options.UseBackColor = true;
            styleFormatCondition1.Appearance.Options.UseForeColor = true;
            styleFormatCondition1.ApplyToRow = true;
            styleFormatCondition1.Column = this.blackListColumn;
            styleFormatCondition1.Condition = DevExpress.XtraGrid.FormatConditionEnum.Equal;
            styleFormatCondition1.Value1 = "true";
            this.MainView.FormatConditions.AddRange(new DevExpress.XtraGrid.StyleFormatCondition[] {
            styleFormatCondition1});
            this.MainView.GridControl = this.organizationGrid;
            this.MainView.Name = "MainView";
            this.MainView.OptionsDetail.EnableMasterViewMode = false;
            this.MainView.OptionsNavigation.AutoFocusNewRow = true;
            this.MainView.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.MainView.OptionsView.AutoCalcPreviewLineCount = true;
            this.MainView.OptionsView.ColumnAutoWidth = true;
            this.MainView.OptionsView.EnableAppearanceEvenRow = true;
            this.MainView.OptionsView.EnableAppearanceOddRow = true;
            this.MainView.OptionsView.ShowAutoFilterRow = true;
            this.MainView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MainView_FocusedRowChanged);
            this.MainView.DoubleClick += new System.EventHandler(this.MainView_DoubleClick);
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Основные данные";
            this.gridBand1.Columns.Add(this.nameColumn);
            this.gridBand1.Columns.Add(this.shortNameColumn);
            this.gridBand1.Columns.Add(this.scopeOfActivityColumn);
            this.gridBand1.Columns.Add(this.directorNameColumn);
            this.gridBand1.Columns.Add(this.blackListColumn);
            this.gridBand1.MinWidth = 20;
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 179;
            // 
            // nameColumn
            // 
            this.nameColumn.Caption = "Название";
            this.nameColumn.FieldName = "Name";
            this.nameColumn.Name = "nameColumn";
            this.nameColumn.OptionsColumn.AllowEdit = false;
            this.nameColumn.OptionsColumn.AllowFocus = false;
            this.nameColumn.OptionsColumn.ReadOnly = true;
            // 
            // shortNameColumn
            // 
            this.shortNameColumn.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.shortNameColumn.AppearanceCell.Options.UseFont = true;
            this.shortNameColumn.Caption = "Название";
            this.shortNameColumn.FieldName = "ShortName";
            this.shortNameColumn.Name = "shortNameColumn";
            this.shortNameColumn.OptionsColumn.AllowEdit = false;
            this.shortNameColumn.OptionsColumn.AllowFocus = false;
            this.shortNameColumn.OptionsColumn.ReadOnly = true;
            this.shortNameColumn.Visible = true;
            this.shortNameColumn.Width = 179;
            // 
            // scopeOfActivityColumn
            // 
            this.scopeOfActivityColumn.Caption = "Сфера Деятельности";
            this.scopeOfActivityColumn.FieldName = "ScopeOfActivity";
            this.scopeOfActivityColumn.Name = "scopeOfActivityColumn";
            this.scopeOfActivityColumn.OptionsColumn.AllowEdit = false;
            this.scopeOfActivityColumn.OptionsColumn.AllowFocus = false;
            this.scopeOfActivityColumn.OptionsColumn.ReadOnly = true;
            this.scopeOfActivityColumn.RowIndex = 1;
            this.scopeOfActivityColumn.Visible = true;
            this.scopeOfActivityColumn.Width = 179;
            // 
            // directorNameColumn
            // 
            this.directorNameColumn.Caption = "Генеральный Директор";
            this.directorNameColumn.FieldName = "Director";
            this.directorNameColumn.Name = "directorNameColumn";
            this.directorNameColumn.OptionsColumn.AllowEdit = false;
            this.directorNameColumn.OptionsColumn.AllowFocus = false;
            this.directorNameColumn.OptionsColumn.ReadOnly = true;
            this.directorNameColumn.RowIndex = 2;
            this.directorNameColumn.Visible = true;
            this.directorNameColumn.Width = 179;
            // 
            // organizationIdColumn
            // 
            this.organizationIdColumn.Caption = "OrganizationID";
            this.organizationIdColumn.FieldName = "organization_id";
            this.organizationIdColumn.Name = "organizationIdColumn";
            this.organizationIdColumn.OptionsColumn.AllowEdit = false;
            this.organizationIdColumn.OptionsColumn.AllowFocus = false;
            this.organizationIdColumn.OptionsColumn.ReadOnly = true;
            this.organizationIdColumn.Visible = true;
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Контактные данные";
            this.gridBand2.Columns.Add(this.emailColumn);
            this.gridBand2.Columns.Add(this.phoneColumn);
            this.gridBand2.Columns.Add(this.postAddressColumn);
            this.gridBand2.Columns.Add(this.addressColumn);
            this.gridBand2.Columns.Add(this.legalAddressColumn);
            this.gridBand2.MinWidth = 20;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.Width = 316;
            // 
            // emailColumn
            // 
            this.emailColumn.Caption = "email";
            this.emailColumn.FieldName = "Email";
            this.emailColumn.Name = "emailColumn";
            this.emailColumn.OptionsColumn.AllowEdit = false;
            this.emailColumn.OptionsColumn.AllowFocus = false;
            this.emailColumn.OptionsColumn.ReadOnly = true;
            this.emailColumn.Visible = true;
            this.emailColumn.Width = 316;
            // 
            // phoneColumn
            // 
            this.phoneColumn.Caption = "Телефон";
            this.phoneColumn.FieldName = "Phone";
            this.phoneColumn.Name = "phoneColumn";
            this.phoneColumn.OptionsColumn.AllowEdit = false;
            this.phoneColumn.OptionsColumn.AllowFocus = false;
            this.phoneColumn.OptionsColumn.ReadOnly = true;
            this.phoneColumn.RowIndex = 1;
            this.phoneColumn.Visible = true;
            this.phoneColumn.Width = 316;
            // 
            // postAddressColumn
            // 
            this.postAddressColumn.Caption = "Почтовый Адрес";
            this.postAddressColumn.FieldName = "PostAddress";
            this.postAddressColumn.Name = "postAddressColumn";
            this.postAddressColumn.OptionsColumn.AllowEdit = false;
            this.postAddressColumn.OptionsColumn.AllowFocus = false;
            this.postAddressColumn.OptionsColumn.ReadOnly = true;
            this.postAddressColumn.RowIndex = 2;
            this.postAddressColumn.Width = 316;
            // 
            // addressColumn
            // 
            this.addressColumn.Caption = "Фактический Адрес";
            this.addressColumn.FieldName = "Address";
            this.addressColumn.Name = "addressColumn";
            this.addressColumn.OptionsColumn.AllowEdit = false;
            this.addressColumn.OptionsColumn.AllowFocus = false;
            this.addressColumn.OptionsColumn.ReadOnly = true;
            this.addressColumn.RowIndex = 2;
            this.addressColumn.Visible = true;
            this.addressColumn.Width = 316;
            // 
            // legalAddressColumn
            // 
            this.legalAddressColumn.Caption = "Юридический Адрес";
            this.legalAddressColumn.FieldName = "LegalAddress";
            this.legalAddressColumn.Name = "legalAddressColumn";
            this.legalAddressColumn.OptionsColumn.AllowEdit = false;
            this.legalAddressColumn.OptionsColumn.AllowFocus = false;
            this.legalAddressColumn.OptionsColumn.ReadOnly = true;
            this.legalAddressColumn.RowIndex = 4;
            this.legalAddressColumn.Width = 316;
            // 
            // gridBand3
            // 
            this.gridBand3.Columns.Add(this.discountColumn);
            this.gridBand3.Columns.Add(this.finishedColumn);
            this.gridBand3.Columns.Add(this.cancellationNumberColumn);
            this.gridBand3.MinWidth = 20;
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Width = 192;
            // 
            // discountColumn
            // 
            this.discountColumn.Caption = "Скидка";
            this.discountColumn.FieldName = "Discount";
            this.discountColumn.Name = "discountColumn";
            this.discountColumn.OptionsColumn.AllowEdit = false;
            this.discountColumn.OptionsColumn.AllowFocus = false;
            this.discountColumn.OptionsColumn.ReadOnly = true;
            this.discountColumn.Visible = true;
            this.discountColumn.Width = 128;
            // 
            // finishedColumn
            // 
            this.finishedColumn.Caption = "Кол-во мероприятий";
            this.finishedColumn.FieldName = "FinishedCount";
            this.finishedColumn.Name = "finishedColumn";
            this.finishedColumn.OptionsColumn.AllowEdit = false;
            this.finishedColumn.OptionsColumn.AllowFocus = false;
            this.finishedColumn.RowIndex = 1;
            this.finishedColumn.Visible = true;
            // 
            // cancellationNumberColumn
            // 
            this.cancellationNumberColumn.Caption = "Отказы";
            this.cancellationNumberColumn.FieldName = "CanceledCount";
            this.cancellationNumberColumn.Name = "cancellationNumberColumn";
            this.cancellationNumberColumn.OptionsColumn.AllowEdit = false;
            this.cancellationNumberColumn.OptionsColumn.AllowFocus = false;
            this.cancellationNumberColumn.OptionsColumn.ReadOnly = true;
            this.cancellationNumberColumn.RowIndex = 2;
            this.cancellationNumberColumn.Visible = true;
            this.cancellationNumberColumn.Width = 192;
            // 
            // gridBand4
            // 
            this.gridBand4.Columns.Add(this.descriptionColumn);
            this.gridBand4.MinWidth = 20;
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 75;
            // 
            // descriptionColumn
            // 
            this.descriptionColumn.Caption = "Описание";
            this.descriptionColumn.ColumnEdit = this.descriptionMemoExEdit;
            this.descriptionColumn.FieldName = "Description";
            this.descriptionColumn.Name = "descriptionColumn";
            this.descriptionColumn.OptionsColumn.ReadOnly = true;
            this.descriptionColumn.RowCount = 3;
            this.descriptionColumn.Visible = true;
            // 
            // descriptionMemoExEdit
            // 
            this.descriptionMemoExEdit.AutoHeight = false;
            this.descriptionMemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.descriptionMemoExEdit.Name = "descriptionMemoExEdit";
            this.descriptionMemoExEdit.ReadOnly = true;
            // 
            // BandUnvisible
            // 
            this.BandUnvisible.Caption = "Unvisible";
            this.BandUnvisible.Columns.Add(this.organizationIdColumn);
            this.BandUnvisible.Name = "BandUnvisible";
            this.BandUnvisible.Visible = false;
            this.BandUnvisible.Width = 75;
            // 
            // OrganizationListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.organizationGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "OrganizationListControl";
            this.Size = new System.Drawing.Size(746, 463);
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.organizationGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LinqSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionMemoExEdit)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem MenuNew;
        private DevExpress.XtraGrid.GridControl organizationGrid;
        private DevExpress.XtraBars.BarButtonItem MenuEdit;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView MainView;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn organizationIdColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn nameColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn shortNameColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn legalAddressColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn postAddressColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn addressColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn emailColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn scopeOfActivityColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn phoneColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn cancellationNumberColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn discountColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn descriptionColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn directorNameColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit descriptionMemoExEdit;
        private DevExpress.Data.Linq.LinqServerModeSource LinqSource;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn finishedColumn;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn blackListColumn;
        private DevExpress.XtraBars.BarButtonItem menuBlackList;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand BandUnvisible;
    }
}
