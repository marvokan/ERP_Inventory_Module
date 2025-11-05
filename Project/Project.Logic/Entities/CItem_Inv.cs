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
    public class CItem_Inv : CEntity<ITEM_INV>
    {
        [Key]
        public int Id => this.Record.ID;
        public int STORE_CID { get => this.Record.STORE_CID; set => this.Record.STORE_CID = value; }

        public DateTime INV_DATETIME { get => this.Record.INV_DATETIME; set => this.Record.INV_DATETIME = value; }

        public string PERSON { get => this.Record.PERSON; set => this.Record.PERSON = value; }
    }
}
