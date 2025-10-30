using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data
{
    public class ITEM
    {
        public int ID { get; set; }

        public required string CODE { get; set; }

        public int MEASUREMENT_UNIT_CID { get; set; }

        public int ITEM_CATEGORY_CID { get; set; }

    }
}
