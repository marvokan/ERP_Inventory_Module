using Lib.Logic;
using Inventory.Data.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Inventory.Logic.Entities
{
    public class CItem : CEntity<ITEM>
    {
        [Key]
        public int Id => this.Record.ID;
        public string Code { get => this.Record.CODE; set => this.Record.CODE = value; }

        public string DESCRIPTION { get => this.Record.DESCRIPTION; set => this.Record.DESCRIPTION = value; }

        public int Measurement_Unit_Cid { get => this.Record.MEASUREMENT_UNIT_CID; set => this.Record.MEASUREMENT_UNIT_CID = value; }

        public int Item_Category_Cid { get => this.Record.ITEM_CATEGORY_CID; set => this.Record.ITEM_CATEGORY_CID = value; }
    }
}
