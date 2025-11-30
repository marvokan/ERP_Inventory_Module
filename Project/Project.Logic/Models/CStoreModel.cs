using Inventory.Data;
using Inventory.Logic.Entities;
using Lib.Logic.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Models
{
    public class CStoreModel : CTableModel<CStore>
    {
        public CStoreModel() : base("Store")
        {
            this.Table = CDataTableFactory.Instance.Produce(this.TableName)!;
        }
    }
}
