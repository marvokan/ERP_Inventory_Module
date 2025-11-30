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
    public class CItem_PkgModel : CTableModel<CItem_Pkg>
    {
        public CItem_PkgModel() : base("ItemPkg")
        {
            this.Table = CDataTableFactory.Instance.Produce(this.TableName)!;
        }
    }
}
