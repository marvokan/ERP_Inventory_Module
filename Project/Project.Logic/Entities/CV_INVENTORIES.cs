using Inventory.Data.Records;
using Lib.Common.Attribs;
using Lib.Logic;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Entities
{
    public class CV_INVENTORIES : CEntity<V_INVENTORIES>
    {
        [Key]
        [ReadOnly(true)]
        [ColumnWidth(30)]
        public int Id { get => this.Record.ID; set => this.Record.ID = value; }

        [DisplayName("Store Location")]
        [ReadOnly(true)]
        [ColumnWidth(250)]
        public string StoreLocation { get => this.Record.STORE_LOCATION ?? ""; set => this.Record.STORE_LOCATION = value; }

        [DisplayName("Inventory Date")]
        [ReadOnly(true)]
        [ColumnWidth(250)]
        public DateTime InventoryDate { get => this.Record.INV_DATETIME; set => this.Record.INV_DATETIME = value; }

        [DisplayName("Person")]
        [ColumnWidth(175)]
        [ReadOnly(true)]
        public string Person
        {
            get => this.Record.PERSON ?? "";
            set => this.Record.PERSON = value;
        }

        [DisplayName("Total Inventory Value")]
        [ColumnWidth(175)]
        [ReadOnly(true)]
        public float TotalInventoryValue { get => this.Record.TOTAL_INVENTORY_VALUE; set => this.Record.TOTAL_INVENTORY_VALUE = value; }



        //public override string ToString()
        //{
        //    return String.Format("{0} - {1} - {4} - {2}   -   Total Inventory Nominaly Value: {3} € ", this.Id, this.Person, this.InventoryDate, this.TotalInventoryValue, this.StoreLocation);
        //}

        public override string ToString()
        {
            string id = Id.ToString().PadRight(2);
            string person = Person.PadRight(16);
            string store = StoreLocation.PadRight(23);
            string date = InventoryDate.ToString("yyyy-MMM-dd HH:mm").PadRight(16);
            string total = TotalInventoryValue.ToString("F2").PadLeft(8);

            return $"{id} -> {person} - {store} - {date} | Total Inventory Value: {total} €";
        }


    }
}
