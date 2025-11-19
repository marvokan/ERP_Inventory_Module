using Inventory.Data.Records;
using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Tables
{
    public class TableITEM_INV : CDBTable<ITEM_INV>
    {

                public TableITEM_INV() : base("Item_Inv")
        {
        }

        public override void LoadRecord(int p_nKeyValue)
        {
            this.records.Clear(); // Empty the existing records

            // We create an object to hold the ID parameter for the select statement
            ITEM_INV? oParams = new ITEM_INV();
            oParams.ID = p_nKeyValue;


            using (var iTransaction = this.DB.BeginTransaction())
            {
                try
                {
                    var oRecords = this.DB.SelectWithParams<ITEM_INV>(
                            "select * from ZAPPUSER where ID = @ID", oParams, iTransaction);
                    iTransaction.Commit();

                    // When a select returns no records a null object might be returned by the method
                    if (oRecords != null)
                    {
                        this.records = oRecords;

                        foreach (var oRecord in this.records)
                            Debug.WriteLine(oRecord.ToString());
                    }
                }
                catch
                {
                    iTransaction.Rollback();
                    throw;
                }
            }
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {

            this.records.Clear();
            var oRecords = this.DB.Select<ITEM_INV>("select * from ITEM_INV", p_iTransaction);

            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<ITEM_INV>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into ITEM_INV
                                    (STORE_CID, REMARKS, STATUS, INV_DATETIME, PERSON)
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
