namespace WindowsApp
{
    partial class CFormMain
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            mnuMain = new MenuStrip();
            mnuMasterDetail = new ToolStripMenuItem();
            mnuItem_Inv = new ToolStripMenuItem();
            tablesToolStripMenuItem = new ToolStripMenuItem();
            mnuItems = new ToolStripMenuItem();
            mnuStores = new ToolStripMenuItem();
            mnuStore_Poses = new ToolStripMenuItem();
            mnuItemPkgs = new ToolStripMenuItem();
            mnuMain.SuspendLayout();
            SuspendLayout();
            // 
            // mnuMain
            // 
            mnuMain.Items.AddRange(new ToolStripItem[] { mnuMasterDetail, tablesToolStripMenuItem });
            mnuMain.Location = new Point(0, 0);
            mnuMain.Name = "mnuMain";
            mnuMain.Size = new Size(800, 24);
            mnuMain.TabIndex = 3;
            mnuMain.Text = "menuStrip1";
            // 
            // mnuMasterDetail
            // 
            mnuMasterDetail.DropDownItems.AddRange(new ToolStripItem[] { mnuItem_Inv });
            mnuMasterDetail.Name = "mnuMasterDetail";
            mnuMasterDetail.Size = new Size(55, 20);
            mnuMasterDetail.Text = "Master";
            // 
            // mnuItem_Inv
            // 
            mnuItem_Inv.Name = "mnuItem_Inv";
            mnuItem_Inv.Size = new Size(251, 22);
            mnuItem_Inv.Text = "Application Inventories and Items";
            mnuItem_Inv.Click += DoOnAnyCommand;
            // 
            // tablesToolStripMenuItem
            // 
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuItemPkgs, mnuStore_Poses, mnuStores, mnuItems });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(51, 20);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // mnuItems
            // 
            mnuItems.Name = "mnuItems";
            mnuItems.Size = new Size(180, 22);
            mnuItems.Text = "Items";
            mnuItems.Click += DoOnAnyCommand;
            // 
            // mnuStores
            // 
            mnuStores.Name = "mnuStores";
            mnuStores.Size = new Size(180, 22);
            mnuStores.Text = "Stores";
            mnuStores.Click += DoOnAnyCommand;
            // 
            // mnuStore_Poses
            // 
            mnuStore_Poses.Name = "mnuStore_Poses";
            mnuStore_Poses.Size = new Size(180, 22);
            mnuStore_Poses.Text = "Store Positions";
            mnuStore_Poses.Click += DoOnAnyCommand;
            // 
            // mnuItemPkgs
            // 
            mnuItemPkgs.Name = "mnuItemPkgs";
            mnuItemPkgs.Size = new Size(180, 22);
            mnuItemPkgs.Text = "Item Packages";
            mnuItemPkgs.Click += DoOnAnyCommand;
            // 
            // CFormMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(mnuMain);
            IsMdiContainer = true;
            MainMenuStrip = mnuMain;
            Name = "CFormMain";
            Text = "ERP Inventory Module";
            WindowState = FormWindowState.Maximized;
            mnuMain.ResumeLayout(false);
            mnuMain.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip mnuMain;
        private ToolStripMenuItem mnuMasterDetail;
        private ToolStripMenuItem mnuItem_Inv;
        private ToolStripMenuItem tablesToolStripMenuItem;
        private ToolStripMenuItem mnuItems;
        private ToolStripMenuItem mnuItemPkgs;
        private ToolStripMenuItem mnuStore_Poses;
        private ToolStripMenuItem mnuStores;
    }
}