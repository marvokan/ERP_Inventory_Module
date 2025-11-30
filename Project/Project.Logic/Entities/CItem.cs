using Lib.Logic;
using Inventory.Data.Records;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace Inventory.Logic.Entities
{
    public class CItem : CEntity<ITEM>
    {
        [Key]
        public int Id => this.Record.ID;
        public string Code { get => this.Record.CODE; set => this.Record.CODE = value; }

        [DisplayName("Description")]
        [ReadOnly(true)]
        public string Description { get => this.Record.DESCRIPTION; set => this.Record.DESCRIPTION = value; }

        public int Measurement_Unit_Cid { get => this.Record.MEASUREMENT_UNIT_CID; set => this.Record.MEASUREMENT_UNIT_CID = value; }

        public int Item_Category_Cid { get => this.Record.ITEM_CATEGORY_CID; set => this.Record.ITEM_CATEGORY_CID = value; }


        [DisplayName("Base_Price")]
        [ReadOnly(true)]
        public float Base_Price { get => this.Record.BASE_PRICE; set => this.Record.BASE_PRICE = value; }
    }
}
