using Inventory.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Models
{
    public class CItemModel : CBaseModel<CItem>
    {
        public CItemModel() : base("ITEM")
        {
        }
    }
}
