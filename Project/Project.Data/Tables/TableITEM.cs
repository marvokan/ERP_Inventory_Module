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
    public class TableITEM : CDBTable<ITEM>
    {
        
        public TableITEM() : base("Item")
        {
        }

       

        public override void LoadTable(IDbTransaction p_iTransaction)
        {
            var oRecords = this.DB.Select<ITEM>("select * from ITEM", p_iTransaction);

            // When a select returns no records a null object might be returned by the method
            if (oRecords != null)
            {
                this.records = oRecords;

                foreach (var oRecord in this.records)
                    Debug.WriteLine(oRecord.ToString());
            }
        }
        // --------------------------------------------------------------------------------------
        public override void LoadTable(IDbTransaction? p_iTransaction, int p_nMasterKeyValue)
        {

            this.records.Clear(); // Empty the existing records
                                  // We create an object to hold the ID parameter for the select statement

            ITEM? oParams = new ITEM();
            oParams.ITEM_CATEGORY_CID = p_nMasterKeyValue;

            var oRecords = this.DB.SelectWithParams<ITEM>(
                    "select * from ITEM where ITEM_CATEGORY_CID = @ITEM_CATEGORY_CID", oParams, p_iTransaction);

            // When a select returns no records a null object might be returned by the method
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
                this.DB.SaveChanges<ITEM>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into ITEM
                                    (CODE, DESCRIPTION, MEASUREMENT_UNIT_CID, ITEM_CATEGORY_CID, BASE_PRICE)
                                  values
                                    (@CODE, @DESCRIPTION, @MEASUREMENT_UNIT_CID, @ITEM_CATEGORY_CID, @BASE_PRICE)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update ITEM set
                                    CODE = @CODE,
                                    DESCRIPTION = @DESCRIPTION,
                                    MEASUREMENT_UNIT_CID = @MEASUREMENT_UNIT_CID,
                                    ITEM_CATEGORY_CID = @ITEM_CATEGORY_CID,
                                    BASE_PRICE = @BASE_PRICE
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from ITEM where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
