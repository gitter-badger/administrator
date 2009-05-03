using System;
using System.Linq;
using System.Windows.Forms;
using Administrator.Data;

namespace Administrator.Frames
{
    public partial class PersonDetailsFrame : BaseFrame
    {
        public PersonDetailsFrame()
        {
            InitializeComponent();
        }

        public PersonList Person
        {
            get {  return personDetailsControl.Person; }
            set {  personDetailsControl.Person = value; }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void PersonDetailsFrame_Shown(object sender, EventArgs e)
        {
            personDetailsControl.OrganizationListDataSource = Program.CurrentDataContext.AllOrganizations;
            personDetailsControl.PostListDataSource = Program.CurrentDataContext.Posts();
        }
    }
}