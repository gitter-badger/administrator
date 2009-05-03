using System;
using Administrator.Controls;

namespace Administrator.Frames
{
    public partial class PersonPanel : ChildFrame
    {
        public PersonPanel()
        {
            InitializeComponent();
        }

        private void personListControl_PersonUpdateed(object sender, PersonUpdateEventArgs e)
        {
            //Document.UpdatePerson(e.Person);
            //Document.UpdateDocument();
            //personListControl.FocusRow(e.Person.PersonId);
            Program.CurrentDataContext.UpdateOrInsertPerson(e.Person);
        }

        private void PersonPanel_Shown(object sender, EventArgs e)
        {
            personListControl.DataSource = Program.CurrentDataContext.GetPersonsQuerry();
        }
    }
}