using Lib.Data.Records;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Data.Records
{
    public class ITEM_INV_LINE : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public int ITEM_INV_ID { get; set; }

        public int ITEM_ID { get; set; }

        public int ITEM_PKG_ID { get; set; }

        public int STORE_POS_CID { get; set; }

        public float REPORTED_QTY { get; set; }

        public float ACTUAL_QTY { get; set; }

        public float DEFICIT_SURPLUS { get; set; }

        public string? REMARKS {  get; set; }


    }
}
