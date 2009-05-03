using System;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class BaseFrame : XtraForm
    {
        public BaseFrame()
        {
            InitializeComponent();
        }

        public TFrame CreateFrame<TFrame>() where TFrame:BaseFrame
        {
            var frame = (TFrame)Activator.CreateInstance(typeof(TFrame));

            frame.Document = this.Document;

            return frame;
        }

        public Document Document { get; set; }
    }
}