using Inventory.Data.Records;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Entities
{
    public class CStore_Pos : CEntity<STORE_POS>
    {
        [Key]
        public int Cid => this.Record.CID;

        public int STORE_CID { get => this.Record.STORE_CID; set => this.Record.STORE_CID = value; }

        public int STORE_ID { get => this.Record.STORE_ID; set => this.Record.STORE_ID = value; }

    }
}
