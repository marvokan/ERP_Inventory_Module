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
        public TableSTORE_POS(string p_sTableName) : base(p_sTableName)
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
                                    (STORE_CID, STORE_ID)
                                  values
                                    (@STORE_CID, @STORE_ID)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update STORE_POS set
                                    STORE_CID = @STORE_CID,
                                    STORE_ID = @STORE_ID                   
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from STORE_POS where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
