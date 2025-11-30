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
    public class TableITEM_PKG : CDBTable<ITEM_PKG>
    {
        public TableITEM_PKG() : base("ItemPkg")
        {
        }

        public override void LoadTable(IDbTransaction? p_iTransaction)
        {
            var oRecords = this.DB.Select<ITEM_PKG>("select * from ITEM_PKG", p_iTransaction);
            this.records.Clear();
            if (oRecords != null)
                this.records = oRecords;
        }

        public override void SaveTable(IDbTransaction? p_iTransaction)
        {
            if (this.records != null)
            {
                this.DB.SaveChanges<ITEM_PKG>(this.records,

                            // Provide the insert statement that will be used for new records
                            @"
                                  insert into ITEM_PKG
                                    (ITEM_ID, BARCODE, SERIAL_NUM, PACKAGE_TYPE_CID)
                                  values
                                    (@ITEM_ID, @BARCODE, @SERIAL_NUM, @PACKAGE_TYPE_CID)",

                            // Provide the update statement that will be used for updated records
                            @"
                                  update ITEM_PKG set
                                    ITEM_ID = @ITEM_ID,
                                    BARCODE = @BARCODE,
                                    SERIAL_NUM = @SERIAL_NUM,
                                    PACKAGE_TYPE_CID = @PACKAGE_TYPE_CID                     
                                  where 
                                    ID = @ID
                                ",

                            // Provide the delete statement that will be used for deleted records
                            "delete from ITEM_PKG where ID = @ID",

                            p_iTransaction
                        );

                this.LoadTable(p_iTransaction);
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
