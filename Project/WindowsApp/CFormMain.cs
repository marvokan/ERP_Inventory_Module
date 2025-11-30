using Inventory.UX.Builders;
using Inventory.UX;
using Inventory.UX.TableForms;
using Lib.UX.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;

namespace WindowsApp
{
    public partial class CFormMain : Form
    {
        //public CFormTableSubscriptionPlan? FormTableSubscriptionPlan = null;

        // --------------------------------------------------------------------------------------
        public CFormMain()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        private void DoOnAnyCommand(object sender, EventArgs e)
        {
            if (sender == mnuItem_Inv)
                // [PATTERNS] Builder: We create a director for the construction of a master form, 
                // and we perform the construction with the given builder object
                new CMasterFormDirector(this).ConstructUX(new CMasterFormBuilderItem_Inv()).Show();
            else if (sender == mnuItems)
            {
                //[C#] This shows an MDI child form, i.e. you can have multiple instances of this form
                CTableFormItem oFormTableItems = new CTableFormItem();
                oFormTableItems.MdiParent = this;
                oFormTableItems?.Show();
            }
            else if (sender == mnuStores)
            {
                //[C#] This shows an MDI child form, i.e. you can have multiple instances of this form
                CTableFormStore oFormTableStores = new CTableFormStore();
                oFormTableStores.MdiParent = this;
                oFormTableStores?.Show();
            }
            else if (sender == mnuStore_Poses)
            {
                //[C#] This shows an MDI child form, i.e. you can have multiple instances of this form
                CTableFormStore_Pos oFormTableStore_Poses = new CTableFormStore_Pos();
                oFormTableStore_Poses.MdiParent = this;
                oFormTableStore_Poses?.Show();
            }
            else if (sender == mnuItemPkgs)
            {
                //[C#] This shows an MDI child form, i.e. you can have multiple instances of this form
                CTableFormItem_Pkg oFormTableItem_Pkgs = new CTableFormItem_Pkg();
                oFormTableItem_Pkgs.MdiParent = this;
                oFormTableItem_Pkgs?.Show();
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
