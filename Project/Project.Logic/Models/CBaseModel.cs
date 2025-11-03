using System.Data;
using Lib.Data;
using Lib.Logic;
using Lib.Logic.Visitors;

using Inventory.Data; // Only depends on the data table factory and does not need to know the specific record classes


namespace Inventory.Logic.Models
{
    public class CBaseModel<T>: List<T> where T: IEntity, new()
    {
        protected IDBTable table;
        // ...........................................................
        private string _lastError = String.Empty;
        public string LastError { get { return _lastError; } }
        // ...........................................................

        // ------------------------------------------------------------------
        public CBaseModel(String TableName)
        {
           // this.table = CDataTableFactory.Instance.Produce(TableName)!; // [C#] The ! is the null-forgiving operator 
        }
        // ------------------------------------------------------------------
        public void Load()
        {
            this.table.LoadTable(null);
        }
        // ------------------------------------------------------------------
        public bool Save()
        {
            bool bResult = false;
            IDbTransaction iTransaction = this.table.DB.BeginTransaction();
            try
            {
                this.table.SaveTable(iTransaction);
                iTransaction.Commit();
                bResult = true;
            }
            catch (Exception oException)
            {
                iTransaction.Rollback();
                this._lastError = oException.Message;
            }
            return bResult;
        }
        // ------------------------------------------------------------------
        public void AcceptVisitAfterLoad(CVisitorToModel p_oVisitor)
        {
            p_oVisitor.VisitCopy(this.table, this);
        }
        // ------------------------------------------------------------------
        public void AcceptVisitBeforeSave(CVisitorToTable p_oVisitor) 
        {
            p_oVisitor.VisitAddNew(this, this.table);
        }
        // ------------------------------------------------------------------
    }
}
