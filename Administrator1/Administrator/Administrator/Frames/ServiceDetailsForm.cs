using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Administrator.Objects;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class ServiceDetailsForm : XtraForm
    {
        public ServiceDetailsForm()
        {
            InitializeComponent();
        }

        public List<ServiceType> ServiceTypes
        {
            //get { return null; }  
            set { ServiceTypeComboEdit.Properties.Items.AddRange(value); }
        }

        public ServiceType CurrentServiceType
        {
            set { ServiceTypeComboEdit.EditValue = value; }

            get
            {
                if(ServiceTypeComboEdit.EditValue == null) return null;

                ServiceType result = ServiceTypeComboEdit.EditValue as ServiceType;

                if(result == null)
                {
                    result = new ServiceType();
                    result.ServiceTypeId = Guid.NewGuid();
                    result.Name = ServiceTypeComboEdit.EditValue as string;
                    ServiceTypeComboEdit.EditValue = result;
                }

                return result;
            }
        }

        public Service Service
        {
            set
            {
                service = value;
                ServiceNameEdit.EditValue = value.Name;
            }
            get{return service;}
        }

        private void OkButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            if(Service == null)
            {
                service = new Service {ServiceId = Guid.NewGuid()};
            }

            Service.ServiceTypeId = CurrentServiceType.ServiceTypeId;
            Service.Name = ServiceNameEdit.EditValue as string;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void ServiceTypeComboEdit_Validating(object sender, CancelEventArgs e)
        {
            bool error = ServiceTypeComboEdit.EditValue == null;

            CustomErrorProvider.SetError(ServiceTypeComboEdit, error ? "Тип услуги не может быть пустым" : null, true);

            e.Cancel = error;
        }

        private void ServiceNameEdit_Validating(object sender, CancelEventArgs e)
        {
            bool error = string.IsNullOrEmpty(ServiceNameEdit.EditValue as string);

            CustomErrorProvider.SetError(ServiceNameEdit, error ? "Название услуги не может быть пустым" : null, true);

            e.Cancel = error;
        }

        private Service service;
    }

    
}