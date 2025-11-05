using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Records
{
    public class ITEM_INV : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public int STORE_CID { get; set; }

        public string? REMARKS { get; set; }

        public int STATUS { get; set; }

        public DateTime INV_DATETIME { get; set; }

        public string PERSON { get; set; }

    }
}
