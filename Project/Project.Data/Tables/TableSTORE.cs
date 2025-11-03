using Inventory.Data.Records;
using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Tables
{
    public class TableSTORE : CDBTable<STORE>
    {
        public TableSTORE(string p_sTableName) : base(p_sTableName)
        {
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = this.DB.Select<STORE>("select * from STORE", p_iTransaction);
            this.records.Clear();
            if (oRecords != null)
                this.records = oRecords;
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<STORE>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into STORE
                                    (STORE_LOC)
                                  values
                                    (@STORE_LOC)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update STORE set
                                    STORE_LOC = @STORE_LOC                 
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from STORE where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
