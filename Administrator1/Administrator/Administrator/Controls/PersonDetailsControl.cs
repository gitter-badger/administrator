using System;
using Administrator.Data;
using Administrator.EventArgsReferences;
using DevExpress.XtraEditors;

namespace Administrator.Controls
{
    public partial class PersonDetailsControl : XtraUserControl
    {
        public event EventHandler<PersonExistanceCheckNededEventArgs> PersonExistanceCheckNeeded;

        private PersonList person;

        private bool isPhotoSet;

        public PersonDetailsControl()
        {
            InitializeComponent();
        }

        public PersonList Person
        {
            get
            {
                GetPersonInfo();
                return person;
            }
            set
            {
                person = value;
                SetPersonInfo();
            }
        }

        public object OrganizationListDataSource
        {
            set
            {
                organizationLookUpEdit.Properties.DataSource = value;   
            }
        }

        public Object[] PostListDataSource
        {
            set
            {
                if (value != null && value.Length > 0)
                {
                    postComboEdit.Properties.Items.AddRange(value);
                }
            }
        }

        private void GetPersonInfo()
        {
            person.Description = descriptionEdit.EditValue as string;
            person.Email = emailEdit.EditValue as string;
            person.FirstName = firstNameEdit.EditValue as string;
            person.Icq = isqEdit.EditValue as string;
            person.LastName = lastNameEdit.EditValue as string;
            person.Mobile = mobileEdit.EditValue as string;
            person.Phone = phoneEdit.EditValue as string;
            person.Sex = sexComboEdit.SelectedIndex == 0;
            person.Surname = surNameEdit.EditValue as string;
            person.Photo = isPhotoSet ? photoEdit.Image : null;
            person.Post = postComboEdit.EditValue as string;
            person.OrganizationID = (Guid)(organizationLookUpEdit.EditValue ?? Guid.Empty);
        }

        private void SetPersonInfo()
        {
            descriptionEdit.EditValue = person.Description;
            emailEdit.EditValue = person.Email;
            firstNameEdit.EditValue = person.FirstName;
            isqEdit.EditValue = person.Icq;
            lastNameEdit.EditValue = person.LastName;
            mobileEdit.EditValue = person.Mobile;
            phoneEdit.EditValue = person.Phone;
            postComboEdit.Text = person.Post;
            sexComboEdit.SelectedIndex = person.Sex ? 0 : 1;
            surNameEdit.EditValue = person.Surname;
            isPhotoSet = person.ImageID.HasValue;
            if (!isPhotoSet)
            {
                photoEdit.Image = person.Sex ? Properties.Resources.businessman2 : Properties.Resources.woman4;
            }
            else
            {
                photoEdit.Image = person.Photo;
            }

            if (person.OrganizationID != Guid.Empty)
            {
                organizationLookUpEdit.EditValue = person.OrganizationID;
            }

            postComboEdit.EditValue = person.Post;
        }

        private void OnPersonExistanceCheckNeeded(PersonExistanceCheckNededEventArgs e)
        {
            EventHandler<PersonExistanceCheckNededEventArgs> needed = PersonExistanceCheckNeeded;
            if (needed != null) needed(this, e);
        }

        private void PersonDetailsControl_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool firstNameError = String.IsNullOrEmpty(firstNameEdit.EditValue as string);
            bool lastNameError = String.IsNullOrEmpty(lastNameEdit.EditValue as string);
            bool surnameNameError = String.IsNullOrEmpty(surNameEdit.EditValue as string);

            ErrorProvider.SetError(lastNameEdit, lastNameError ? "Необходима ввести отчество" : null, true);
            ErrorProvider.SetError(firstNameEdit, firstNameError ? "Необходима ввести имя" : null, true);
            ErrorProvider.SetError(surNameEdit, surnameNameError ? "Необходима ввести фамилию" : null, true);


            e.Cancel = firstNameError | lastNameError | surnameNameError;

            if (e.Cancel) return;

            var existanceCheck =new PersonExistanceCheckNededEventArgs(
                new Person
                    {
                        FirstName = firstNameEdit.EditValue as string,
                        Surname = surNameEdit.EditValue as string
                    });
                
            OnPersonExistanceCheckNeeded(existanceCheck);

            ErrorProvider.SetError(firstNameEdit, existanceCheck.Exists ? "Человек с таким именем уже существует." : null, true);
            ErrorProvider.SetError(surNameEdit, existanceCheck.Exists ? "Человек с такой фамилией уже существует." : null, true);

            e.Cancel = existanceCheck.Exists;
        }

        private void sexComboEdit_EditValueChanged(object sender, EventArgs e)
        {
            if (!isPhotoSet)
            {
                photoEdit.Image = sexComboEdit.SelectedIndex == 0 ? Properties.Resources.businessman2 : Properties.Resources.woman4;
            }
        }

        private void photoEdit_DoubleClick(object sender, EventArgs e)
        {
            photoEdit.LoadImage();
            isPhotoSet = photoEdit.EditValue != null &&
                         photoEdit.EditValue != Properties.Resources.businessman2 &&
                         photoEdit.EditValue != Properties.Resources.woman4;
        }

        private void photoEdit_EditValueChanging(object sender, DevExpress.XtraEditors.Controls.ChangingEventArgs e)
        {
            if (e.NewValue == null)
            {
                e.NewValue = person.Sex ? Properties.Resources.businessman2 : Properties.Resources.woman4;
            }
        }

        private void surNameEdit_EditValueChanged(object sender, EventArgs e)
        {
            TextEdit edit = sender as TextEdit;
            if(edit == null) return;

            edit.EditValue = Utils.FirstLatterToUpper(edit.EditValue as string);
        }
    }
}
