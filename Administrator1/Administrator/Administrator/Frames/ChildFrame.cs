using System.Drawing;

namespace Administrator.Frames
{
    public partial class ChildFrame : BaseFrame
    {
        public ChildFrame()
        {
            InitializeComponent();
        }

        public virtual Image Image
        {
            get { return Icon.ToBitmap(); }
        }

        public MainFrame MainForm { get; set; }
    }
}