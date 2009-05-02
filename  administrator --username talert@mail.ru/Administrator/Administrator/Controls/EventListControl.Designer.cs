namespace Administrator.Controls
{
    partial class EventListControl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EventListControl));
            this.EventGrid = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.event_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.contact_person_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.manager_person_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.organization_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.registration_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.exit_date = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loss = new DevExpress.XtraGrid.Columns.GridColumn();
            this.person_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.review = new DevExpress.XtraGrid.Columns.GridColumn();
            this.price = new DevExpress.XtraGrid.Columns.GridColumn();
            this.description = new DevExpress.XtraGrid.Columns.GridColumn();
            this.type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TypeTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.state = new DevExpress.XtraGrid.Columns.GridColumn();
            this.StateTextEdit = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.StateImages = new DevExpress.Utils.ImageCollection(this.components);
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.Menu = new DevExpress.XtraBars.Bar();
            this.MenuNew = new DevExpress.XtraBars.BarButtonItem();
            this.MenuEdit = new DevExpress.XtraBars.BarButtonItem();
            this.CloseEventButton = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            ((System.ComponentModel.ISupportInitialize)(this.EventGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateImages)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.SuspendLayout();
            // 
            // EventGrid
            // 
            this.EventGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventGrid.Location = new System.Drawing.Point(0, 34);
            this.EventGrid.MainView = this.MainView;
            this.EventGrid.Name = "EventGrid";
            this.EventGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TypeTextEdit,
            this.StateTextEdit});
            this.EventGrid.Size = new System.Drawing.Size(572, 513);
            this.EventGrid.TabIndex = 0;
            this.EventGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.event_id,
            this.contact_person_id,
            this.manager_person_id,
            this.organization_id,
            this.name,
            this.registration_date,
            this.exit_date,
            this.loss,
            this.person_number,
            this.review,
            this.price,
            this.description,
            this.type,
            this.state});
            this.MainView.GridControl = this.EventGrid;
            this.MainView.Name = "MainView";
            this.MainView.OptionsView.ShowAutoFilterRow = true;
            this.MainView.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.MainView_FocusedRowChanged);
            this.MainView.CustomDrawCell += new DevExpress.XtraGrid.Views.Base.RowCellCustomDrawEventHandler(this.MainView_CustomDrawCell);
            this.MainView.DoubleClick += new System.EventHandler(this.MainView_DoubleClick);
            // 
            // event_id
            // 
            this.event_id.Caption = "event_id";
            this.event_id.FieldName = "event_id";
            this.event_id.Name = "event_id";
            this.event_id.OptionsColumn.AllowEdit = false;
            this.event_id.OptionsColumn.AllowFocus = false;
            this.event_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // contact_person_id
            // 
            this.contact_person_id.Caption = "contact_person_id";
            this.contact_person_id.FieldName = "contact_person_id";
            this.contact_person_id.Name = "contact_person_id";
            this.contact_person_id.OptionsColumn.AllowEdit = false;
            this.contact_person_id.OptionsColumn.AllowFocus = false;
            this.contact_person_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // manager_person_id
            // 
            this.manager_person_id.Caption = "manager_person_id";
            this.manager_person_id.FieldName = "manager_person_id";
            this.manager_person_id.Name = "manager_person_id";
            this.manager_person_id.OptionsColumn.AllowEdit = false;
            this.manager_person_id.OptionsColumn.AllowFocus = false;
            this.manager_person_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // organization_id
            // 
            this.organization_id.Caption = "organization_id";
            this.organization_id.FieldName = "organization_id";
            this.organization_id.Name = "organization_id";
            this.organization_id.OptionsColumn.AllowEdit = false;
            this.organization_id.OptionsColumn.AllowFocus = false;
            this.organization_id.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // name
            // 
            this.name.Caption = "Название";
            this.name.FieldName = "name";
            this.name.Name = "name";
            this.name.OptionsColumn.AllowEdit = false;
            this.name.OptionsColumn.AllowFocus = false;
            this.name.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.name.Visible = true;
            this.name.VisibleIndex = 1;
            this.name.Width = 78;
            // 
            // registration_date
            // 
            this.registration_date.Caption = "Заезд";
            this.registration_date.FieldName = "registration_date";
            this.registration_date.Name = "registration_date";
            this.registration_date.OptionsColumn.AllowEdit = false;
            this.registration_date.OptionsColumn.AllowFocus = false;
            this.registration_date.Visible = true;
            this.registration_date.VisibleIndex = 2;
            this.registration_date.Width = 78;
            // 
            // exit_date
            // 
            this.exit_date.Caption = "Выезд";
            this.exit_date.FieldName = "exit_date";
            this.exit_date.Name = "exit_date";
            this.exit_date.OptionsColumn.AllowEdit = false;
            this.exit_date.OptionsColumn.AllowFocus = false;
            this.exit_date.Visible = true;
            this.exit_date.VisibleIndex = 3;
            this.exit_date.Width = 78;
            // 
            // loss
            // 
            this.loss.Caption = "loss";
            this.loss.FieldName = "loss";
            this.loss.Name = "loss";
            this.loss.OptionsColumn.AllowEdit = false;
            this.loss.OptionsColumn.AllowFocus = false;
            // 
            // person_number
            // 
            this.person_number.Caption = "Кол-во участников";
            this.person_number.FieldName = "person_number";
            this.person_number.Name = "person_number";
            this.person_number.OptionsColumn.AllowEdit = false;
            this.person_number.OptionsColumn.AllowFocus = false;
            this.person_number.Visible = true;
            this.person_number.VisibleIndex = 4;
            this.person_number.Width = 78;
            // 
            // review
            // 
            this.review.Caption = "review";
            this.review.FieldName = "review";
            this.review.Name = "review";
            this.review.OptionsColumn.AllowEdit = false;
            this.review.OptionsColumn.AllowFocus = false;
            this.review.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            // 
            // price
            // 
            this.price.Caption = "price";
            this.price.FieldName = "price";
            this.price.Name = "price";
            this.price.OptionsColumn.AllowEdit = false;
            this.price.OptionsColumn.AllowFocus = false;
            // 
            // description
            // 
            this.description.Caption = "Заметки";
            this.description.FieldName = "description";
            this.description.Name = "description";
            this.description.OptionsColumn.AllowEdit = false;
            this.description.OptionsColumn.AllowFocus = false;
            this.description.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.False;
            this.description.Visible = true;
            this.description.VisibleIndex = 5;
            this.description.Width = 78;
            // 
            // type
            // 
            this.type.Caption = "Тип мероприятия";
            this.type.ColumnEdit = this.TypeTextEdit;
            this.type.FieldName = "type";
            this.type.Name = "type";
            this.type.OptionsColumn.AllowEdit = false;
            this.type.OptionsColumn.AllowFocus = false;
            this.type.OptionsColumn.AllowGroup = DevExpress.Utils.DefaultBoolean.True;
            this.type.Visible = true;
            this.type.VisibleIndex = 6;
            this.type.Width = 101;
            // 
            // TypeTextEdit
            // 
            this.TypeTextEdit.AutoHeight = false;
            this.TypeTextEdit.HideSelection = false;
            this.TypeTextEdit.Name = "TypeTextEdit";
            this.TypeTextEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.TypeTextEdit_CustomDisplayText);
            // 
            // state
            // 
            this.state.Caption = "Cтатус";
            this.state.ColumnEdit = this.StateTextEdit;
            this.state.FieldName = "state";
            this.state.ImageIndex = 0;
            this.state.MaxWidth = 80;
            this.state.MinWidth = 80;
            this.state.Name = "state";
            this.state.OptionsColumn.AllowEdit = false;
            this.state.OptionsColumn.AllowFocus = false;
            this.state.OptionsColumn.AllowSize = false;
            this.state.UnboundType = DevExpress.Data.UnboundColumnType.Integer;
            this.state.Visible = true;
            this.state.VisibleIndex = 0;
            this.state.Width = 80;
            // 
            // StateTextEdit
            // 
            this.StateTextEdit.AutoHeight = false;
            this.StateTextEdit.Name = "StateTextEdit";
            this.StateTextEdit.CustomDisplayText += new DevExpress.XtraEditors.Controls.CustomDisplayTextEventHandler(this.StateTextEdit_CustomDisplayText);
            // 
            // StateImages
            // 
            this.StateImages.ImageStream = ((DevExpress.Utils.ImageCollectionStreamer)(resources.GetObject("StateImages.ImageStream")));
            this.StateImages.Images.SetKeyName(0, "play_16.png");
            this.StateImages.Images.SetKeyName(1, "check2.png");
            this.StateImages.Images.SetKeyName(2, "delete2_16_16.png");
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.Menu});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuNew,
            this.CloseEventButton,
            this.MenuEdit});
            this.barManager1.MaxItemId = 3;
            // 
            // Menu
            // 
            this.Menu.BarName = "Tools";
            this.Menu.DockCol = 0;
            this.Menu.DockRow = 0;
            this.Menu.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.Menu.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MenuNew, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.MenuEdit, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.CloseEventButton, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.Menu.OptionsBar.AllowQuickCustomization = false;
            this.Menu.OptionsBar.DrawDragBorder = false;
            this.Menu.OptionsBar.UseWholeRow = true;
            this.Menu.Text = "Tools";
            // 
            // MenuNew
            // 
            this.MenuNew.Caption = "Создать мероприятие";
            this.MenuNew.Glyph = global::Administrator.Properties.Resources.add_16_16;
            this.MenuNew.Id = 0;
            this.MenuNew.Name = "MenuNew";
            this.MenuNew.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuNew_ItemClick);
            // 
            // MenuEdit
            // 
            this.MenuEdit.Caption = "Изменить данные";
            this.MenuEdit.Glyph = global::Administrator.Properties.Resources.edit_24_24;
            this.MenuEdit.Id = 2;
            this.MenuEdit.Name = "MenuEdit";
            this.MenuEdit.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuEdit_ItemClick);
            // 
            // CloseEventButton
            // 
            this.CloseEventButton.Caption = "Закрыть\\Отказ";
            this.CloseEventButton.Glyph = global::Administrator.Properties.Resources.tasks_24_24;
            this.CloseEventButton.Id = 1;
            this.CloseEventButton.Name = "CloseEventButton";
            this.CloseEventButton.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.CloseEventButton_ItemClick);
            // 
            // EventListControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.EventGrid);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "EventListControl";
            this.Size = new System.Drawing.Size(572, 547);
            ((System.ComponentModel.ISupportInitialize)(this.EventGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TypeTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateTextEdit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StateImages)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl EventGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar Menu;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem MenuNew;
        private DevExpress.XtraGrid.Columns.GridColumn event_id;
        private DevExpress.XtraGrid.Columns.GridColumn contact_person_id;
        private DevExpress.XtraGrid.Columns.GridColumn manager_person_id;
        private DevExpress.XtraGrid.Columns.GridColumn organization_id;
        private DevExpress.XtraGrid.Columns.GridColumn name;
        private DevExpress.XtraGrid.Columns.GridColumn loss;
        private DevExpress.XtraGrid.Columns.GridColumn person_number;
        private DevExpress.XtraGrid.Columns.GridColumn review;
        private DevExpress.XtraGrid.Columns.GridColumn price;
        private DevExpress.XtraGrid.Columns.GridColumn description;
        private DevExpress.XtraGrid.Columns.GridColumn type;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit TypeTextEdit;
        private DevExpress.XtraBars.BarButtonItem CloseEventButton;
        private DevExpress.XtraBars.BarButtonItem MenuEdit;
        private DevExpress.XtraGrid.Columns.GridColumn registration_date;
        private DevExpress.XtraGrid.Columns.GridColumn exit_date;
        private DevExpress.Utils.ImageCollection StateImages;
        private DevExpress.XtraGrid.Columns.GridColumn state;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit StateTextEdit;
    }
}
