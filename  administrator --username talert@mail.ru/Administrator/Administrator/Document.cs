using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using Administrator.Data;
using Administrator.Objects;
using Administrator.References;
using ALProjects.Core.Config;
using Person = Administrator.Objects.Person;

namespace Administrator
{
    public class Document
    {
        public Document()
        {
            ConnectionString = Settings.Default.ConnectionString;
        }

        public string ConnectionString
        {
            get { return connectionString; }
            set
            {
                connectionString = value;

                SqlConnectionStringBuilder builder = new SqlConnectionStringBuilder(value);

                builder.InitialCatalog = string.Empty;

                serverConnectionString = builder.ToString();
            }
        }

        public void UpdateDocument()
        {
            UpdatePersonList();
            UpdateServiceTreeList();
            UpdateEventList();
            UpdateAppointments();
        }

        public void CreateDataBase(string name)
        {
            using (IDbConnection connection = CreateConnectionToServer())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText =
                    @"
DECLARE @createSql nvarchar(50) SET @createSql ='CREATE DATABASE '+@dbName

IF NOT EXISTS(SELECT * FROM sys.databases WHERE [name] = @dbName)
BEGIN
	EXEC (@createSql)
END
";
                addParameter(command, "@dbName", name);
                command.ExecuteNonQuery();
            }
        }

        public Guid UpdatePerson(Person person)
        {
            if (person == null || person.PersonId == Guid.Empty) return Guid.Empty;

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();

                #region sqlStatement

                command.CommandText = @"
IF EXISTS(SELECT TOP 1 * FROM [dbo].[person] WHERE [person_id] = @person_id)
BEGIN
    UPDATE [dbo].[person]
       SET [first_name] = @first_name
          ,[last_name] = @last_name
          ,[surname] = @surname
          ,[phone] = @phone
          ,[mobile] = @mobile
          ,[email] = @email
          ,[icq] = @icq
          ,[sex] = @sex
          ,[description] = @description
    WHERE [person_id] =  @person_id
END
ELSE
    BEGIN
    INSERT INTO [dbo].[person]
               ([person_id] ,[first_name] ,[last_name]  ,[surname]  
               ,[phone]     ,[mobile]     ,[email]      ,[icq]      ,[sex]
               ,[description])
         VALUES
               (@person_id  ,@first_name  ,@last_name   ,@surname   
               ,@phone      ,@mobile      ,@email       ,@icq       ,@sex
               ,@description)
    END
";
                #endregion

                addParameter(command, "@person_id", person.PersonId);
                addParameter(command, "@first_name", person.FirstName);
                addParameter(command, "@last_name", person.LastName);
                addParameter(command, "@surname", person.Surname);
                addParameter(command, "@phone", person.Phone);
                addParameter(command, "@mobile", person.Mobile);
                addParameter(command, "@email", person.Email);
                addParameter(command, "@icq", person.Isq);
                addParameter(command, "@sex", person.Sex);
                addParameter(command, "@description", person.Description);

                command.ExecuteNonQuery();
            }

            UpdatePersonOrganizationRelation(person.PersonId, person.OrganizationId, person.Post);

            SetPhotoForPerson(person.PersonId, person.Photo, "photo");

            return person.PersonId;

        }

        public void UpdateEvent(Event ev)
        {
            if (ev == null) return;

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();

                #region sql statement

                command.CommandText = @"
IF EXISTS(SELECT TOP 1 * FROM [dbo].[event] WHERE [event_id] = @event_id)
UPDATE [dbo].[event]
   SET [contact_person_id] = @contact_person_id
      ,[manager_person_id] = @manager_person_id
      ,[name] = @name
      ,[type] = @type
      ,[person_number] = @person_number
      ,[review] = @review
      ,[price_cash] = @price_cash
      ,[price_non_cash] = @price_non_cash
      ,[loss] = @loss
      ,[description] = @description
      ,[state] = @state
      ,[registration_date] = @registration_date
      ,[exit_date] = @exit_date
      ,[organization_id] = @organization_id
 WHERE [event_id] = @event_id
ELSE
INSERT INTO [dbo].[event]
           ([event_id]           ,[contact_person_id]           ,[manager_person_id]           ,[name]
           ,[type]           ,[person_number]           ,[review]           ,[price_cash],[price_non_cash]
           ,[loss]           ,[description]           ,[state]      ,[organization_id],[registration_date],[exit_date])
     VALUES
           (@event_id           ,@contact_person_id           ,@manager_person_id           ,@name
           ,@type           ,@person_number           ,@review           ,@price_cash, @price_non_cash
           ,@loss           ,@description           ,@state , @organization_id,@registration_date,@exit_date)

";
                #endregion

                addParameter(command, "@event_id", ev.EventId);
                addParameter(command, "@contact_person_id", ev.ContactPersonId == Guid.Empty ? null : (object)ev.ContactPersonId);
                addParameter(command, "@manager_person_id", ev.ManagerPersonId == Guid.Empty ? null : (object)ev.ManagerPersonId);
                addParameter(command, "@organization_id", ev.OrganizationId == Guid.Empty ? null : (object)ev.OrganizationId);
                addParameter(command, "@person_number", ev.PersonNumber);
                addParameter(command, "@review", ev.Review);
                addParameter(command, "@price_cash", ev.CashPrice);
                addParameter(command, "@price_non_cash", ev.NonCashPrice);
                addParameter(command, "@loss", ev.Loss);
                addParameter(command, "@type", ev.Type);
                addParameter(command, "@name", ev.Name);
                addParameter(command, "@state", ev.State);
                addParameter(command, "@registration_date", ev.RegistrationDate);
                addParameter(command, "@exit_date", ev.ExitDate);
                addParameter(command, "@description", ev.Description);

                command.ExecuteNonQuery();
            }
        }

        public void CloseEvent(Guid eventId, EventStates state, Decimal cashPrice, Decimal nonCashPrice, Decimal loss, string overview)
        {
            if (eventId == Guid.Empty) return;

            using (IDbConnection connection = CreateConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    IDbCommand command = connection.CreateCommand();

                    command.Transaction = transaction;

                    command.CommandText = @"
UPDATE [dbo].[event]
   SET [review] = @overview
      ,[price_cash] = @price_cash
      ,[price_non_cash] = @price_non_cash
      ,[loss] = @loss
      ,[state] = @state
 WHERE [event_id] = @eventId
";
                    addParameter(command, "@eventId", eventId);
                    addParameter(command, "@state", state);
                    addParameter(command, "@price_cash", cashPrice);
                    addParameter(command, "@price_non_cash", nonCashPrice);
                    addParameter(command, "@loss", loss);
                    addParameter(command, "@overview", overview);
                    command.ExecuteNonQuery();

                    if (state == EventStates.Refuse)
                    {
                        command.Parameters.Clear();

                        command.CommandText = @"
DELETE FROM [dbo].[service_event]
      WHERE [event_id] = @eventId
";
                        addParameter(command, "@eventId", eventId);
                    }

                    command.ExecuteNonQuery();
                    transaction.Commit();
                }
            }
        }

        public Guid SetPhotoForPerson(Guid personId, Image photo, string name)
        {
            if (photo == null || personId == Guid.Empty) return Guid.Empty;

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
DECLARE @image_id uniqueidentifier 

SELECT @image_id = [image_id] FROM [dbo].[person] WHERE [person_id] = @person_id

IF (EXISTS(SELECT TOP 1 * FROM [dbo].[image] WHERE [image_id] = @image_id)) 
UPDATE [dbo].[image]
   SET [image_id] = @image_id  ,[data] = @data  ,[name] = @name
WHERE [image_id] = @image_id
ELSE
BEGIN
    SET @image_id = newId()

    INSERT INTO [dbo].[image]
		       ([image_id]   ,[data]    ,[name])
         VALUES
               (@image_id    ,@data     ,@name )
    
    UPDATE [dbo].[person]
    SET [image_id] = @image_id 
    WHERE [person_id] = @person_id;


    SELECT @image_id as [image_id]
END
                ";



                addParameter(command, "@person_id", personId);
                addParameter(command, "@data", Utils.ImgToBytes(photo));
                addParameter(command, "@name", name);

                return (Guid)(command.ExecuteScalar() ?? Guid.Empty);
            }
        }

        public void UpdateServiceAndType(ServiceType serviceType, Service service)
        {
            if (serviceType == null && service == null) return;

            using (IDbConnection connection = CreateConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    IDbCommand command = connection.CreateCommand();

                    command.Transaction = transaction;

                    if (serviceType != null)
                    {
                        #region SQL statement
                        command.CommandText = @"
IF NOT EXISTS (SELECT TOP(1) [service_type_id] FROM [dbo].[service_type] WHERE [service_type_id] = @service_type_id)
    INSERT INTO [dbo].[service_type]
               ([service_type_id]
               ,[name])
         VALUES
               (@service_type_id
               ,@service_type_name)
ELSE
    UPDATE [dbo].[service_type]
       SET [name] = @service_type_name
     WHERE [service_type_id] = @service_type_id
";
                        #endregion

                        addParameter(command, "@service_type_id", serviceType.ServiceTypeId);
                        addParameter(command, "@service_type_name", serviceType.Name);

                        command.ExecuteNonQuery();
                    }

                    if (service != null)
                    {
                        #region SQL statement
                        command.CommandText = @"
IF NOT EXISTS (SELECT TOP(1) [service_id] FROM [dbo].[service] WHERE [service_id] = @service_id)
    INSERT INTO [dbo].[service]
               ([service_id]
               ,[service_type_id]
               ,[name])
         VALUES
               (@service_id
               ,@service_type_id
               ,@service_name)
ELSE
    UPDATE [dbo].[service]
       SET [name] = @service_name
          ,[service_type_id] = @service_type_id
     WHERE [service_id] = @service_id 

";
                        #endregion

                        command.Parameters.Clear();

                        addParameter(command, "@service_type_id", service.ServiceTypeId);
                        addParameter(command, "@service_id", service.ServiceId);
                        addParameter(command, "@service_name", service.Name);

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void UpdateEventServiceRelation(List<EventServiceRelation> relations)
        {
            if (relations == null || relations.Count == 0) return;

            using (IDbConnection connection = CreateConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    foreach (EventServiceRelation relation in relations)
                    {
                        IDbCommand command = connection.CreateCommand();
                        command.Transaction = transaction;

                        command.CommandText = @"
IF NOT EXISTS(SELECT top(1) * FROM [dbo].[service_event] WHERE [service_event_id] = @appId)
    INSERT INTO [dbo].[service_event]
               ([event_id]
               ,[service_id]
               ,[start_date]
               ,[end_date]
               ,[description]
               ,[service_event_id])
         VALUES
               (@event_id
               ,@service_id
               ,@start_date
               ,@end_date
               ,@description,@appId)
ELSE
UPDATE [dbo].[service_event]
   SET [event_id] = @event_id
      ,[service_id] = @service_id
      ,[start_date] = @start_date
      ,[end_date] = @end_date
      ,[description] = @description
 WHERE [service_event_id] = @appId
";

                        addParameter(command, "@appId", relation.ServiceEventId);
                        addParameter(command, "@event_id", relation.EventId);
                        addParameter(command, "@service_id", relation.ServiceId);
                        addParameter(command, "@start_date", relation.StartDate);
                        addParameter(command, "@end_date", relation.EndDate);
                        addParameter(command, "@description", relation.Description);

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public void DelateEventServiceRelation(List<EventServiceRelation> relations)
        {
            if (relations == null || relations.Count == 0) return;

            using (IDbConnection connection = CreateConnection())
            {
                using (IDbTransaction transaction = connection.BeginTransaction())
                {
                    foreach (EventServiceRelation relation in relations)
                    {
                        IDbCommand command = connection.CreateCommand();
                        command.Transaction = transaction;

                        command.CommandText = @"
DELETE FROM [dbo].[service_event] WHERE [service_event_id] = @appId
";

                        addParameter(command, "@appId", relation.ServiceEventId);

                        command.ExecuteNonQuery();
                    }
                    transaction.Commit();
                }
            }
        }

        public Object[] GetPosts()
        {
            List<Object> result = new List<object>();

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT DISTINCT [post] FROM [person_organization] ORDER BY [post] ASC
                ";

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add(reader["post"]);
                    }
                }
            }

            return result.ToArray();
        }

        public List<Guid> GetServiceIdForEvent(Guid evintId)
        {
            List<Guid> result = new List<Guid>();

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT [s].[service_id] FROM [event] as [e]
INNER JOIN [dbo].[service_event] as s ON s.[event_id] = [e].[event_id]
WHERE [e].[event_id] = @event_id
                ";

                addParameter(command, "@event_id", evintId);

                using (IDataReader reader = command.ExecuteReader())
                {
                    while (reader.Read())
                    {
                        result.Add((Guid)reader["service_id"]);
                    }
                }
            }

            return result;
        }

        protected DataTable this[string tableName]
        {
            get
            {
                if (tables == null)
                {
                    tables = new Dictionary<string, DataTable>();
                }

                if (!tables.ContainsKey(tableName))
                {
                    tables.Add(tableName, new DataTable());
                }

                return tables[tableName];
            }
        }

        public DataTable AllPersons
        {
            get { return this[Person.TableName]; }
        }

        public DataTable AllServices
        {
            get { return this[ServiceTree.TableName]; }
        }

        public DataTable AllEvents
        {
            get { return this[Event.TableName]; }
        }

        public DataTable AllAppintments
        {
            get { return this[EventServiceRelation.TableName]; }
        }

        public void UpdatePersonList()
        {
            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT p.*, i.[data] as [photo], po.[organization_id], po.[post], o.[name] as [organization_name],
        p.surname + ' ' +  p.first_name + ' ' + p.last_name AS [SFL]
FROM [person] as p
LEFT OUTER JOIN [image] AS i ON i.[image_id] = p.[image_id]
LEFT OUTER JOIN [dbo].[person_organization] AS po ON po.[person_id] = p.[person_id]
LEFT OUTER JOIN [dbo].[organization] AS o ON o.[organization_id] = po.[organization_id]
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(command as SqlCommand);

                DataTable table = this[Person.TableName];

                adapter.FillSchema(table, SchemaType.Source);
                adapter.Fill(table);
                if (!table.Columns.Contains("image"))
                {
                    table.Columns.Add("image", typeof(Image));
                }
                foreach (DataRow row in table.Rows)
                {
                    if (row["photo"] != DBNull.Value)
                    {
                        row["image"] = Utils.BytesToImg((byte[])row["photo"]);
                        continue;
                    }
                    row["image"] = ((bool)row["sex"]) ? Properties.Resources.businessman2 : Properties.Resources.woman4;
                }
            }
        }

        public void UpdateServiceTreeList()
        {

            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT [s].[service_id], [st].[service_type_id], [s].[name]
    FROM [dbo].[service_type] AS [st]
    INNER JOIN [dbo].[service] AS [s] ON [s].[service_type_id] = [st].[service_type_id]
UNION ALL
    SELECT [service_type_id] AS [service_id], '00000000-0000-0000-0000-000000000000' AS [service_type_id], [name]
    FROM [dbo].[service_type]
                ";

                SqlDataAdapter adapter = new SqlDataAdapter(command as SqlCommand);

                adapter.FillSchema(this[ServiceTree.TableName], SchemaType.Mapped);
                this[ServiceTree.TableName].PrimaryKey = new[] { this[ServiceTree.TableName].Columns["service_id"] };
                adapter.Fill(this[ServiceTree.TableName]);
            }
        }

        public void UpdateEventList()
        {
            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT [e].* FROM [dbo].[event] as [e] --WHERE [state] = @state
                ";

                //addParameter(command, "@state", EventStates.Open);

                SqlDataAdapter adapter = CreateDataAdapter(command as SqlCommand);

                this[Event.TableName].AcceptChanges();

                if (this[Event.TableName].Columns.Count == 0)
                {
                    adapter.FillSchema(this[Event.TableName], SchemaType.Source);
                }
                adapter.Fill(this[Event.TableName]);
                UpdateData(this[Event.TableName]);
            }
        }

        public void UpdateAppointments()
        {
            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
SELECT [se].*, [e].[name] FROM [dbo].[service_event] as [se]
INNER JOIN [dbo].[event] as [e] ON [e].[event_id] = [se].[event_id]
                ";

                SqlDataAdapter adapter = CreateDataAdapter(command);

                this[EventServiceRelation.TableName].AcceptChanges();
                if (this[EventServiceRelation.TableName].Columns.Count == 0)
                {
                    adapter.FillSchema(this[EventServiceRelation.TableName], SchemaType.Source);
                }
                adapter.Fill(this[EventServiceRelation.TableName]);
                UpdateData(this[EventServiceRelation.TableName]);
            }
        }

        #region private methods

        private void UpdatePersonOrganizationRelation(Guid personId, Guid organizationId, string post)
        {
            using (IDbConnection connection = CreateConnection())
            {
                IDbCommand command = connection.CreateCommand();
                command.CommandText = @"
DELETE FROM [person_organization] WHERE person_id = @person_id

INSERT INTO [dbo].[person_organization]
           ([person_id]
           ,[organization_id]
           ,[post])
     VALUES
           (@person_id
           ,@organization_id
           ,@post)
                ";

                addParameter(command, "@person_id", personId);
                if (organizationId == Guid.Empty)
                {
                    addParameter(command, "@organization_id", null);
                }
                else
                {
                    addParameter(command, "@organization_id", organizationId);
                }

                addParameter(command, "@post", post);

                command.ExecuteNonQuery();
            }

        }

        private void UpdateData(DataTable table)
        {
            DataTable deleted = table.GetChanges(DataRowState.Unchanged);
            if (deleted != null)
            {
                DataColumn[] columns = table.PrimaryKey;
                if (columns != null && columns.Length != 0)
                {
                    foreach (DataRow row in deleted.Rows)
                    {
                        object[] keys = GetPrimaryKeyValue(row, columns);
                        DataRow found = table.Rows.Find(keys);
                        if (found != null)
                            table.Rows.Remove(found);
                    }
                }
            }
            table.AcceptChanges();
        }

        private object[] GetPrimaryKeyValue(DataRow row, IEnumerable<DataColumn> columns)
        {
            List<object> values = new List<object>();
            foreach (DataColumn column in columns)
                values.Add(row[column.ColumnName]);
            return values.ToArray();
        }

        private IDbConnection CreateConnection()
        {
            IDbConnection connection = new SqlConnection(ConnectionString);

            connection.Open();

            return connection;
        }

        private SqlDataAdapter CreateDataAdapter(IDbCommand command)
        {
            if (command is SqlCommand)
            {
                SqlDataAdapter adapter = new SqlDataAdapter((SqlCommand)command)
                                             {
                                                 AcceptChangesDuringFill = false,
                                                 AcceptChangesDuringUpdate = false
                                             };
                return adapter;
            }
            return null;
        }


        private IDbConnection CreateConnectionToServer()
        {

            IDbConnection connection = new SqlConnection(serverConnectionString);

            connection.Open();

            return connection;
        }

        private void addParameter(IDbCommand command, string name, object value)
        {
            IDbDataParameter param = command.CreateParameter();
            param.ParameterName = name;
            param.Value = value ?? DBNull.Value;
            if (!command.Parameters.Contains(param))
            {
                command.Parameters.Add(param);
            }
        }
        #endregion

        #region members
        private string connectionString;
        private string serverConnectionString;
        private Dictionary<string, DataTable> tables;
        #endregion

    }
}
