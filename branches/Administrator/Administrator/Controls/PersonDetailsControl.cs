using System;
using System.Text;
using Administrator.Objects;
using DevExpress.XtraEditors;

namespace Administrator.Controls
{
    public partial class PersonDetailsControl : XtraUserControl
    {
        private Person person;

        private bool isPhotoSet;

        public PersonDetailsControl()
        {
            InitializeComponent();
        }

        public Person Person
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

        public Object OrganizationListDataSource
        {
            set { organizationLookUpEdit.Properties.DataSource = value; }
        }

        public Object[] PostListDataSource
        {
            set
            {
                postComboEdit.Properties.Items.AddRange(value);
            }
        }

        private void GetPersonInfo()
        {
            person.Description = descriptionEdit.EditValue as string;
            person.Email = emailEdit.EditValue as string;
            person.FirstName = firstNameEdit.EditValue as string;
            person.Isq = isqEdit.EditValue as string;
            person.LastName = lastNameEdit.EditValue as string;
            person.Mobile = mobileEdit.EditValue as string;
            person.Phone = phoneEdit.EditValue as string;
            person.Sex = sexComboEdit.SelectedIndex == 0;
            person.Surname = surNameEdit.EditValue as string;
            person.Photo = isPhotoSet ? photoEdit.Image : null;
            person.Post = postComboEdit.EditValue as string;
            person.OrganizationId = (Guid)(organizationLookUpEdit.EditValue ?? Guid.Empty);
        }

        private void SetPersonInfo()
        {
            descriptionEdit.EditValue = person.Description;
            emailEdit.EditValue = person.Email;
            firstNameEdit.EditValue = person.FirstName;
            isqEdit.EditValue = person.Isq;
            lastNameEdit.EditValue = person.LastName;
            mobileEdit.EditValue = person.Mobile;
            phoneEdit.EditValue = person.Phone;
            postComboEdit.Text = person.Post;
            sexComboEdit.SelectedIndex = person.Sex ? 0 : 1;
            surNameEdit.EditValue = person.Surname;
            isPhotoSet = person.ImageId != Guid.Empty;
            if (!isPhotoSet)
            {
                photoEdit.Image = person.Sex ? Properties.Resources.businessman2 : Properties.Resources.woman4;
            }
            else
            {
                photoEdit.Image = person.Photo;
            }

            if (person.OrganizationId != Guid.Empty)
            {
                organizationLookUpEdit.EditValue = person.OrganizationId;
            }

            postComboEdit.EditValue = person.Post;
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
