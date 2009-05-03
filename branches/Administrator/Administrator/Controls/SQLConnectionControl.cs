using System.Data.SqlClient;

namespace Administrator.Controls
{
    public partial class SQLConnectionControl : DevExpress.XtraEditors.XtraUserControl
    {
        public SQLConnectionControl()
        {
            InitializeComponent();
        }

        public string ConnectionString 
        { 
            get
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder();
                builder.DataSource = HostEdit.Text;
                builder.InitialCatalog = DatabaseEdit.Text;
                builder.UserID = UserEdit.Text;
                builder.Password = PasswordEdit.Text;
                builder.IntegratedSecurity = IntegratedAuthCheck.Checked;

                int connTimeout;
                if(int.TryParse(TimeoutConnectEdit.Text,out connTimeout))
                {
                    builder.ConnectTimeout = connTimeout;    
                }

                return builder.ToString();
            }
            set
            {
                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(value??string.Empty);
                HostEdit.Text = builder.DataSource;
                DatabaseEdit.Text = builder.InitialCatalog;
                UserEdit.Text = builder.UserID;
                PasswordEdit.Text = builder.Password;
                IntegratedAuthCheck.Checked = builder.IntegratedSecurity;
                TimeoutConnectEdit.Text = builder.ConnectTimeout.ToString();
            }
        }

        private void IntegratedAuthCheck_CheckedChanged(object sender, System.EventArgs e)
        {
            UserEdit.Enabled = PasswordEdit.Enabled = !IntegratedAuthCheck.Checked;
        }

    }
}
