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
    public partial class CTableFormStore_Pos : CFormTemplateTable
    {
        public CStore_Pos_Model Model = new CStore_Pos_Model();

        // --------------------------------------------------------------------------------------
        public CTableFormStore_Pos()
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
            editableGridRecords.Populate<CStore_Pos>(Model);
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
