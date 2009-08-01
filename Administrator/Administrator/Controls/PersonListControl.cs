using System;
using System.Linq;
using System.Windows.Forms;
using Administrator.Data;
using Administrator.Frames;
using DevExpress.XtraEditors;
using log4net;

namespace Administrator.Controls
{
    public partial class PersonListControl : XtraUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(PersonListControl));

        public event PersonUpdatedDelegete PersonUpdated;

        public PersonListControl()
        {
            InitializeComponent();
            UpdateMenuState();
        }

        public IQueryable DataSource
        {
            set { LinqSource.QueryableSource = value; }
        }

        public void FocusRow(Guid personId)
        {
            MainView.FocusedRowHandle = MainView.LocateByValue(0, columnPersonId, personId);
        }

        public PersonList CurrentPerson
        {
            get
            {
                return MainView.GetRow(MainView.FocusedRowHandle) as PersonList;
            }
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

        private void OnPersonUpdated(PersonUpdateEventArgs e)
        {
            if (PersonUpdated != null) PersonUpdated(this, e);
        }

        private void EditPersonDetails(bool isNewPerson)
        {
            using (var form = new PersonDetailsFrame())
            {
                form.IsNewPerson = isNewPerson; 

                if (isNewPerson)
                {
                    form.Person = new PersonList { PersonID = Guid.NewGuid() };
                }
                else
                {
                    if (CurrentPerson == null) return;
                    form.Person = CurrentPerson;

                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnPersonUpdated(new PersonUpdateEventArgs(form.Person));
                    if (isNewPerson)
                    {
                        LinqSource.Reload();
                        FocusRow(form.Person.PersonID);
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
            editPersonBatton.Enabled = CurrentPerson != null;
        }

        private void newPersonBatton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPersonDetails(true);
        }

        private void editPersonBatton_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            EditPersonDetails(false);
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Conformation.PersonDelation)
            {
            
            }
        }

        private void MainView1_DoubleClick(object sender, EventArgs e)
        {
            EditPersonDetails(false);
        }

        private void MainView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            UpdateMenuState();
        }

    }

    public delegate void PersonUpdatedDelegete(object sender, PersonUpdateEventArgs e);

    public class PersonUpdateEventArgs : EventArgs
    {
        private readonly PersonList person;

        public PersonList Person
        {
            get { return person; }
        }

        public PersonUpdateEventArgs(PersonList person)
        {
            this.person = person;
        }
    }
}
