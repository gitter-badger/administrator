using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Administrator.Controls
{
    public partial class PersonSelectorControl : DevExpress.XtraEditors.XtraUserControl
    {
        public PersonSelectorControl()
        {
            InitializeComponent();
        }

        private void LookUpEdit_ButtonClick(object sender, DevExpress.XtraEditors.Controls.ButtonPressedEventArgs e)
        {
            if(e.Button.Kind ==ButtonPredefines.Plus)
            {
                
            }
        }
    }
}
