namespace CodeFirst_BillingProject
{
    partial class FormCustomer
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
            this.txtBoxcustomerAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxCity = new System.Windows.Forms.ComboBox();
            this.dataGVCustomer = new System.Windows.Forms.DataGridView();
            this.btnCustomerDelete = new System.Windows.Forms.Button();
            this.btnCustomerUpdate = new System.Windows.Forms.Button();
            this.btnCustomerAdd = new System.Windows.Forms.Button();
            this.txtBoxCompanyName = new System.Windows.Forms.TextBox();
            this.cmbBoxCounty = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxcustomerAddress
            // 
            this.txtBoxcustomerAddress.Location = new System.Drawing.Point(300, 22);
            this.txtBoxcustomerAddress.Multiline = true;
            this.txtBoxcustomerAddress.Name = "txtBoxcustomerAddress";
            this.txtBoxcustomerAddress.Size = new System.Drawing.Size(219, 66);
            this.txtBoxcustomerAddress.TabIndex = 35;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(246, 25);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 34;
            this.label4.Text = "Address:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(53, 111);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(43, 13);
            this.label3.TabIndex = 33;
            this.label3.Text = "County:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(69, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 32;
            this.label2.Text = "City:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(83, 13);
            this.label1.TabIndex = 31;
            this.label1.Text = "Conpany Name:";
            // 
            // cmbBoxCity
            // 
            this.cmbBoxCity.FormattingEnabled = true;
            this.cmbBoxCity.Location = new System.Drawing.Point(102, 67);
            this.cmbBoxCity.Name = "cmbBoxCity";
            this.cmbBoxCity.Size = new System.Drawing.Size(129, 21);
            this.cmbBoxCity.TabIndex = 30;
            // 
            // dataGVCustomer
            // 
            this.dataGVCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCustomer.Location = new System.Drawing.Point(14, 135);
            this.dataGVCustomer.Name = "dataGVCustomer";
            this.dataGVCustomer.Size = new System.Drawing.Size(505, 217);
            this.dataGVCustomer.TabIndex = 29;
            // 
            // btnCustomerDelete
            // 
            this.btnCustomerDelete.Location = new System.Drawing.Point(440, 106);
            this.btnCustomerDelete.Name = "btnCustomerDelete";
            this.btnCustomerDelete.Size = new System.Drawing.Size(79, 23);
            this.btnCustomerDelete.TabIndex = 28;
            this.btnCustomerDelete.Text = "DELETE";
            this.btnCustomerDelete.UseVisualStyleBackColor = true;
            // 
            // btnCustomerUpdate
            // 
            this.btnCustomerUpdate.Location = new System.Drawing.Point(355, 106);
            this.btnCustomerUpdate.Name = "btnCustomerUpdate";
            this.btnCustomerUpdate.Size = new System.Drawing.Size(79, 23);
            this.btnCustomerUpdate.TabIndex = 27;
            this.btnCustomerUpdate.Text = "UPDATE";
            this.btnCustomerUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCustomerAdd
            // 
            this.btnCustomerAdd.Location = new System.Drawing.Point(268, 106);
            this.btnCustomerAdd.Name = "btnCustomerAdd";
            this.btnCustomerAdd.Size = new System.Drawing.Size(79, 23);
            this.btnCustomerAdd.TabIndex = 26;
            this.btnCustomerAdd.Text = "ADD";
            this.btnCustomerAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxCompanyName
            // 
            this.txtBoxCompanyName.Location = new System.Drawing.Point(102, 22);
            this.txtBoxCompanyName.Name = "txtBoxCompanyName";
            this.txtBoxCompanyName.Size = new System.Drawing.Size(129, 20);
            this.txtBoxCompanyName.TabIndex = 25;
            // 
            // cmbBoxCounty
            // 
            this.cmbBoxCounty.FormattingEnabled = true;
            this.cmbBoxCounty.Location = new System.Drawing.Point(102, 108);
            this.cmbBoxCounty.Name = "cmbBoxCounty";
            this.cmbBoxCounty.Size = new System.Drawing.Size(129, 21);
            this.cmbBoxCounty.TabIndex = 37;
            // 
            // FormCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(537, 367);
            this.Controls.Add(this.cmbBoxCounty);
            this.Controls.Add(this.txtBoxcustomerAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxCity);
            this.Controls.Add(this.dataGVCustomer);
            this.Controls.Add(this.btnCustomerDelete);
            this.Controls.Add(this.btnCustomerUpdate);
            this.Controls.Add(this.btnCustomerAdd);
            this.Controls.Add(this.txtBoxCompanyName);
            this.Name = "FormCustomer";
            this.Text = "FormCustomer";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCustomer)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtBoxcustomerAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxCity;
        private System.Windows.Forms.DataGridView dataGVCustomer;
        private System.Windows.Forms.Button btnCustomerDelete;
        private System.Windows.Forms.Button btnCustomerUpdate;
        private System.Windows.Forms.Button btnCustomerAdd;
        private System.Windows.Forms.TextBox txtBoxCompanyName;
        private System.Windows.Forms.ComboBox cmbBoxCounty;
    }
}