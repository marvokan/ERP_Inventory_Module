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
    public class CStore : CEntity<STORE>
    {
        [Key]
        public int Cid => this.Record.CID;

        public string STORE_LOC { get => this.Record.STORE_LOC; set => this.Record.STORE_LOC = value; }

    }
}
