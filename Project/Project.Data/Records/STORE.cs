using Lib.Data.Records;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Data.Records
{
    public class STORE : CDBRecord
    {
        [Key]
        public int CID { get; set; }

        public string STORE_LOC { get; set; }

    }
}
