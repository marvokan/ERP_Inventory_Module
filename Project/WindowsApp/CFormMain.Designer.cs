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
            mnuMovies = new ToolStripMenuItem();
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
            tablesToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { mnuMovies });
            tablesToolStripMenuItem.Name = "tablesToolStripMenuItem";
            tablesToolStripMenuItem.Size = new Size(51, 20);
            tablesToolStripMenuItem.Text = "Tables";
            // 
            // mnuMovies
            // 
            mnuMovies.Name = "mnuMovies";
            mnuMovies.Size = new Size(103, 22);
            mnuMovies.Text = "Items";
            mnuMovies.Click += DoOnAnyCommand;
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
            Text = "Flix Streaming Service Manager Application";
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
        private ToolStripMenuItem mnuMovies;
    }
}