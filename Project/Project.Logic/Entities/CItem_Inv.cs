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

        public int Status { get => this.Record.STATUS; set => this.Record.STATUS = value; }

        public string StatusDesc { get; set; }

        public string StoreLoc { get; set; }

        public void LookUpStatus(List<CStatus> p_oStatuses)
        {
            var oFound = p_oStatuses.Where(x => x.ID == this.Status).ToList();
            if (oFound.Count > 0)
                this.StatusDesc = oFound[0].Name;
            else
                this.StatusDesc = "";
        }

        public void LookUpStore(List<CStore> p_oStores)
        {
            var oFound = p_oStores.Where(x => x.Cid == this.STORE_CID).ToList();
            if (oFound.Count > 0)
                this.StoreLoc = oFound[0].STORE_LOC;
            else
                this.StoreLoc = "";
        }


        public DateTime? INV_DATETIME { get => this.Record.INV_DATETIME; set => this.Record.INV_DATETIME = value; }

        public string PERSON { get => this.Record.PERSON; set => this.Record.PERSON = value; }
    }
}
