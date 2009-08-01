using System;
using System.Drawing;
using System.Windows.Forms;
using Administrator.Properties;
using Administrator.References;
using DevExpress.XtraTabbedMdi;

namespace Administrator.Frames
{
    public partial class MainFrame : BaseFrame
    {
        public MainFrame()
        {
            InitializeComponent();
            Document = new Document();
        }

        private void barButtonItem1_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            Application.Exit();
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            Document.UpdateDocument();

            AddOrFocusChild<MainPanel>();

            Program.ConnectionStringChanged += Program_ConnectionStringChanged;
        }

        public void AddOrFocusChild<TChildForm>() where TChildForm : ChildFrame
        {
            foreach (var obj in MdiChildren)
            {
                if (obj.GetType() == typeof(TChildForm))
                {
                    obj.Focus();
                    return;
                }

            }

            var form = Activator.CreateInstance(typeof(TChildForm)) as TChildForm;
            if (form != null)
            {
                form.MdiParent = this;
                form.Document = Document;
                form.MainForm = this;
                form.Show();
            }
        }

        private void Program_ConnectionStringChanged(object sender, EventArgs e)
        {
            Document.AllServices.Rows.Clear();
            Document.AllAppintments.Rows.Clear();
            Document.AllEvents.Rows.Clear();
            Document.ConnectionString = Settings.Default.ConnectionString;
            Document.UpdateDocument();
        }

        private void MdiManager_PageAdded(object sender, MdiTabPageEventArgs e)
        {
            e.Page.Image = new Bitmap(e.Page.MdiChild.Icon.ToBitmap(), 16, 16);
        }

        private void MenuRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Document.UpdateDocument();
        }

        private void menuConnectionSettings_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            switch(Program.SetUpConnection(true))
            {
                case ConnectionSetUpStates.NoChanges:
                case ConnectionSetUpStates.Established:
                    break;
                case ConnectionSetUpStates.UpdateError:
                case ConnectionSetUpStates.FatalError:
                    Notification.CantEstablishConnection();
                    Application.Exit();    
                    break;
            }


            Document.UpdateDocument();
        }
    }
}
