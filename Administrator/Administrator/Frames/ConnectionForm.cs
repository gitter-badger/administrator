using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class ConnectionForm : XtraForm
    {
        public ConnectionForm()
        {
            InitializeComponent();
        }

        public string ConnectionString
        {
            get
            {
                return connectionControl.ConnectionString;
            }
            set
            {
                connectionControl.ConnectionString = value;
            }
        }

        private void testButton_Click(object sender, EventArgs e)
        {
            if (Utils.CheckConnection(connectionControl.ConnectionString))
            {
                XtraMessageBox.Show("Соединение с базой данных успешно установленно.", "Проверка соединения",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
            else
            {
                XtraMessageBox.Show("Не удалось установить соедниение с базой данных.", "Проверка соединения",
                                    MessageBoxButtons.OK,
                                    MessageBoxIcon.Information);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            Close();
        }
    }
}