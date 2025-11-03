using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Records
{
    public class ITEM_PKG : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public int ITEM_ID { get; set; }

        public string BARCODE { get; set; }

        public long SERIAL_NUM { get; set; }

        public int PACKAGE_TYPE_CID { get; set; }

    }
}
