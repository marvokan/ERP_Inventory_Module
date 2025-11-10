using System.Data;
using Lib.Data;
using Lib.Logic;
using Lib.Logic.Visitors;
using Inventory.Data; // Only depends on the data table factory and does not need to know the specific record classes


namespace Inventory.Logic
{
    public class CBaseModel<T> : List<T>, IModel where T : IEntity, new()
    {
        // ...........................................................
        protected IDBTable table;
        public IDBTable Table { get { return table; } }
        // ...........................................................
        protected string lastError = String.Empty;
        public string LastError { get { return lastError; } }
        // ...........................................................

        // ------------------------------------------------------------------
        public CBaseModel(String TableName)
        {
            this.table = CDataTableFactory.Instance.Produce(TableName)!; // [C#] The ! is the null-forgiving operator 
            if (this.table == null)
                throw new Exception($"Class for table identifier {TableName} is not registered with the data tier factory");
        }
        // ------------------------------------------------------------------
        public void Empty()
        {
            this.Clear();
            this.table.RecordSet.Clear();
        }
        // ------------------------------------------------------------------

        #region // IModel \\
        // ------------------------------------------------------------------
        public virtual void AcceptVisitAfterLoad(CVisitorToModel p_oVisitor)
        {
            p_oVisitor.VisitCopy(this.table, this);
        }
        // ------------------------------------------------------------------
        public virtual void AcceptVisitBeforeSave(CVisitorToTable p_oVisitor)
        {
            p_oVisitor.VisitAddNew(this, this.table);
        }
        // ------------------------------------------------------------------
        public virtual IEntity New()
        {
            throw new NotImplementedException();
        }
        // ------------------------------------------------------------------
        public virtual void Load()
        {
            throw new NotImplementedException();
        }
        // ------------------------------------------------------------------
        public virtual void Delete()
        {
            throw new NotImplementedException();
        }
        // ------------------------------------------------------------------
        public virtual int Save()
        {
            throw new NotImplementedException();
        }
        // ------------------------------------------------------------------
        #endregion
    }
}
