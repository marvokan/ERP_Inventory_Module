using Inventory.Logic.Builders;
using Inventory.Logic.Modules;
using Inventory.UX;
using Inventory.UX.Views;
using Lib.Common.Interfaces;
using Lib.Logic.Builders;
using Lib.UX;
using Lib.UX.Builders;
using Lib.UX.DataForms;

namespace Inventory.UX.Builders
{
    // [PATTERNS] Builder: This is an example of a concrete builder where the abstract builder is the ancestor class
    public class CMasterFormBuilderItem_Inv: CMasterFormBuilder
    {
        protected DMItem_Inv module = null!;
        protected IBrowserViewForm browserView = null!;
        protected Form entityView = null!;

        // --------------------------------------------------------------------------------
        public override void BuildDataModule()
        {
            CDataModuleDirector oDirector = new CDataModuleDirector();
            DMItem_Inv oModule = (DMItem_Inv)oDirector.ConstructDM(new CDataModuleBuilderItem_Inv());
            this.module = oModule;
        }
        // --------------------------------------------------------------------------------
        public override void BuildBrowserView()
        {
            this.browserView = new CViewBrowserItem_Inv(this.module.Browser);
        }
        // --------------------------------------------------------------------------------
        public override void BuildEntityView()
        {
            this.entityView = new CViewEntityItem_Inv();
        }
        // --------------------------------------------------------------------------------
        public override void BuildForm()
        {
            this.Product = new CFormTemplateMaster(module, browserView, entityView);
        }
        // --------------------------------------------------------------------------------
    }
}
