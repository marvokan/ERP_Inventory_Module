using Inventory.Data;    
using Inventory.Logic.Models;
using Inventory.Logic.Modules;
using Lib.Common.Interfaces;
using Lib.Logic.Builders;
using Lib.Logic.Modules;
using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Inventory.Logic.Builders
{
    // [PATTERNS] Builder: This is an example of a concrete builder where the abstract builder is an interface
    public class CDataModuleBuilderItem_Inv : IDataModuleBuilder
    {
        protected DMItem_Inv product = null!;

        # region // IDataModuleBuilder \\
        public IDataModule Product { get { return product as IDataModule; } }

        // -----------------------------------------------------------------------------------------------
        public void BuildBrowserModel()
        {
            product = new DMItem_Inv();
            product.Browser = new CItem_Inv_BrowserModel();
            product.Browser.Table = CDataTableFactory.Instance.Produce(product.Browser.TableName)!;
        }
        // -----------------------------------------------------------------------------------------------
        public void BuildMasterModel()
        {
            product.Master = new CItem_InvModel();
            product.Master.Table = CDataTableFactory.Instance.Produce(product.Master.TableName)!;

        }
        // -----------------------------------------------------------------------------------------------
        public void BuildDetailsModel()
        {
            product.Details = new CItem_Inv_LineModel();
            product.Details.Table = CDataTableFactory.Instance.Produce(product.Details.TableName)!;
            product.Master.DetailsModel = product.Details;
        }
        // -----------------------------------------------------------------------------------------------

        public const int LOOKUP_ITEMS = 0;

        public const int LOOKUP_STATUS = 1;



        public void BuildLookupModels()
        {
            CItemModel oLookup1 = new CItemModel();  // [C#] Variant Types. This is a feature to turn C# into Python, don't misuse it!
            oLookup1.Table = CDataTableFactory.Instance.Produce(oLookup1.TableName)!;

            CStatusModel oLookup2 = new CStatusModel();  // [C#] Variant Types. This is a feature to turn C# into Python, don't misuse it!



            product.Lookups.Add(oLookup1);
            product.Lookups.Add(oLookup2);
        }
        // -----------------------------------------------------------------------------------------------
        #endregion

    }
}
