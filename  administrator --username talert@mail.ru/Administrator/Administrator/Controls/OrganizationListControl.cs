using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Administrator.Data;
using Administrator.EventArgsReferences;
using Administrator.Frames;
using Administrator.References;
using DevExpress.Data.Linq.Helpers;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraScheduler;
using log4net;

namespace Administrator.Controls
{
    public partial class OrganizationListControl : XtraUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(OrganizationListControl));

        public event OrganizationUpdatedDelegete OrganizationUpdated;
        public event MovedToBlackListEventHandler MovedToBlackList;
        public event MovedFromBlackListEventHandler MovedFromBlackList;


        public OrganizationListControl()
        {
            InitializeComponent();

            UpdateMenuState();
        }

        public OrganizationList CurrentOrganization
        {
            get
            {
                return MainView.GetRow(MainView.FocusedRowHandle) as OrganizationList;
            }
        }

        public IQueryable DataSource
        {
            get { return LinqSource.QueryableSource; }
            set { LinqSource.QueryableSource = value; }
        }

        public void FocusRow(string shortName)
        {
            MainView.FocusedRowHandle = MainView.LocateByValue(0, shortNameColumn, shortName);
        }

        public void ReloadData()
        {
            var focused = MainView.FocusedRowHandle;
            LinqSource.Reload();
            MainView.RefreshData();
            MainView.FocusedRowHandle = focused;
            MainView.SelectRow(focused);
            UpdateMenuState();
        }

        private void OnOrganizationUpdated(OrganizationUpdatedEventArgs e)
        {
            if (OrganizationUpdated != null) OrganizationUpdated(this, e);
        }

        private void OnMovedToBlackList(MovedToBlackListEventArgs e)
        {
            MovedToBlackListEventHandler list = MovedToBlackList;
            if (list != null) list(this, e);
        }

        private void OnMovedFromBlackList(MovedFromBlackListEventArgs e)
        {
            if (MovedFromBlackList != null) MovedFromBlackList(this, e);
        }

        private void EditOrganizationDetails(bool isNewOrganization)
        {
            using (var form = new OrganizationDetailsFrame())
            {
                form.IsNewOrganization = isNewOrganization;

                if (!isNewOrganization)
                {
                    form.Organization = CurrentOrganization;
                }
                else
                {
                    form.Organization = new OrganizationList { OrganizationID = Guid.NewGuid() };
                }

                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnOrganizationUpdated(new OrganizationUpdatedEventArgs(form.Organization));

                    if (isNewOrganization)
                    {
                        LinqSource.Reload();
                        FocusRow(form.Organization.ShortName);
                    }
                    else
                    {
                        ReloadData();
                    }
                }
            }
        }

        private void UpdateMenuState()
        {
            MenuEdit.Enabled = CurrentOrganization != null;
            menuBlackList.Enabled = CurrentOrganization != null;
            if(CurrentOrganization != null)
            {
                menuBlackList.Glyph = CurrentOrganization.IsInBlackList
                                          ? Properties.Resources.funny_face_24
                                          : Properties.Resources.sad_face_24;

                menuBlackList.Caption = CurrentOrganization.IsInBlackList
                                            ?
                                                "Из чёрного списка"
                                            :
                                                "В чёрный список";
            }
        }

        private void MenuNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOrganizationDetails(true);
        }

        private void MainView_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateMenuState();
        }

        private void MenuEdit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditOrganizationDetails(false);
        }

        private void MainView_DoubleClick(object sender, EventArgs e)
        {
            EditOrganizationDetails(false);
        }

        private void menuBlackList_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if(CurrentOrganization == null) return;

            if (!CurrentOrganization.IsInBlackList)
            {
                using (var form = new MoveToTheBlackListForm())
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        OnMovedToBlackList(new MovedToBlackListEventArgs(CurrentOrganization.OrganizationID, form.Reason));
                        ReloadData();
                    }
                    
                }
            }
            else
            {
                if(Conformation.RestoreFromBlackList)
                {
                    OnMovedFromBlackList(new MovedFromBlackListEventArgs(CurrentOrganization.OrganizationID));
                    ReloadData();
                }
            }
        }
    }

    public delegate void OrganizationUpdatedDelegete(object sender, OrganizationUpdatedEventArgs e);

    public class OrganizationUpdatedEventArgs : EventArgs
    {
        protected readonly OrganizationList organization;

        public OrganizationUpdatedEventArgs(OrganizationList organization)
        {
            this.organization = organization;
        }

        public OrganizationList Organization
        {
            get { return organization; }
        }
    }
}
