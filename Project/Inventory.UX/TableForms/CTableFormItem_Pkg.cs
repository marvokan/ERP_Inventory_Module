using Inventory.Logic.Entities;
using Inventory.Logic.Models;
using Lib.UX;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Inventory.UX.TableForms
{
    public partial class CTableFormItem_Pkg : CFormTemplateTable
    {
        public CItem_PkgModel Model = new CItem_PkgModel();

        // --------------------------------------------------------------------------------------
        public CTableFormItem_Pkg()
        {
            InitializeComponent();
        }
        // --------------------------------------------------------------------------------------
        
        #region // Virtual Methods \\
        // --------------------------------------------------------------------------------------
        protected override bool LoadModule()
        {
            // [v3] 
            Model.Load();
            // [PATTERNS] Visitor: The model is accepting a visit after loading
            Model.AcceptVisitAfterLoad(this.modelVisitor);

            return true;
        }
        // --------------------------------------------------------------------------------------
        protected override void DisplayModelEntitiesOnGrid()
        {
            // [v2]
            editableGridRecords.Populate<CItem_Pkg>(Model);
        }
        // --------------------------------------------------------------------------------------
        protected override bool SaveModule()
        {
            // [v54]
            // [PATTERNS] Visitor: The model is accepting a visit before saving
            Model.AcceptVisitBeforeSave(this.tableVisitor);

            // Saving the logic objects
            Model.Save();

            return true;
        }
        // --------------------------------------------------------------------------------------
        protected override string LastErrorMessage()
        {
            return this.Model.LastError;
        }
        // --------------------------------------------------------------------------------------
        #endregion
    }
}
