using Inventory.Logic.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Lib.Logic.Models;
using Inventory.Data;

namespace Inventory.Logic.Models
{
    public class CItemModel : CTableModel<CItem>
    {
        public CItemModel() : base("Item")
        {
            this.Table = CDataTableFactory.Instance.Produce(this.TableName)!;
        }
    }
}
