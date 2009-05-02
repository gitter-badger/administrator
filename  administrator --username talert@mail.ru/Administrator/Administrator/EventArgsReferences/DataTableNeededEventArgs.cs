using System;
using System.Data;

namespace Administrator.EventArgsReferences
{
    public delegate void DataSourceNeededEventHandler(Object sender, DataSourceNeededEventArgs e);

    public class DataSourceNeededEventArgs : EventArgs
    {
        public DataSourceNeededEventArgs(object dataSource)
        {
            DataSource = dataSource;
        }

        public object DataSource { get; set; }
    }
}