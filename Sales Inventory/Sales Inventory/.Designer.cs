namespace Sales_Inventory
{
    partial class CashierHomePage
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.labelName = new System.Windows.Forms.Label();
            this.labelTime = new System.Windows.Forms.Label();
            this.labelDate = new System.Windows.Forms.Label();
            this.buttonEndTransaction = new System.Windows.Forms.Button();
            this.buttonCancelTransaction = new System.Windows.Forms.Button();
            this.buttonResetTransaction = new System.Windows.Forms.Button();
            this.buttonSalesInventory = new System.Windows.Forms.Button();
            this.buttonLogout = new System.Windows.Forms.Button();
            this.buttonAdmin = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 28;
            this.dataGridView1.Size = new System.Drawing.Size(645, 443);
            this.dataGridView1.TabIndex = 0;
            // 
            // labelName
            // 
            this.labelName.AutoSize = true;
            this.labelName.Location = new System.Drawing.Point(664, 13);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(67, 20);
            this.labelName.TabIndex = 1;
            this.labelName.Text = "Cashier:";
            // 
            // labelTime
            // 
            this.labelTime.AutoSize = true;
            this.labelTime.Location = new System.Drawing.Point(664, 158);
            this.labelTime.Name = "labelTime";
            this.labelTime.Size = new System.Drawing.Size(47, 20);
            this.labelTime.TabIndex = 2;
            this.labelTime.Text = "Time:";
            // 
            // labelDate
            // 
            this.labelDate.AutoSize = true;
            this.labelDate.Location = new System.Drawing.Point(663, 84);
            this.labelDate.Name = "labelDate";
            this.labelDate.Size = new System.Drawing.Size(48, 20);
            this.labelDate.TabIndex = 3;
            this.labelDate.Text = "Date:";
            // 
            // buttonEndTransaction
            // 
            this.buttonEndTransaction.Location = new System.Drawing.Point(13, 462);
            this.buttonEndTransaction.Name = "buttonEndTransaction";
            this.buttonEndTransaction.Size = new System.Drawing.Size(210, 105);
            this.buttonEndTransaction.TabIndex = 4;
            this.buttonEndTransaction.Text = "End Current Transcation";
            this.buttonEndTransaction.UseVisualStyleBackColor = true;
            this.buttonEndTransaction.Click += new System.EventHandler(this.buttonEndTransaction_Click);
            // 
            // buttonCancelTransaction
            // 
            this.buttonCancelTransaction.Location = new System.Drawing.Point(229, 462);
            this.buttonCancelTransaction.Name = "buttonCancelTransaction";
            this.buttonCancelTransaction.Size = new System.Drawing.Size(210, 105);
            this.buttonCancelTransaction.TabIndex = 5;
            this.buttonCancelTransaction.Text = "Cancel Previous Transaction";
            this.buttonCancelTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonResetTransaction
            // 
            this.buttonResetTransaction.Location = new System.Drawing.Point(445, 462);
            this.buttonResetTransaction.Name = "buttonResetTransaction";
            this.buttonResetTransaction.Size = new System.Drawing.Size(210, 105);
            this.buttonResetTransaction.TabIndex = 6;
            this.buttonResetTransaction.Text = "Reset Current Transaction";
            this.buttonResetTransaction.UseVisualStyleBackColor = true;
            // 
            // buttonSalesInventory
            // 
            this.buttonSalesInventory.Location = new System.Drawing.Point(668, 269);
            this.buttonSalesInventory.Name = "buttonSalesInventory";
            this.buttonSalesInventory.Size = new System.Drawing.Size(163, 63);
            this.buttonSalesInventory.TabIndex = 7;
            this.buttonSalesInventory.Text = "Access Sales Inventory";
            this.buttonSalesInventory.UseVisualStyleBackColor = true;
            // 
            // buttonLogout
            // 
            this.buttonLogout.Location = new System.Drawing.Point(668, 491);
            this.buttonLogout.Name = "buttonLogout";
            this.buttonLogout.Size = new System.Drawing.Size(163, 47);
            this.buttonLogout.TabIndex = 8;
            this.buttonLogout.Text = "Logout";
            this.buttonLogout.UseVisualStyleBackColor = true;
            // 
            // buttonAdmin
            // 
            this.buttonAdmin.Location = new System.Drawing.Point(668, 361);
            this.buttonAdmin.Name = "buttonAdmin";
            this.buttonAdmin.Size = new System.Drawing.Size(163, 61);
            this.buttonAdmin.TabIndex = 9;
            this.buttonAdmin.Text = "Access Admin Controls";
            this.buttonAdmin.UseVisualStyleBackColor = true;
            // 
            // CashierHomePage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 579);
            this.Controls.Add(this.buttonAdmin);
            this.Controls.Add(this.buttonLogout);
            this.Controls.Add(this.buttonSalesInventory);
            this.Controls.Add(this.buttonResetTransaction);
            this.Controls.Add(this.buttonCancelTransaction);
            this.Controls.Add(this.buttonEndTransaction);
            this.Controls.Add(this.labelDate);
            this.Controls.Add(this.labelTime);
            this.Controls.Add(this.labelName);
            this.Controls.Add(this.dataGridView1);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "CashierHomePage";
            this.Text = "Cashier Home";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label labelName;
        private System.Windows.Forms.Label labelTime;
        private System.Windows.Forms.Label labelDate;
        private System.Windows.Forms.Button buttonEndTransaction;
        private System.Windows.Forms.Button buttonCancelTransaction;
        private System.Windows.Forms.Button buttonResetTransaction;
        private System.Windows.Forms.Button buttonSalesInventory;
        private System.Windows.Forms.Button buttonLogout;
        private System.Windows.Forms.Button buttonAdmin;
    }
}