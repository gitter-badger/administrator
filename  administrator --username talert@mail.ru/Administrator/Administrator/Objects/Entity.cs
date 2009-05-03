using System;
using System.Collections.Generic;
using System.Data;


///Note: Need remove this class and all inherited classes
namespace Administrator.Objects
{
    public interface IEntity
    {
    }

    public class Entity : IEntity
    {
        public Entity()
        {
           _data = new Dictionary<string, object>();
        }

        protected T GetValue<T>(string name)
        {
            if(!_data.ContainsKey(name)) return default(T);

            return (T)(_data[name] == DBNull.Value ? default(T) : _data[name]);
        }

        protected void SetValue(string name, object value)
        {
            _data[name] = value;
        }

        //public Dictionary<string, object> Data
        //{
        //    get { return _data; }
        //    set { _data = value; }
        //}

        public static TEntity Assign<TEntity>(DataRow row) where TEntity: Entity
        {
            var entity = (TEntity)Activator.CreateInstance(typeof(TEntity));

            foreach (DataColumn column in row.Table.Columns)
            {
                entity._data.Add(column.ColumnName,row[column.ColumnName]);
            }

            return entity;
        }

        protected Dictionary<string ,object > _data;
    }
}
