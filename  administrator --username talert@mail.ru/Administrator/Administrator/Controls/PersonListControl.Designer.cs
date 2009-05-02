namespace Administrator.Controls
{
    partial class PersonListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonListControl));
            this.personGrid = new DevExpress.XtraGrid.GridControl();
            this.MainView1 = new DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView();
            this.gridBand2 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnPhoto = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.PictureEdit = new DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit();
            this.gridBand1 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnSurName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnFirstName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnLastName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand4 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnMobile = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnEmail = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnIcq = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand5 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnOrganizationName = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnPost = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.gridBand6 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnDescription = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MemoExEdit = new DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit();
            this.gridBand3 = new DevExpress.XtraGrid.Views.BandedGrid.GridBand();
            this.columnPersonId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.columnImageId = new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.barManager = new DevExpress.XtraBars.BarManager(this.components);
            this.personToolBar = new DevExpress.XtraBars.Bar();
            this.newPersonBatton = new DevExpress.XtraBars.BarButtonItem();
            this.editPersonBatton = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barSubItem1 = new DevExpress.XtraBars.BarSubItem();
            this.addPerson = new DevExpress.XtraBars.BarButtonItem();
            this.images = new DevExpress.Utils.ImageCollection(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoExEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).BeginInit();
            this.SuspendLayout();
            // 
            // personGrid
            // 
            this.personGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personGrid.Location = new System.Drawing.Point(0, 34);
            this.personGrid.MainView = this.MainView1;
            this.personGrid.Name = "personGrid";
            this.personGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.PictureEdit,
            this.MemoExEdit});
            this.personGrid.Size = new System.Drawing.Size(814, 425);
            this.personGrid.TabIndex = 0;
            this.personGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView1,
            this.MainView});
            // 
            // MainView1
            // 
            this.MainView1.Bands.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.GridBand[] {
            this.gridBand2,
            this.gridBand1,
            this.gridBand4,
            this.gridBand5,
            this.gridBand6,
            this.gridBand3});
            this.MainView1.Columns.AddRange(new DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn[] {
            this.columnPersonId,
            this.columnFirstName,
            this.columnLastName,
            this.columnSurName,
            this.columnPhoto,
            this.columnMobile,
            this.columnEmail,
            this.columnIcq,
            this.columnOrganizationName,
            this.columnPost,
            this.columnDescription,
            this.columnImageId});
            this.MainView1.GridControl = this.personGrid;
            this.MainView1.Name = "MainView1";
            this.MainView1.OptionsNavigation.AutoFocusNewRow = true;
            this.MainView1.OptionsView.AnimationType = DevExpress.XtraGrid.Views.Base.GridAnimationType.AnimateFocusedItem;
            this.MainView1.OptionsView.AutoCalcPreviewLineCount = true;
            this.MainView1.OptionsView.ColumnAutoWidth = true;
            this.MainView1.OptionsView.EnableAppearanceEvenRow = true;
            this.MainView1.OptionsView.EnableAppearanceOddRow = true;
            this.MainView1.OptionsView.ShowAutoFilterRow = true;
            this.MainView1.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MainView1_FocusedRowChanged);
            this.MainView1.DoubleClick += new System.EventHandler(this.MainView1_DoubleClick);
            // 
            // gridBand2
            // 
            this.gridBand2.Caption = "Фото";
            this.gridBand2.Columns.Add(this.columnPhoto);
            this.gridBand2.ImageAlignment = System.Drawing.StringAlignment.Center;
            this.gridBand2.Name = "gridBand2";
            this.gridBand2.RowCount = 2;
            this.gridBand2.Width = 73;
            // 
            // columnPhoto
            // 
            this.columnPhoto.ColumnEdit = this.PictureEdit;
            this.columnPhoto.FieldName = "image";
            this.columnPhoto.Name = "columnPhoto";
            this.columnPhoto.OptionsColumn.AllowEdit = false;
            this.columnPhoto.OptionsColumn.AllowFocus = false;
            this.columnPhoto.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnPhoto.OptionsColumn.AllowSize = false;
            this.columnPhoto.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.columnPhoto.OptionsColumn.FixedWidth = true;
            this.columnPhoto.OptionsColumn.ReadOnly = true;
            this.columnPhoto.RowCount = 3;
            this.columnPhoto.Visible = true;
            this.columnPhoto.Width = 73;
            // 
            // PictureEdit
            // 
            this.PictureEdit.Name = "PictureEdit";
            this.PictureEdit.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            // 
            // gridBand1
            // 
            this.gridBand1.Caption = "Основные данные";
            this.gridBand1.Columns.Add(this.columnSurName);
            this.gridBand1.Columns.Add(this.columnFirstName);
            this.gridBand1.Columns.Add(this.columnLastName);
            this.gridBand1.Name = "gridBand1";
            this.gridBand1.Width = 386;
            // 
            // columnSurName
            // 
            this.columnSurName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.columnSurName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.columnSurName.AppearanceCell.Options.UseFont = true;
            this.columnSurName.AppearanceCell.Options.UseForeColor = true;
            this.columnSurName.AppearanceCell.Options.UseTextOptions = true;
            this.columnSurName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnSurName.AppearanceHeader.Options.UseTextOptions = true;
            this.columnSurName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnSurName.Caption = "Фамилия";
            this.columnSurName.FieldName = "surname";
            this.columnSurName.Name = "columnSurName";
            this.columnSurName.OptionsColumn.AllowEdit = false;
            this.columnSurName.OptionsColumn.AllowFocus = false;
            this.columnSurName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnSurName.OptionsColumn.ReadOnly = true;
            this.columnSurName.RowCount = 2;
            this.columnSurName.Visible = true;
            this.columnSurName.Width = 386;
            // 
            // columnFirstName
            // 
            this.columnFirstName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.columnFirstName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.columnFirstName.AppearanceCell.Options.UseFont = true;
            this.columnFirstName.AppearanceCell.Options.UseForeColor = true;
            this.columnFirstName.AppearanceCell.Options.UseTextOptions = true;
            this.columnFirstName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFirstName.AppearanceHeader.Options.UseTextOptions = true;
            this.columnFirstName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnFirstName.Caption = "Имя";
            this.columnFirstName.FieldName = "first_name";
            this.columnFirstName.Name = "columnFirstName";
            this.columnFirstName.OptionsColumn.AllowEdit = false;
            this.columnFirstName.OptionsColumn.AllowFocus = false;
            this.columnFirstName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnFirstName.OptionsColumn.ReadOnly = true;
            this.columnFirstName.RowIndex = 1;
            this.columnFirstName.Visible = true;
            this.columnFirstName.Width = 193;
            // 
            // columnLastName
            // 
            this.columnLastName.AppearanceCell.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.columnLastName.AppearanceCell.ForeColor = System.Drawing.Color.Black;
            this.columnLastName.AppearanceCell.Options.UseFont = true;
            this.columnLastName.AppearanceCell.Options.UseForeColor = true;
            this.columnLastName.AppearanceCell.Options.UseTextOptions = true;
            this.columnLastName.AppearanceCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnLastName.AppearanceHeader.Options.UseTextOptions = true;
            this.columnLastName.AppearanceHeader.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.columnLastName.Caption = "Отчество";
            this.columnLastName.FieldName = "last_name";
            this.columnLastName.Name = "columnLastName";
            this.columnLastName.OptionsColumn.AllowEdit = false;
            this.columnLastName.OptionsColumn.AllowFocus = false;
            this.columnLastName.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnLastName.OptionsColumn.ReadOnly = true;
            this.columnLastName.RowIndex = 1;
            this.columnLastName.Visible = true;
            this.columnLastName.Width = 193;
            // 
            // gridBand4
            // 
            this.gridBand4.Caption = "Контактные данные";
            this.gridBand4.Columns.Add(this.columnMobile);
            this.gridBand4.Columns.Add(this.columnEmail);
            this.gridBand4.Columns.Add(this.columnIcq);
            this.gridBand4.Name = "gridBand4";
            this.gridBand4.Width = 246;
            // 
            // columnMobile
            // 
            this.columnMobile.Caption = "Сотовый";
            this.columnMobile.FieldName = "mobile";
            this.columnMobile.Name = "columnMobile";
            this.columnMobile.OptionsColumn.AllowEdit = false;
            this.columnMobile.OptionsColumn.AllowFocus = false;
            this.columnMobile.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnMobile.OptionsColumn.ReadOnly = true;
            this.columnMobile.Visible = true;
            this.columnMobile.Width = 246;
            // 
            // columnEmail
            // 
            this.columnEmail.Caption = "e-mail";
            this.columnEmail.FieldName = "email";
            this.columnEmail.Name = "columnEmail";
            this.columnEmail.OptionsColumn.AllowEdit = false;
            this.columnEmail.OptionsColumn.AllowFocus = false;
            this.columnEmail.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnEmail.OptionsColumn.ReadOnly = true;
            this.columnEmail.RowIndex = 1;
            this.columnEmail.Visible = true;
            this.columnEmail.Width = 246;
            // 
            // columnIcq
            // 
            this.columnIcq.Caption = "ICQ";
            this.columnIcq.FieldName = "icq";
            this.columnIcq.Name = "columnIcq";
            this.columnIcq.OptionsColumn.AllowEdit = false;
            this.columnIcq.OptionsColumn.AllowFocus = false;
            this.columnIcq.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnIcq.OptionsColumn.ReadOnly = true;
            this.columnIcq.RowIndex = 2;
            this.columnIcq.Visible = true;
            this.columnIcq.Width = 246;
            // 
            // gridBand5
            // 
            this.gridBand5.Caption = "Работа";
            this.gridBand5.Columns.Add(this.columnOrganizationName);
            this.gridBand5.Columns.Add(this.columnPost);
            this.gridBand5.Name = "gridBand5";
            this.gridBand5.Width = 299;
            // 
            // columnOrganizationName
            // 
            this.columnOrganizationName.Caption = "Организация";
            this.columnOrganizationName.FieldName = "organization_name";
            this.columnOrganizationName.Name = "columnOrganizationName";
            this.columnOrganizationName.OptionsColumn.AllowEdit = false;
            this.columnOrganizationName.OptionsColumn.AllowFocus = false;
            this.columnOrganizationName.OptionsColumn.ReadOnly = true;
            this.columnOrganizationName.Visible = true;
            this.columnOrganizationName.Width = 299;
            // 
            // columnPost
            // 
            this.columnPost.Caption = "Должность";
            this.columnPost.FieldName = "post";
            this.columnPost.Name = "columnPost";
            this.columnPost.OptionsColumn.AllowEdit = false;
            this.columnPost.OptionsColumn.AllowFocus = false;
            this.columnPost.OptionsColumn.ReadOnly = true;
            this.columnPost.RowCount = 2;
            this.columnPost.RowIndex = 1;
            this.columnPost.Visible = true;
            this.columnPost.Width = 299;
            // 
            // gridBand6
            // 
            this.gridBand6.Caption = "Заметки";
            this.gridBand6.Columns.Add(this.columnDescription);
            this.gridBand6.Name = "gridBand6";
            this.gridBand6.OptionsBand.AllowSize = false;
            this.gridBand6.OptionsBand.FixedWidth = true;
            this.gridBand6.Width = 52;
            // 
            // columnDescription
            // 
            this.columnDescription.ColumnEdit = this.MemoExEdit;
            this.columnDescription.FieldName = "description";
            this.columnDescription.Name = "columnDescription";
            this.columnDescription.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnDescription.OptionsColumn.AllowSize = false;
            this.columnDescription.OptionsColumn.AllowSort = DevExpress.Utils.DefaultBoolean.False;
            this.columnDescription.OptionsColumn.FixedWidth = true;
            this.columnDescription.RowCount = 3;
            this.columnDescription.Visible = true;
            this.columnDescription.Width = 52;
            // 
            // MemoExEdit
            // 
            this.MemoExEdit.AutoHeight = false;
            this.MemoExEdit.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.MemoExEdit.Name = "MemoExEdit";
            this.MemoExEdit.ReadOnly = true;
            // 
            // gridBand3
            // 
            this.gridBand3.Caption = "unvisible";
            this.gridBand3.Name = "gridBand3";
            this.gridBand3.Visible = false;
            this.gridBand3.Width = 114;
            // 
            // columnPersonId
            // 
            this.columnPersonId.Caption = "person_id";
            this.columnPersonId.FieldName = "person_id";
            this.columnPersonId.Name = "columnPersonId";
            this.columnPersonId.OptionsColumn.AllowEdit = false;
            this.columnPersonId.OptionsColumn.AllowFocus = false;
            this.columnPersonId.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.columnPersonId.OptionsColumn.ReadOnly = true;
            this.columnPersonId.Visible = true;
            this.columnPersonId.Width = 114;
            // 
            // columnImageId
            // 
            this.columnImageId.Caption = "image_id";
            this.columnImageId.FieldName = "image_id";
            this.columnImageId.Name = "columnImageId";
            this.columnImageId.Visible = true;
            // 
            // MainView
            // 
            this.MainView.GridControl = this.personGrid;
            this.MainView.Name = "MainView";
            // 
            // barManager
            // 
            this.barManager.AllowCustomization = false;
            this.barManager.AllowMoveBarOnToolbar = false;
            this.barManager.AllowQuickCustomization = false;
            this.barManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.personToolBar});
            this.barManager.DockControls.Add(this.barDockControlTop);
            this.barManager.DockControls.Add(this.barDockControlBottom);
            this.barManager.DockControls.Add(this.barDockControlLeft);
            this.barManager.DockControls.Add(this.barDockControlRight);
            this.barManager.Form = this;
            this.barManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barSubItem1,
            this.addPerson,
            this.newPersonBatton,
            this.editPersonBatton,
            this.barButtonItem3});
            this.barManager.MaxItemId = 5;
            // 
            // personToolBar
            // 
            this.personToolBar.BarName = "Tools";
            this.personToolBar.DockCol = 0;
            this.personToolBar.DockRow = 0;
            this.personToolBar.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.personToolBar.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.newPersonBatton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.editPersonBatton, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.barButtonItem3, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.personToolBar.OptionsBar.DisableClose = true;
            this.personToolBar.OptionsBar.DrawDragBorder = false;
            this.personToolBar.OptionsBar.UseWholeRow = true;
            this.personToolBar.Text = "Tools";
            // 
            // newPersonBatton
            // 
            this.newPersonBatton.Caption = "Новый сотрудник";
            this.newPersonBatton.Glyph = global::Administrator.Properties.Resources.add_user;
            this.newPersonBatton.Id = 2;
            this.newPersonBatton.Name = "newPersonBatton";
            this.newPersonBatton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.newPersonBatton_ItemClick);
            // 
            // editPersonBatton
            // 
            this.editPersonBatton.Caption = "Изменить данные";
            this.editPersonBatton.Glyph = global::Administrator.Properties.Resources.user;
            this.editPersonBatton.Id = 3;
            this.editPersonBatton.Name = "editPersonBatton";
            this.editPersonBatton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.editPersonBatton_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "Удалить сотрудника";
            this.barButtonItem3.Glyph = global::Administrator.Properties.Resources.delete_user;
            this.barButtonItem3.Id = 4;
            this.barButtonItem3.Name = "barButtonItem3";
            this.barButtonItem3.Visibility = DevExpress.XtraBars.BarItemVisibility.Never;
            this.barButtonItem3.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem3_ItemClick);
            // 
            // barSubItem1
            // 
            this.barSubItem1.Caption = "Сотрудники";
            this.barSubItem1.Id = 0;
            this.barSubItem1.Name = "barSubItem1";
            // 
            // addPerson
            // 
            this.addPerson.Caption = "Новый сотрудник";
            this.addPerson.Glyph = global::Administrator.Properties.Resources.add_user;
            this.addPerson.Id = 1;
            this.addPerson.Name = "addPerson";
            // 
            // images
            // 
            this.images.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("images.ImageStream")));
            // 
            // PersonListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.personGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "PersonListControl";
            this.Size = new System.Drawing.Size(814, 459);
            ((System.ComponentModel.ISupportInitialize)(this.personGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PictureEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MemoExEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.images)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl personGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraBars.BarManager barManager;
        private DevExpress.XtraBars.Bar personToolBar;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarSubItem barSubItem1;
        private DevExpress.XtraBars.BarButtonItem addPerson;
        private DevExpress.Utils.ImageCollection images;
        private DevExpress.XtraGrid.Views.BandedGrid.AdvBandedGridView MainView1;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand1;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnPersonId;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnFirstName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnSurName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnLastName;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand2;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnPhoto;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand3;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand4;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnMobile;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnEmail;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnIcq;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand5;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnOrganizationName;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnPost;
        private DevExpress.XtraEditors.Repository.RepositoryItemPictureEdit PictureEdit;
        private DevExpress.XtraGrid.Views.BandedGrid.GridBand gridBand6;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnDescription;
        private DevExpress.XtraEditors.Repository.RepositoryItemMemoExEdit MemoExEdit;
        private DevExpress.XtraBars.BarButtonItem newPersonBatton;
        private DevExpress.XtraBars.BarButtonItem editPersonBatton;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraGrid.Views.BandedGrid.BandedGridColumn columnImageId;

    }
}
