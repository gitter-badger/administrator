using System;

namespace Administrator.Frames
{
    public partial class MainPanel : ChildFrame
    {
        public MainPanel()
        {
            InitializeComponent();
        }

        private void organizationButton_Click(object sender, EventArgs e)
        {
            MainForm.AddOrFocusChild<OrganizationPanel>();
        }

        private void personButton_Click(object sender, EventArgs e)
        {
            MainForm.AddOrFocusChild<PersonPanel>();
        }

        private void eventsButton_Click(object sender, EventArgs e)
        {
            MainForm.AddOrFocusChild<SchedulerPanel>();
        }

        private void reportButton_Click(object sender, EventArgs e)
        {
            MainForm.AddOrFocusChild<ReportPanel>();
        }
    }
}