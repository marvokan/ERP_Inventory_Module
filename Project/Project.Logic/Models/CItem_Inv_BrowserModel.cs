using Inventory.Logic.Entities;
using Lib.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Models
{
    public class CItem_Inv_BrowserModel : CTableModel<CV_INVENTORIES>
    {
        private Dictionary<string, object> _criteria = new Dictionary<string, object>();
        public Dictionary<string, object> Criteria { get { return _criteria; } }
        // ....................................................................


        public CItem_Inv_BrowserModel() : base("ViewInventories")
        {
        }
    }
}
