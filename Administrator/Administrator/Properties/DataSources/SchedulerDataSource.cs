using System;
using System.Collections.Generic;
using System.Text;
using DevExpress.Xpo.DB;

namespace Administrator.Properties.DataSources
{
    public class SchedulerDataSource 
    {
        public UpdateSchemaResult UpdateSchema(bool dontCreateIfFirstTableNotExist, params DBTable[] tables)
        {
            throw new System.NotImplementedException();
        }

        public SelectedData SelectData(params SelectStatement[] selects)
        {
            throw new System.NotImplementedException();
        }

        public ModificationResult ModifyData(params ModificationStatement[] dmlStatements)
        {
            throw new System.NotImplementedException();
        }

        public AutoCreateOption AutoCreateOption
        {
            get { throw new System.NotImplementedException(); }
        }
    }
}
