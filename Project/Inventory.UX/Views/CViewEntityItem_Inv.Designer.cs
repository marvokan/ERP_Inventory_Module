namespace Inventory.UX.Views
{
    partial class CViewEntityItem_Inv
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
            lblPerson = new Label();
            txtPerson = new TextBox();
            lblStatus = new Label();
            cboStatus = new ComboBox();
            lblInventoryDate = new Label();
            dtInventoryDate = new DateTimePicker();
            lblInventories = new Label();
            dgvDetails = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvDetails).BeginInit();
            SuspendLayout();
            // 
            // lblPerson
            // 
            lblPerson.AutoSize = true;
            lblPerson.Location = new Point(48, 15);
            lblPerson.Name = "lblPerson";
            lblPerson.Size = new Size(46, 15);
            lblPerson.TabIndex = 17;
            lblPerson.Text = "Person:";
            // 
            // txtPerson
            // 
            txtPerson.Location = new Point(118, 12);
            txtPerson.Name = "txtPerson";
            txtPerson.Size = new Size(326, 23);
            txtPerson.TabIndex = 13;
            // 
            // lblStatus
            // 
            lblStatus.AutoSize = true;
            lblStatus.Location = new Point(10, 43);
            lblStatus.Name = "lblStatus";
            lblStatus.Size = new Size(102, 15);
            lblStatus.TabIndex = 18;
            lblStatus.Text = "Subscription Plan:";
            // 
            // cboStatus
            // 
            cboStatus.FormattingEnabled = true;
            cboStatus.Location = new Point(118, 40);
            cboStatus.Name = "cboStatus";
            cboStatus.Size = new Size(240, 23);
            cboStatus.TabIndex = 16;
            // 
            // lblInventoryDate
            // 
            lblInventoryDate.AutoSize = true;
            lblInventoryDate.Location = new Point(5, 75);
            lblInventoryDate.Name = "lblInventoryDate";
            lblInventoryDate.Size = new Size(107, 15);
            lblInventoryDate.TabIndex = 19;
            lblInventoryDate.Text = "Subscription From:";
            // 
            // dtInventoryDate
            // 
            dtInventoryDate.Format = DateTimePickerFormat.Short;
            dtInventoryDate.Location = new Point(118, 69);
            dtInventoryDate.Name = "dtInventoryDate";
            dtInventoryDate.ShowCheckBox = true;
            dtInventoryDate.Size = new Size(215, 23);
            dtInventoryDate.TabIndex = 14;
            // 
            // lblInventories
            // 
            lblInventories.AutoSize = true;
            lblInventories.Location = new Point(118, 118);
            lblInventories.Name = "lblInventories";
            lblInventories.Size = new Size(39, 15);
            lblInventories.TabIndex = 22;
            lblInventories.Text = "Items:";
            // 
            // dgvDetails
            // 
            dgvDetails.Location = new Point(118, 147);
            dgvDetails.Name = "dgvDetails";
            dgvDetails.Size = new Size(570, 344);
            dgvDetails.TabIndex = 21;
            
            // 
            // CViewEntityItem_Inv
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(708, 513);
            Controls.Add(lblPerson);
            Controls.Add(txtPerson);
            Controls.Add(lblStatus);
            Controls.Add(cboStatus);
            Controls.Add(lblInventoryDate);
            Controls.Add(dtInventoryDate);
            Controls.Add(lblInventories);
            Controls.Add(dgvDetails);
            Name = "CViewEntityItem_Inv";
            Text = "CViewEntityItem_Inv";
            ((System.ComponentModel.ISupportInitialize)dgvDetails).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label lblPerson;
        private TextBox txtPerson;
        private Label lblStatus;
        private ComboBox cboStatus;
        private Label lblInventoryDate;
        private DateTimePicker dtInventoryDate;
        private Label lblInventories;
        private DataGridView dgvDetails;
    }
}