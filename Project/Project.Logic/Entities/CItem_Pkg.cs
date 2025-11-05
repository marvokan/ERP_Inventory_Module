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
    public class CItem_Pkg : CEntity<ITEM_PKG>
    {
        [Key]
        public int Id => this.Record.ID;

        public int ITEM_ID { get => this.Record.ITEM_ID; set => this.Record.ITEM_ID = value; }

        public string BARCODE { get => this.Record.BARCODE; set => this.Record.BARCODE = value; }

        public long SERIAL_NUM { get => this.Record.SERIAL_NUM; set => this.Record.SERIAL_NUM = value; }

        public int PACKAGE_TYPE_CID { get => this.Record.PACKAGE_TYPE_CID; set => this.Record.PACKAGE_TYPE_CID = value; }

    }
}
