using Inventory.Logic.Entities;
using Lib.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Models
{
    public class CItem_Inv_LineModel : CBaseModel<CItem_Inv_Line>
    {
        public CItem_Inv_LineModel() : base("ItemInvLine")
        {
        }
    }
}
