using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Records
{
    public class STORE_POS : CDBRecord
    {
        [Key]
        public int CID { get; set; }

        public int STORE_CID { get; set; }

    }
}
