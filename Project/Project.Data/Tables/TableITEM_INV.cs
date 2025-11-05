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
    public class TableITEM_INV : CDBTable<ITEM_INV>
    {
        public TableITEM_INV(string p_sTableName) : base(p_sTableName)
        {
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = this.DB.Select<ITEM_INV>("select * from ITEM_INV", p_iTransaction);
            this.records.Clear();
            if (oRecords != null)
                this.records = oRecords;
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<ITEM_INV>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into ITEM_INV
                                    (STORE_CID, REMARKS, STATUS, INV_DATETIM, PERSON)
                                  values
                                    (@STORE_CID, @REMARKS, @STATUS, @INV_DATETIME, @PERSON)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update ITEM_INV set
                                    STORE_CID = @STORE_CID,
                                    REMARKS = @REMARKS,
                                    STATUS = @STATUS,
                                    INV_DATETIME = @INV_DATETIME,
                                    PERSON = @PERSON
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from ITEM_INV where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
