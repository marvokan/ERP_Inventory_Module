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
            else if (sender == mnuMovies)
            {
                //[C#] This shows an MDI child form, i.e. you can have multiple instances of this form
                CTableFormItem oFormTableMovie = new CTableFormItem();
                oFormTableMovie.MdiParent = this;
                oFormTableMovie?.Show();
            }
        }
        // --------------------------------------------------------------------------------------
    }
}
