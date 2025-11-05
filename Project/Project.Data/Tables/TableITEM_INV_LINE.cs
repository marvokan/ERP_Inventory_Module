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
    public class TableITEM_INV_LINE : CDBTable<ITEM_INV_LINE>
    {
        public TableITEM_INV_LINE(string p_sTableName) : base(p_sTableName)
        {
        }
        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = this.DB.Select<ITEM_INV_LINE>("select * from ITEM_INV_LINE", p_iTransaction);
            this.records.Clear();
            if (oRecords != null)
                this.records = oRecords;
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<ITEM_INV_LINE>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into ITEM_INV_LINE
                                    (ITEM_INV_ID, ITEM_ID, ITEM_PKG_ID, STORE_POS_CID, REPORTED_QTY, ACTUAL_QTY, DEFICIT_SURPLUS, REMARKS)
                                  values
                                    (@ITEM_INV_ID, @ITEM_ID, @ITEM_PKG_ID, @STORE_POS_CID, @REPORTED_QTY, @ACTUAL_QTY, @DEFICIT_SURPLUS, @REMARKS)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update ITEM_INV_LINE set
                                    ITEM_INV_ID = @ITEM_INV_ID,
                                    ITEM_ID = @ITEM_ID,
                                    ITEM_PKG_ID = @ITEM_PKG_ID,
                                    STORE_POS_CID = @STORE_POS_CID,
                                    REPORTED_QTY = @REPORTED_QTY,
                                    ACTUAL_QTY = @ACTUAL_QTY,
                                    DEFICIT_SURPLUS = @DEFICIT_SURPLUS,
                                    REMARKS = @REMARKS
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from ITEM_INV_LINE where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
