using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Records
{
    public class V_INVENTORIES : CDBRecord
    {
        [Key]
        public int ID { get; set; }

        public string STORE_LOCATION { get; set; }

        public DateTime INV_DATETIME { get; set; }

        public string PERSON { get; set; }

        public float TOTAL_INVENTORY_VALUE { get; set; }

    }
}
