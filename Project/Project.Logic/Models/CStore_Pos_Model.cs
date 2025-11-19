using Inventory.Logic.Entities;
using Lib.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Models
{
    public class CStore_Pos_Model : CBaseModel<CStore>
    {
        public CStore_Pos_Model() : base("StorePos")
        {
        }
    }
}
