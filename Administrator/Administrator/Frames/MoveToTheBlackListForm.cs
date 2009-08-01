using System;
using System.ComponentModel;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class MoveToTheBlackListForm : XtraForm
    {
        public MoveToTheBlackListForm()
        {
            InitializeComponent();
        }

        public string Reason
        {
            get { return DescriptionEdit.EditValue as string; }
        }

        private void DescriptionEdit_Validating(object sender, CancelEventArgs e)
        {
            var error = String.IsNullOrEmpty(DescriptionEdit.EditValue as string);

            if(error) Notification.NeedEnterBlackListReason();
            
            //ErrorProvider.SetError(DescriptionEdit,error?"Нужно ввести причину занесения в 'чёрный' список.":null,true);

            e.Cancel = error;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if(ValidateChildren())
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }
}