namespace CodeFirst_BillingProject
{
    partial class FormUnit
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
            this.dataGVUnit = new System.Windows.Forms.DataGridView();
            this.btnUnitDelete = new System.Windows.Forms.Button();
            this.btnUnitUpdate = new System.Windows.Forms.Button();
            this.btnUnitAdd = new System.Windows.Forms.Button();
            this.txtBoxUnitID = new System.Windows.Forms.TextBox();
            this.txtBoxUnitName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUnit)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVUnit
            // 
            this.dataGVUnit.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVUnit.Location = new System.Drawing.Point(23, 111);
            this.dataGVUnit.Name = "dataGVUnit";
            this.dataGVUnit.Size = new System.Drawing.Size(312, 201);
            this.dataGVUnit.TabIndex = 15;
            // 
            // btnUnitDelete
            // 
            this.btnUnitDelete.Location = new System.Drawing.Point(235, 82);
            this.btnUnitDelete.Name = "btnUnitDelete";
            this.btnUnitDelete.Size = new System.Drawing.Size(100, 23);
            this.btnUnitDelete.TabIndex = 14;
            this.btnUnitDelete.Text = "DELETE";
            this.btnUnitDelete.UseVisualStyleBackColor = true;
            // 
            // btnUnitUpdate
            // 
            this.btnUnitUpdate.Location = new System.Drawing.Point(129, 82);
            this.btnUnitUpdate.Name = "btnUnitUpdate";
            this.btnUnitUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnUnitUpdate.TabIndex = 13;
            this.btnUnitUpdate.Text = "UPDATE";
            this.btnUnitUpdate.UseVisualStyleBackColor = true;
            // 
            // btnUnitAdd
            // 
            this.btnUnitAdd.Location = new System.Drawing.Point(23, 82);
            this.btnUnitAdd.Name = "btnUnitAdd";
            this.btnUnitAdd.Size = new System.Drawing.Size(100, 23);
            this.btnUnitAdd.TabIndex = 12;
            this.btnUnitAdd.Text = "ADD";
            this.btnUnitAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxUnitID
            // 
            this.txtBoxUnitID.Location = new System.Drawing.Point(129, 23);
            this.txtBoxUnitID.Name = "txtBoxUnitID";
            this.txtBoxUnitID.Size = new System.Drawing.Size(206, 20);
            this.txtBoxUnitID.TabIndex = 11;
            // 
            // txtBoxUnitName
            // 
            this.txtBoxUnitName.Location = new System.Drawing.Point(129, 56);
            this.txtBoxUnitName.Name = "txtBoxUnitName";
            this.txtBoxUnitName.Size = new System.Drawing.Size(206, 20);
            this.txtBoxUnitName.TabIndex = 16;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(44, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 17;
            this.label1.Text = "UnitID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 13);
            this.label2.TabIndex = 18;
            this.label2.Text = "UnitName:";
            // 
            // FormUnit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBoxUnitName);
            this.Controls.Add(this.dataGVUnit);
            this.Controls.Add(this.btnUnitDelete);
            this.Controls.Add(this.btnUnitUpdate);
            this.Controls.Add(this.btnUnitAdd);
            this.Controls.Add(this.txtBoxUnitID);
            this.Name = "FormUnit";
            this.Text = "FormUnit";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVUnit)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dataGVUnit;
        private System.Windows.Forms.Button btnUnitDelete;
        private System.Windows.Forms.Button btnUnitUpdate;
        private System.Windows.Forms.Button btnUnitAdd;
        private System.Windows.Forms.TextBox txtBoxUnitID;
        private System.Windows.Forms.TextBox txtBoxUnitName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}