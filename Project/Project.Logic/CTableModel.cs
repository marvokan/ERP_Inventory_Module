using Lib.Logic;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic
{
    public class CTableModel<T> : CBaseModel<T> where T : IEntity, new()
    {
        // ------------------------------------------------------------------
        public CTableModel(string TableName) : base(TableName)
        {
        }
        // ------------------------------------------------------------------
        public override void Load() => this.table.LoadTable(null);
        // ------------------------------------------------------------------
        public override int Save()
        {
            int nResult = -1;
            IDbTransaction iTransaction = this.table.DB.BeginTransaction();
            try
            {
                this.table.SaveTable(iTransaction);
                iTransaction.Commit();
                nResult = 0;
            }
            catch
            {
                iTransaction.Rollback();
                throw;
            }
            return nResult;
        }
        // ------------------------------------------------------------------
    }
}
