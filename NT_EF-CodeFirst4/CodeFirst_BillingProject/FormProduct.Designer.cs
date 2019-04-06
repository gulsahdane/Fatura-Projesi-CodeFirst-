namespace CodeFirst_BillingProject
{
    partial class FormProduct
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbBoxUnit = new System.Windows.Forms.ComboBox();
            this.dataGVProduct = new System.Windows.Forms.DataGridView();
            this.btnProductDelete = new System.Windows.Forms.Button();
            this.btnProductUpdate = new System.Windows.Forms.Button();
            this.btnProductAdd = new System.Windows.Forms.Button();
            this.txtBoxProductName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxProductPrice = new System.Windows.Forms.TextBox();
            this.txtBoxProductNumber = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 13);
            this.label2.TabIndex = 20;
            this.label2.Text = "Product Number:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 19;
            this.label1.Text = "Product Name:";
            // 
            // cmbBoxUnit
            // 
            this.cmbBoxUnit.FormattingEnabled = true;
            this.cmbBoxUnit.Location = new System.Drawing.Point(366, 26);
            this.cmbBoxUnit.Name = "cmbBoxUnit";
            this.cmbBoxUnit.Size = new System.Drawing.Size(129, 21);
            this.cmbBoxUnit.TabIndex = 18;
            // 
            // dataGVProduct
            // 
            this.dataGVProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVProduct.Location = new System.Drawing.Point(23, 115);
            this.dataGVProduct.Name = "dataGVProduct";
            this.dataGVProduct.Size = new System.Drawing.Size(472, 201);
            this.dataGVProduct.TabIndex = 17;
            // 
            // btnProductDelete
            // 
            this.btnProductDelete.Location = new System.Drawing.Point(344, 88);
            this.btnProductDelete.Name = "btnProductDelete";
            this.btnProductDelete.Size = new System.Drawing.Size(151, 23);
            this.btnProductDelete.TabIndex = 16;
            this.btnProductDelete.Text = "DELETE";
            this.btnProductDelete.UseVisualStyleBackColor = true;
            // 
            // btnProductUpdate
            // 
            this.btnProductUpdate.Location = new System.Drawing.Point(180, 88);
            this.btnProductUpdate.Name = "btnProductUpdate";
            this.btnProductUpdate.Size = new System.Drawing.Size(151, 23);
            this.btnProductUpdate.TabIndex = 15;
            this.btnProductUpdate.Text = "UPDATE";
            this.btnProductUpdate.UseVisualStyleBackColor = true;
            // 
            // btnProductAdd
            // 
            this.btnProductAdd.Location = new System.Drawing.Point(23, 88);
            this.btnProductAdd.Name = "btnProductAdd";
            this.btnProductAdd.Size = new System.Drawing.Size(151, 23);
            this.btnProductAdd.TabIndex = 14;
            this.btnProductAdd.Text = "ADD";
            this.btnProductAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxProductName
            // 
            this.txtBoxProductName.Location = new System.Drawing.Point(129, 27);
            this.txtBoxProductName.Name = "txtBoxProductName";
            this.txtBoxProductName.Size = new System.Drawing.Size(129, 20);
            this.txtBoxProductName.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Unit:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Product Price:";
            // 
            // txtBoxProductPrice
            // 
            this.txtBoxProductPrice.Location = new System.Drawing.Point(366, 54);
            this.txtBoxProductPrice.Name = "txtBoxProductPrice";
            this.txtBoxProductPrice.Size = new System.Drawing.Size(129, 20);
            this.txtBoxProductPrice.TabIndex = 23;
            // 
            // txtBoxProductNumber
            // 
            this.txtBoxProductNumber.Location = new System.Drawing.Point(129, 53);
            this.txtBoxProductNumber.Name = "txtBoxProductNumber";
            this.txtBoxProductNumber.Size = new System.Drawing.Size(129, 20);
            this.txtBoxProductNumber.TabIndex = 24;
            // 
            // FormProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 332);
            this.Controls.Add(this.txtBoxProductNumber);
            this.Controls.Add(this.txtBoxProductPrice);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxUnit);
            this.Controls.Add(this.dataGVProduct);
            this.Controls.Add(this.btnProductDelete);
            this.Controls.Add(this.btnProductUpdate);
            this.Controls.Add(this.btnProductAdd);
            this.Controls.Add(this.txtBoxProductName);
            this.Name = "FormProduct";
            this.Text = "FormProduct";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbBoxUnit;
        private System.Windows.Forms.DataGridView dataGVProduct;
        private System.Windows.Forms.Button btnProductDelete;
        private System.Windows.Forms.Button btnProductUpdate;
        private System.Windows.Forms.Button btnProductAdd;
        private System.Windows.Forms.TextBox txtBoxProductName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtBoxProductPrice;
        private System.Windows.Forms.TextBox txtBoxProductNumber;
    }
}