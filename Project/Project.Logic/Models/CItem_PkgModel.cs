using Inventory.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Logic.Models;

namespace Inventory.Logic.Models
{
    internal class CItem_PkgModel : CBaseModel<CItem_Pkg>
    {
        public CItem_PkgModel() : base("ITEM_PKG")
        {
        }
    }
}
}
