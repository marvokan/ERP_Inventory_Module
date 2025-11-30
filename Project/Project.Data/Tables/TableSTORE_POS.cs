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
    public class TableSTORE_POS : CDBTable<STORE_POS>
    {
        public TableSTORE_POS() : base("StorePos")
        {
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = this.DB.Select<STORE_POS>("select * from STORE_POS", p_iTransaction);
            this.records.Clear();
            if (oRecords != null)
                this.records = oRecords;
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<STORE_POS>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into STORE_POS
                                    (STORE_CID)
                                  values
                                    (@STORE_CID)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update STORE_POS set
                                    STORE_CID = @STORE_CID                
                                  where 
                                    CID = @CID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from STORE_POS where CID = @CID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
