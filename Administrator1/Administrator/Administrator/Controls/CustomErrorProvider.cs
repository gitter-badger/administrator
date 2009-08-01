using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator.Controls
{
    [ProvideProperty("Required", typeof(BaseEdit))]
    [ToolboxBitmap(typeof(CustomErrorProvider), "CustomErrorProvider.bmp")]
    public partial class CustomErrorProvider : ErrorProvider
    {
        public CustomErrorProvider()
        {
            InitializeComponent();
        }

        public CustomErrorProvider(IContainer container)
        {
            container.Add(this);
            InitializeComponent();
        }

        [Browsable(true)]
        public void SetRequired(BaseEdit control, bool required)
        {
            if (control != null)
            {
                if (!_collection.ContainsKey(control) && required)
                {
                    control.HandleDestroyed += Control_HandleDestroyed;
                    control.Validating += Control_Validating;
                }

                BaseEdit edit = control;
                edit.InvalidValue += Edit_InvalidValue;

                _collection[control] = required;
            }
        }

        [Browsable(true)]
        public bool GetRequired(BaseEdit control)
        {
            return _collection.ContainsKey(control) ? _collection[control] : DefaultRequired;
        }

        public void SetError(BaseEdit control, string value, bool focusOnError)
        {
            bool error = value != null;
            SetError(control, value);
            if (error)
                control.Focus();
        }

        [Browsable(true)]
        public bool IgnoreOnCancel
        {
            get { return _ignoreOnCancel; }
            set { _ignoreOnCancel = value; }
        }


        private void Control_Validating(object sender, CancelEventArgs e)
        {
            BaseEdit control = sender as BaseEdit;
            if (control != null && _collection.ContainsKey(control))
            {
                bool iscancel = (control.FindForm().DialogResult == DialogResult.Cancel) && _ignoreOnCancel;
                bool error = !iscancel && _collection[control] && (control.EditValue == null || control.EditValue.ToString().Trim().Length == 0);
                SetError(control, error ? "Не указано значение обязательного поля" : null);
                e.Cancel = error;
                if (error)
                    control.Focus();
            }
        }

        private static void Edit_InvalidValue(object sender, DevExpress.XtraEditors.Controls.InvalidValueExceptionEventArgs e)
        {
            e.ExceptionMode = DevExpress.XtraEditors.Controls.ExceptionMode.NoAction;
        }

        private void Control_HandleDestroyed(object sender, EventArgs e)
        {
            BaseEdit control = sender as BaseEdit;
            if (control != null)
            {
                control.Disposed -= Control_HandleDestroyed;
                control.Validating -= Control_Validating;
                BaseEdit edit = control;
                edit.InvalidValue -= Edit_InvalidValue;
            }
        }

        private class ControlCollection : Dictionary<Control, bool> { }

        private ControlCollection _collection = new ControlCollection();

        private bool _ignoreOnCancel = true;

        private const bool DefaultRequired = false;
    }
}
