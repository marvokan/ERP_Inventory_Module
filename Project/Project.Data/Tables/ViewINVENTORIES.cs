using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Inventory.Data.Records;
using Lib.Data.Records;


namespace Inventory.Data.Tables
{
    public class ViewINVENTORIES : CDBTable<V_INVENTORIES>
    {
        public ViewINVENTORIES() : base("ApplicationUsersView")
        {
        }
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            this.records.Clear(); // Empty the existing records

            var oRecords = this.DB.Select<V_INVENTORIES>("select * from V_INVENTORIES", p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
