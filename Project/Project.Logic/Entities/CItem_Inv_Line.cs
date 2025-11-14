using Inventory.Data.Records;
using Lib.Common.Attribs;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Entities
{
    public class CItem_Inv_Line : CEntity<ITEM_INV_LINE>
    {
        [Key]
        [ColumnWidth(45)]
        public int Id => this.Record.ID;

        [ForeignKey("Master")]
        [ColumnWidth(30)]
        public int ITEM_INV_ID { get => this.Record.ITEM_INV_ID; set => this.Record.ITEM_INV_ID = value; }

        //public int ITEM_ID { get => this.Record.ITEM_ID; set => this.Record.ITEM_ID = value; }

        public int? ITEM_ID
        {
            get
            {
                if (this.Record.ITEM_ID == 0)
                    return -1;
                else
                    return this.Record.ITEM_ID;
            }
            set
            {
                if (value != null)
                    this.Record.ITEM_ID = value ?? -1;
                this.InvokePropertyChanged(nameof(ITEM_ID));
            }
        }

        public void LookupItem(List<CItem> p_oItems)
        {
            var oFound = p_oItems.Where(x => x.Id == this.ITEM_ID).ToList();
            if (oFound.Count > 0)
                this.Item = oFound[0];
            else
                this.Item = null;
        }

        [Browsable(false)]
        public CItem? Item { get; set; } = null;


        [ColumnWidth(200)]
        [DisplayName("Item Name")]
        public string ItemName
        {
            get
            {
                if (this.Item == null)
                    return "";
                else
                    return this.Item.DESCRIPTION;
            }
        }

        public int ITEM_PKG_ID { get => this.Record.ITEM_PKG_ID; set => this.Record.ITEM_PKG_ID = value; }

        public int STORE_POS_CID { get => this.Record.STORE_POS_CID; set => this.Record.STORE_POS_CID = value; }

        public float REPORTED_QTY { get => this.Record.REPORTED_QTY; set => this.Record.REPORTED_QTY = value; }

        public float ACTUAL_QTY { get => this.Record.ACTUAL_QTY; set => this.Record.ACTUAL_QTY = value; }

        public float PERSON { get => this.Record.DEFICIT_SURPLUS; set => this.Record.DEFICIT_SURPLUS = value; }

        public string? REMARKS { get => this.Record.REMARKS; set => this.Record.REMARKS = value; }
    }
}
