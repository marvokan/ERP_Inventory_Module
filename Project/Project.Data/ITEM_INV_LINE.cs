namespace Inventory.Data
{
    public class ITEM_INV_LINE
    {
        public int ID { get; set; }

        public int ITEM_INV_ID { get; set; }

        public int? ITEM_ID { get; set; }

        public int? ITEM_PKG_ID { get; set; }

        public int STORE_POS_CID { get; set; }

        public float STORED_QTY { get; set; }

        public float DEFICIT_SURPLUS { get; set; }


    }
}
