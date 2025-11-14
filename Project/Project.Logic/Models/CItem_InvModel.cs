using Inventory.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Logic.Models;

namespace Inventory.Logic.Models
{
    public class CItem_InvModel : CMasterModel<CItem_Inv, CItem_Inv_Line>
    {
        public CItem_InvModel() : base("ItemInv")
        {
        }
    }
}
