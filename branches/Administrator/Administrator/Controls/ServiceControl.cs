using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using Administrator.Frames;
using Administrator.Objects;
using DevExpress.XtraEditors;
using DevExpress.XtraTreeList;
using DevExpress.XtraTreeList.Nodes;

namespace Administrator.Controls
{
    public partial class ServiceControl : XtraUserControl
    {
        public event EventHandler DataSourceChanged;

        public event ServiceSelectionChangedHandler SelectedServiceChanged;

        public event ServiceUpdatedEvintHandler ServiceUpdated;

        public ServiceControl()
        {
            InitializeComponent();
        }

        public List<Service> AllServices
        {
            get
            {
                return GetServices(ServiceTree.Nodes);
            }
        }

        public Object DataSource
        {
            set
            {
                bool isDataSourceChanged = ServiceTree.DataSource != value;
                ServiceTree.DataSource = value;
                if (isDataSourceChanged) OnDataSourceChanged();
                if (ServiceTree.Nodes.Count > 0) ServiceTree.Selection.Clear();
            }
            get { return ServiceTree.DataSource; }
        }

        public void Select(Service service)
        {
            if (service == null) return;

            SelectService(ServiceTree.Nodes, service);
        }

        public void SelectServices(List<Guid> serviceIds)
        {
            if (serviceIds == null) return;

            foreach (TreeListNode listNode in GetNodesByServiceIds(ServiceTree.Nodes, serviceIds,false))
            {
                if (!ServiceTree.Selection.Contains(listNode))
                {
                    ServiceTree.Selection.Add(listNode);
                }
            }
            foreach (TreeListNode listNode in GetNodesByServiceIds(ServiceTree.Nodes, serviceIds, true))
            {
                if (ServiceTree.Selection.Contains(listNode))
                {
                    ServiceTree.Selection.Remove(listNode);
                }
            }
        }

        protected void OnDataSourceChanged()
        {
            if (DataSourceChanged != null) DataSourceChanged(this, EventArgs.Empty);
        }

        protected void OnSelectionChanged(SelectionChangedEventArgs e)
        {
            if (SelectedServiceChanged != null) SelectedServiceChanged(this, e);
        }

        protected void OnServiceUpdated(ServiceUpdatedEventArgs e)
        {
            if (ServiceUpdated != null) ServiceUpdated(this, e);
        }

        private void SelectService(TreeListNodes nodes, Service sService)
        {
            foreach (TreeListNode listNode in nodes)
            {
                if (listNode.Nodes.Count > 0) SelectService(listNode.Nodes, sService);

                ServiceTree service = GetServiceByNode(listNode);
                if (service == null || service.ParentId == Guid.Empty) continue;

                if (service.ServiceId == sService.ServiceId)
                {
                    listNode.Selected = true;
                    return;
                }
            }
        }

        private List<TreeListNode> GetNodesByServiceIds(TreeListNodes nodes, List<Guid> serviceIds, bool invert)
        {
            List<TreeListNode> result = new List<TreeListNode>();

            foreach (TreeListNode node in nodes)
            {
                if (node.Nodes.Count > 0) result.AddRange(GetNodesByServiceIds(node.Nodes, serviceIds,invert));

                ServiceTree service = GetServiceByNode(node);
                if (service == null || service.ParentId == Guid.Empty) continue;

                if (invert)
                {
                    if (!serviceIds.Contains(service.ServiceId)) result.Add(node);
                }
                else
                {
                    if (serviceIds.Contains(service.ServiceId)) result.Add(node);
                }
            }

            return result;
        }

        private List<Service> GetServices(TreeListNodes nodes)
        {
            List<Service> result = new List<Service>();

            foreach (TreeListNode listNode in nodes)
            {
                if (listNode.Nodes.Count > 0) result.AddRange(GetServices(listNode.Nodes));

                ServiceTree service = GetServiceByNode(listNode);
                if (service == null || service.ParentId == Guid.Empty) continue;

                Service s = new Service();

                s.ServiceId = service.ServiceId;
                s.Name = service.Name;

                result.Add(s);
            }

            return result;
        }

        private List<Service> GetSelectedServices()
        {
            List<Service> result = new List<Service>();

            foreach (TreeListNode listNode in ServiceTree.Selection)
            {
                ServiceTree service = GetServiceByNode(listNode);
                if (service == null || service.ParentId == Guid.Empty) continue;

                Service s = new Service();

                s.ServiceId = service.ServiceId;
                s.Name = service.Name;

                result.Add(s);
            }

            return result;
        }

        private List<ServiceType> GetServiceTypes(TreeListNodes nodes)
        {
            List<ServiceType> result = new List<ServiceType>();

            foreach (TreeListNode listNode in nodes)
            {
                if (listNode.Nodes.Count > 0) result.AddRange(GetServiceTypes(listNode.Nodes));

                ServiceTree service = GetServiceByNode(listNode);
                if (service == null || service.ParentId != Guid.Empty) continue;

                ServiceType s = new ServiceType();

                s.ServiceTypeId = service.ServiceId;
                s.Name = service.Name;

                result.Add(s);
            }

            return result;
        }

        private ServiceTree GetServiceByNode(TreeListNode listNode)
        {
            if (listNode == null) return null;

            ServiceTree st = new ServiceTree();

            st.ServiceId = (Guid)listNode["service_id"];
            st.ParentId = (Guid)listNode["service_type_id"];
            st.Name = (string)listNode["name"];

            return st;
        }

        private void ServiceTree_SelectionChanged(object sender, EventArgs e)
        {
            if (needRaseSelecttionChangedEvent)
                OnSelectionChanged(new SelectionChangedEventArgs(GetSelectedServices()));
        }

        private void MenuNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            using (ServiceDetailsForm form = new ServiceDetailsForm())
            {
                form.ServiceTypes = GetServiceTypes(ServiceTree.Nodes);

                if (form.ShowDialog() == DialogResult.OK)
                {
                    needRaseSelecttionChangedEvent = false;

                    OnServiceUpdated(new ServiceUpdatedEventArgs(form.CurrentServiceType, form.Service));
                    OnDataSourceChanged();
                    ServiceTree.Selection.Clear();

                    needRaseSelecttionChangedEvent = true;

                    Select(form.Service);
                }
            }
        }

        private bool needRaseSelecttionChangedEvent = true;

        private void ServiceTree_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            TreeListHitInfo info = ServiceTree.CalcHitInfo(new Point(e.X, e.Y));

            if (info.Node == null || info.HitInfoType == HitInfoType.Empty) return;

            ServiceTree serviceTree = GetServiceByNode(info.Node);
            ServiceTree parentNode = GetServiceByNode(info.Node.ParentNode);

            if (parentNode == null) return;

            using (ServiceDetailsForm form = new ServiceDetailsForm())
            {
                form.ServiceTypes = GetServiceTypes(ServiceTree.Nodes);

                form.CurrentServiceType = new ServiceType { Name = parentNode.Name, ServiceTypeId = parentNode.ServiceId };
                form.Service = new Service
                                   {
                                       Name = serviceTree.Name,
                                       ServiceId = serviceTree.ServiceId,
                                       ServiceTypeId = parentNode.ServiceId
                                   };

                if (form.ShowDialog() == DialogResult.OK)
                {
                    needRaseSelecttionChangedEvent = false;

                    OnServiceUpdated(new ServiceUpdatedEventArgs(form.CurrentServiceType, form.Service));
                    OnDataSourceChanged();
                    ServiceTree.Selection.Clear();

                    needRaseSelecttionChangedEvent = true;

                    Select(form.Service);
                }
            }
        }
    }

    public delegate void ServiceSelectionChangedHandler(Object sender, SelectionChangedEventArgs e);

    public class SelectionChangedEventArgs : EventArgs
    {
        public List<Service> Selection { get; set; }

        public SelectionChangedEventArgs(List<Service> selection)
        {
            Selection = selection;
        }
    }

    public delegate void ServiceUpdatedEvintHandler(Object sender, ServiceUpdatedEventArgs e);

    public class ServiceUpdatedEventArgs : EventArgs
    {
        public ServiceUpdatedEventArgs(ServiceType serviceType, Service service)
        {
            ServiceType = serviceType;
            Service = service;
        }

        public ServiceType ServiceType { get; private set; }
        public Service Service { get; private set; }

    }
}