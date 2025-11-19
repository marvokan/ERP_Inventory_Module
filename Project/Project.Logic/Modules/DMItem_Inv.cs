using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Inventory.Logic.Builders;
using Inventory.Logic.Entities;
using Inventory.Logic.Models;
using Lib.Logic.Modules;

namespace Inventory.Logic.Modules
{
    public class DMItem_Inv : CDataModule<CItem_Inv_BrowserModel, CItem_InvModel, CItem_Inv_LineModel, CV_INVENTORIES,CItem_Inv, CItem_Inv_Line>
    {
        public override void DoOnPerformLookups(object? p_oEntity)
        {
            if (p_oEntity is CItem_Inv_Line)
                ((CItem_Inv_Line)p_oEntity).LookupItem((CItemModel)Lookups[CDataModuleBuilderItem_Inv.LOOKUP_ITEMS]);
            else if (p_oEntity is CItem_Inv)
                ((CItem_Inv)p_oEntity).LookUpStatus((CStatusModel)Lookups[CDataModuleBuilderItem_Inv.LOOKUP_STATUS]);

        }
    }
}
