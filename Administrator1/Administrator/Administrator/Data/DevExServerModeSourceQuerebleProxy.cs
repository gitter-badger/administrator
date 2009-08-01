using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using log4net;

namespace NearDupe.Data
{
    public class DevExServerModeSourceQuerebleProxy : IQueryable, IQueryProvider
    {
        private static readonly ILog log = LogManager.GetLogger(typeof (DevExServerModeSourceQuerebleProxy));

        public event EntityQueriedEntityHandler EntityQueried;

        public DevExServerModeSourceQuerebleProxy(IQueryable querry)
        {
            query = querry;
            rootElementType = querry.ElementType;
        }

        private DevExServerModeSourceQuerebleProxy(IQueryable querry, EntityQueriedEntityHandler handler, Type elementType)
            : this(querry)
        {
            rootElementType = elementType;
            EntityQueried += handler;
        }

        private void OnNeedRefreshEntity(EntityQueriedEventArgs e)
        {
            if (EntityQueried != null) EntityQueried(this, e);
        }

        #region IQueryable<Person> Members

        Type IQueryable.ElementType
        {
            get { return query.ElementType; }
        }

        Expression IQueryable.Expression
        {
            get { return query.Expression; }
        }

        IQueryProvider IQueryable.Provider
        {
            get { return this; }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            // OnNeedRefreshEntity(new NeedRefreshEntityEventArgs(querry));

            // return querry.GetEnumerator();

            return ((IQueryProvider)this).Execute<IEnumerable>(query.Expression).GetEnumerator();
        }

        #endregion

        #region IQueryProvider Members

        IQueryable<TResult> IQueryProvider.CreateQuery<TResult>(Expression expression)
        {
            var tmp = query.Provider.CreateQuery<TResult>(expression);

// ReSharper disable SuspiciousTypeConversion.Global
            return (IQueryable<TResult>)new DevExServerModeSourceQuerebleProxy(tmp, EntityQueried, rootElementType);
// ReSharper restore SuspiciousTypeConversion.Global
        }

        IQueryable IQueryProvider.CreateQuery(Expression expression)
        {
            var tmp = query.Provider.CreateQuery(expression);

            return new DevExServerModeSourceQuerebleProxy(tmp, EntityQueried, rootElementType);
        }

        TResult IQueryProvider.Execute<TResult>(Expression expression)
        {
            IList list = new List<object>();

            var enumerator = ((IEnumerable)query.Provider.Execute<TResult>(expression)).GetEnumerator();

            while (enumerator.MoveNext())
            {
                list.Add(enumerator.Current);
            }

            if (list.Count > 0 && query.ElementType == rootElementType)
            {
                OnNeedRefreshEntity(new EntityQueriedEventArgs(list,query));
            }

            return (TResult)list;
        }

        object IQueryProvider.Execute(Expression expression)
        {
            try
            {
                return query.Provider.Execute(expression);
            }
            catch (Exception ex)
            {
                log.Error(ex);
                throw;
            }
            
        }

        #endregion

        #region members
        private readonly Type rootElementType;
        private readonly IQueryable query;
        #endregion members
    }

    public delegate void EntityQueriedEntityHandler(object sender, EntityQueriedEventArgs e);

    public class EntityQueriedEventArgs : EventArgs
    {
        public IList Entities { get; private set; }
        public IQueryable Query { get; private set; }

        public EntityQueriedEventArgs(IList entities, IQueryable query)
        {
            Entities = entities;
            Query = query;
        }
    }
}
