namespace Inventory.UX.Views
{
    partial class CViewBrowserItem_Inv
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
            lstBrowser = new ListBox();
            lblSearch = new Label();
            pnlTop = new Panel();
            txtSearch = new TextBox();
            btnFind = new Button();
            pnlTop.SuspendLayout();
            SuspendLayout();
            // 
            // lstBrowser
            // 
            lstBrowser.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            lstBrowser.FormattingEnabled = true;
            lstBrowser.ItemHeight = 15;
            lstBrowser.Location = new Point(12, 74);
            lstBrowser.Name = "lstBrowser";
            lstBrowser.Size = new Size(776, 334);
            lstBrowser.TabIndex = 0;
            lstBrowser.DoubleClick += DoOnAnyCommand;
            lstBrowser.KeyPress += DoOnAnyKeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(15, 17);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(83, 15);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Store Location";
            //lblSearch.Click += lblSearch_Click;
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(btnFind);
            pnlTop.Controls.Add(lblSearch);
            pnlTop.Location = new Point(12, 7);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(776, 61);
            pnlTop.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(104, 14);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(327, 23);
            txtSearch.TabIndex = 2;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(437, 14);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(75, 23);
            btnFind.TabIndex = 1;
            btnFind.Text = "Search";
            btnFind.UseVisualStyleBackColor = true;
            //btnFind.Click += btnFind_Click;
            // 
            // CViewBrowserItem_Inv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(pnlTop);
            Controls.Add(lstBrowser);
            Name = "CViewBrowserItem_Inv";
            Text = "CViewBrowserItem_Inv";
            pnlTop.ResumeLayout(false);
            pnlTop.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private ListBox lstBrowser;
        private Label lblSearch;
        private Panel pnlTop;
        private TextBox txtSearch;
        private Button btnFind;
    }
}