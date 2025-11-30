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

        public static int MaxIdWidth { get; private set; } = 2;
        public static int MaxPersonWidth { get; private set; } = 16;
        public static int MaxStoreWidth { get; private set; } = 23;
        public static int MaxDateWidth { get; private set; } = 16;
        public static int MaxTotalWidth { get; private set; } = 8;




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






        public static void UpdatePadding(IEnumerable<CV_INVENTORIES>? items)
        {
            if (items == null)
                return;

            int id = 2;
            int person = 10;
            int store = 10;
            int date = 10;
            int total = 2;

            foreach (var it in items)
            {
                id = Math.Max(id, it.Id.ToString().Length);
                person = Math.Max(person, (it.Person ?? "").Length);
                store = Math.Max(store, (it.StoreLocation ?? "").Length);
                var dateStr = it.InventoryDate.ToString("dd/MM/yyyy HH:mm");
                date = Math.Max(date, dateStr.Length);
                var totalStr = it.TotalInventoryValue.ToString("F2");
                total = Math.Max(total, totalStr.Length);
            }

            // Add a small extra spacing to avoid sticking columns
            MaxIdWidth = id + 1;
            MaxPersonWidth = person + 1;
            MaxStoreWidth = store + 1;
            MaxDateWidth = date + 1;
            MaxTotalWidth = total + 1;
        }





        //public override string ToString()
        //{
        //    string id = Id.ToString().PadRight(2);
        //    string person = Person.PadRight(16);
        //    string store = StoreLocation.PadRight(23);
        //    string date = InventoryDate.ToString("yyyy-MMM-dd HH:mm").PadRight(16);
        //    string total = TotalInventoryValue.ToString("F2").PadLeft(8);

        //    return $"{id} -> {person} - {store} - {date} | Total Inventory Value: {total} €";
        //}

        public override string ToString()
        {
            // Use the computed max widths (fallback to defaults if not set)
            string id = Id.ToString().PadRight(Math.Max(1, MaxIdWidth));
            string person = (Person ?? "").PadRight(Math.Max(1, MaxPersonWidth));
            string store = (StoreLocation ?? "").PadRight(Math.Max(1, MaxStoreWidth));
            string date = InventoryDate.ToString("dd/MM/yyyy HH:mm").PadRight(Math.Max(1, MaxDateWidth));
            string total = TotalInventoryValue.ToString("F2").PadLeft(Math.Max(1, MaxTotalWidth));

            return $"{id}-> {person}- {store}- {date}| Total Inventory Value:{total} €";
        }

    }
}
