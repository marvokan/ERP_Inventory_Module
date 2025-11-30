using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Inventory.Logic.Builders;
using Inventory.Logic.Entities;
using Inventory.Logic.Models;
using Inventory.Logic.Modules;
using Lib.Logic;
using Lib.UX;
using Lib.UX.DataForms;
using Lib.UX.DataGrid;

namespace Inventory.UX.Views
{
    public partial class CViewEntityItem_Inv : Form, IEntityViewForm
    {
        protected DMItem_Inv module { get; set; } = null!;
        protected CDetailGridDecorator detailsGrid;

        // --------------------------------------------------------------------------------------
        public CViewEntityItem_Inv()
        {
            InitializeComponent();
            //dgvDetails.Columns["Base Price"].ReadOnly = true;
            //dgvDetails.Columns["Description"].ReadOnly = true;

        }
        // --------------------------------------------------------------------------------------
        public void SetParent(Form p_oForm)
        {
            CFormTemplateMaster oMasterForm = (CFormTemplateMaster)p_oForm;
            
            this.detailsGrid = new CDetailGridDecorator(this.dgvDetails, oMasterForm.FormContext);
            oMasterForm.DetailGrids.Add(this.detailsGrid);


            this.module = (DMItem_Inv)oMasterForm.Module;
        }
        // --------------------------------------------------------------------------------------
        public void WriteMasterToUI()
        {
            CItem_Inv oCurrentUser = this.module.MasterEntity;
            if (oCurrentUser != null)
            { 
                this.txtPerson.Text = oCurrentUser.PERSON;
                //this.numStore.Value = oCurrentUser.STORE_CID;


                this.dtInventoryDate.Checked = (oCurrentUser.INV_DATETIME != null);
                this.dtInventoryDate.Value = oCurrentUser.INV_DATETIME ?? DateTime.Now;


                this.displayStatusLookup(oCurrentUser);
                this.displayStoreLookup(oCurrentUser);
            }
        }
        // --------------------------------------------------------------------------------------
        public void ReadMasterFromUI()
        {
            CItem_Inv oCurrentUser = this.module.MasterEntity;
            if (oCurrentUser != null)
            {
                oCurrentUser.PERSON = "";
                oCurrentUser.PERSON = this.txtPerson.Text;
                oCurrentUser.Status = -1;
                if (this.cboStatus.SelectedItem != null)
                {
                    CStatus oSelectedStatus = (CStatus)this.cboStatus.SelectedItem;
                    oCurrentUser.Status = oSelectedStatus.ID;
                }

                //oCurrentUser.STORE_CID = (int)this.numStore.Value;

                oCurrentUser.STORE_CID = -1;
                if (this.cboStores.SelectedItem != null)
                {
                    CStore oSelectedStore = (CStore)this.cboStores.SelectedItem;
                    oCurrentUser.STORE_CID = oSelectedStore.Cid;
                }


                if (this.dtInventoryDate.Checked)
                    oCurrentUser.INV_DATETIME = this.dtInventoryDate.Value.Date;
                else
                    oCurrentUser.INV_DATETIME = null;

                
                oCurrentUser.Change = EntityChangeType.UPDATED;
            }
        }
        // --------------------------------------------------------------------------------------
        public void WriteDetailListToUI()
        {
            // [PATTERNS] Proxy
            this.detailsGrid.Populate<CItem_Inv_Line>(this.module.Details);
            
            addStatusLookupColumn(this.module.Lookups[CDataModuleBuilderItem_Inv.LOOKUP_ITEMS]);
            addPriceLookupColumn(this.module.Lookups[CDataModuleBuilderItem_Inv.LOOKUP_ITEMS]);
        }
        // --------------------------------------------------------------------------------------



        #region (( Custom Code for Lookups ))
        // --------------------------------------------------------------------------------------
        // Prepare a combo box that is designed on the form to functiona as lookup for the master (AppUser)
        // and load all lookup entities (CSubscriptionPlans)
        private void displayStatusLookup(CItem_Inv p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboStatus.ValueMember = "ID";
            this.cboStatus.DisplayMember = "Name";
            this.cboStatus.Items.Clear();
            CStatusModel oLookup = (CStatusModel)this.module.Lookups[CDataModuleBuilderItem_Inv.LOOKUP_STATUS];

            foreach (CStatus oPlan in oLookup)
                this.cboStatus.Items.Add(oPlan);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookUpStatus(oLookup);

            this.cboStatus.SelectedItem = p_oCurrentAppUser.Status;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboStatus.Text = p_oCurrentAppUser.StatusDesc ?? "No status";
        }

        private void displayStoreLookup(CItem_Inv p_oCurrentAppUser)
        {
            // Loads all the options
            this.cboStores.ValueMember = "Cid";
            this.cboStores.DisplayMember = "STORE_LOC";
            this.cboStores.Items.Clear();
            CStoreModel oLookup = (CStoreModel)this.module.Lookups[CDataModuleBuilderItem_Inv.LOOKUP_STORES];

            foreach (CStore oStore in oLookup)
                this.cboStores.Items.Add(oStore);

            // Run the lookup relation to get the foreign entity and its fiedls;
            p_oCurrentAppUser.LookUpStore(oLookup);

            this.cboStores.SelectedItem = p_oCurrentAppUser.STORE_CID;
            // [C#] The single ? is for a nullable type. On the right side of the null coalescence operator ?? is what to show in case of null
            this.cboStores.Text = p_oCurrentAppUser.StoreLoc ?? "No store";
        }
        // --------------------------------------------------------------------------------------
        // Create a lookup combo box column on the grid for the detail (AppUserMovies)
        // and load all lookup entities (Movies)
        private void addStatusLookupColumn(IModel p_oLookupModel)
        {
            Dictionary<string, string> oLookupSetup = new Dictionary<string, string>()
            {
                ["Text"] = "Item Name",        // The title of the column
                ["ValueMember"] = "Id",         // The key field of the lookup entity
                ["DisplayMember"] = "Description",     // The field that will used for displaying a lookup entity
                ["ForeignKey"] = "Item_Id",      // The foreign key field on the detail entity that will receive the selected value
                ["ReadOnly"] = "True"
            };
            DataGridViewComboBoxColumn oMovieLookupColumn = this.detailsGrid.CreateLookupColumn("ItemName", oLookupSetup);

            oMovieLookupColumn.DataSource = null;
            oMovieLookupColumn.DataSource = p_oLookupModel;
        }

        private void addPriceLookupColumn(IModel p_oLookupModel)
        {
            Dictionary<string, string> oLookupSetup = new Dictionary<string, string>()
            {
                ["Text"] = "Base Price",        // The title of the column
                ["ValueMember"] = "Id",         // The key field of the lookup entity
                ["DisplayMember"] = "Base_Price",     // The field that will used for displaying a lookup entity
                ["ForeignKey"] = "Item_Id",      // The foreign key field on the detail entity that will receive the selected value
                ["ReadOnly"] = "True"

            };
            DataGridViewComboBoxColumn oMovieLookupColumn = this.detailsGrid.CreateLookupColumn("BasePrice", oLookupSetup);

            oMovieLookupColumn.DataSource = null;
            oMovieLookupColumn.DataSource = p_oLookupModel;
        }


        // --------------------------------------------------------------------------------------
        #endregion


    }
}
