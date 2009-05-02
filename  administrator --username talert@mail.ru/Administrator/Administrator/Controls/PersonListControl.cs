using System;
using System.Data;
using System.Windows.Forms;
using Administrator.Frames;
using Administrator.Objects;
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

        public object DataSource
        {
            set { personGrid.DataSource = value; }
        }

        public void FocusRow(Guid personId)
        {
            int handle = -1;

            for (int i = 0; i < MainView.RowCount; i++)
            {
                if ((Guid)MainView.GetRowCellValue(i, "person_id") == personId)
                {
                    handle = i;
                    break;
                }
            }

            if (handle != -1)
            {
                MainView.FocusedRowHandle = handle;
            }
        }

        public Person CurrentPerson
        {
            get
            {
                var row = (DataRowView)MainView1.GetRow(MainView1.FocusedRowHandle);

                return row == null ? null : Entity.Assign<Person>(row.Row);
            }
        }

        protected void OnPersonUpdated(PersonUpdateEventArgs e)
        {
            if (PersonUpdated != null) PersonUpdated(this, e);
        }

        private void EditPersonDetails(bool isNewPerson)
        {
            var baseFrame = this.ParentForm as BaseFrame;

            if (baseFrame == null)
            {
                throw new ApplicationException("MastBe placed in ChildFrame");
            }

            using (var form = baseFrame.CreateFrame<PersonDetailsFrame>())
            {
                if (isNewPerson)
                {
                    form.Person = new Person { PersonId = Guid.NewGuid() };
                }
                else
                {
                    if (CurrentPerson == null) return;
                    form.Person = CurrentPerson;

                }
                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnPersonUpdated(new PersonUpdateEventArgs(form.Person));
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
        private readonly Person person;

        public Person Person
        {
            get { return person; }
        }

        public PersonUpdateEventArgs(Person person)
        {
            this.person = person;
        }
    }
}
