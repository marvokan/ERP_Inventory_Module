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
            lstBrowser.Font = new Font("Cascadia Mono", 8.861538F);
            lstBrowser.FormattingEnabled = true;
            lstBrowser.ItemHeight = 21;
            lstBrowser.Location = new Point(15, 104);
            lstBrowser.Margin = new Padding(4, 4, 4, 4);
            lstBrowser.Name = "lstBrowser";
            lstBrowser.Size = new Size(997, 466);
            lstBrowser.TabIndex = 0;
            lstBrowser.DoubleClick += DoOnAnyCommand;
            lstBrowser.KeyPress += DoOnAnyKeyPress;
            // 
            // lblSearch
            // 
            lblSearch.AutoSize = true;
            lblSearch.Location = new Point(19, 24);
            lblSearch.Margin = new Padding(4, 0, 4, 0);
            lblSearch.Name = "lblSearch";
            lblSearch.Size = new Size(109, 21);
            lblSearch.TabIndex = 0;
            lblSearch.Text = "Store Location";
            // 
            // pnlTop
            // 
            pnlTop.Controls.Add(txtSearch);
            pnlTop.Controls.Add(btnFind);
            pnlTop.Controls.Add(lblSearch);
            pnlTop.Location = new Point(15, 10);
            pnlTop.Margin = new Padding(4, 4, 4, 4);
            pnlTop.Name = "pnlTop";
            pnlTop.Size = new Size(998, 85);
            pnlTop.TabIndex = 1;
            // 
            // txtSearch
            // 
            txtSearch.Location = new Point(134, 20);
            txtSearch.Margin = new Padding(4, 4, 4, 4);
            txtSearch.Name = "txtSearch";
            txtSearch.Size = new Size(419, 29);
            txtSearch.TabIndex = 2;
            // 
            // btnFind
            // 
            btnFind.Location = new Point(562, 20);
            btnFind.Margin = new Padding(4, 4, 4, 4);
            btnFind.Name = "btnFind";
            btnFind.Size = new Size(96, 32);
            btnFind.TabIndex = 1;
            btnFind.Text = "Search";
            btnFind.UseVisualStyleBackColor = true;
            // 
            // CViewBrowserItem_Inv
            // 
            AutoScaleDimensions = new SizeF(9F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1029, 630);
            Controls.Add(pnlTop);
            Controls.Add(lstBrowser);
            Margin = new Padding(4, 4, 4, 4);
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