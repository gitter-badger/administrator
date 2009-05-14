using System;
using System.Windows.Forms;
using Administrator.Data;
using Administrator.EventArgsReferences;

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
            get { return personDetailsControl.Person; }
            set { personDetailsControl.Person = value; }
        }

        public bool IsNewPerson { get; set; }

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

        private void personDetailsControl_PersonExistanceCheckNeeded(object sender, PersonExistanceCheckNededEventArgs e)
        {
            if (!IsNewPerson) return;

            Person person = Program.CurrentDataContext.GetPersonByName(e.Person.FirstName, e.Person.Surname);

            if (person == null) return;

            e.FindedPerson = person;
            e.Exists = true;

            if (Conformation.PersonAdding(person.FirstName, person.LastName, this))
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}