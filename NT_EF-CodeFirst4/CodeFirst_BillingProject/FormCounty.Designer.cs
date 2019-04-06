namespace CodeFirst_BillingProject
{
    partial class FormCounty
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
            this.dataGVCounty = new System.Windows.Forms.DataGridView();
            this.btnCountyDelete = new System.Windows.Forms.Button();
            this.btnCountyUpdate = new System.Windows.Forms.Button();
            this.btnCountyAdd = new System.Windows.Forms.Button();
            this.txtBoxCounty = new System.Windows.Forms.TextBox();
            this.cmbBoxCity = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCounty)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGVCounty
            // 
            this.dataGVCounty.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCounty.Location = new System.Drawing.Point(24, 120);
            this.dataGVCounty.Name = "dataGVCounty";
            this.dataGVCounty.Size = new System.Drawing.Size(312, 201);
            this.dataGVCounty.TabIndex = 9;
            // 
            // btnCountyDelete
            // 
            this.btnCountyDelete.Location = new System.Drawing.Point(236, 91);
            this.btnCountyDelete.Name = "btnCountyDelete";
            this.btnCountyDelete.Size = new System.Drawing.Size(100, 23);
            this.btnCountyDelete.TabIndex = 8;
            this.btnCountyDelete.Text = "DELETE";
            this.btnCountyDelete.UseVisualStyleBackColor = true;
            // 
            // btnCountyUpdate
            // 
            this.btnCountyUpdate.Location = new System.Drawing.Point(130, 91);
            this.btnCountyUpdate.Name = "btnCountyUpdate";
            this.btnCountyUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnCountyUpdate.TabIndex = 7;
            this.btnCountyUpdate.Text = "UPDATE";
            this.btnCountyUpdate.UseVisualStyleBackColor = true;
            // 
            // btnCountyAdd
            // 
            this.btnCountyAdd.Location = new System.Drawing.Point(24, 91);
            this.btnCountyAdd.Name = "btnCountyAdd";
            this.btnCountyAdd.Size = new System.Drawing.Size(100, 23);
            this.btnCountyAdd.TabIndex = 6;
            this.btnCountyAdd.Text = "ADD";
            this.btnCountyAdd.UseVisualStyleBackColor = true;
            // 
            // txtBoxCounty
            // 
            this.txtBoxCounty.Location = new System.Drawing.Point(130, 32);
            this.txtBoxCounty.Name = "txtBoxCounty";
            this.txtBoxCounty.Size = new System.Drawing.Size(206, 20);
            this.txtBoxCounty.TabIndex = 5;
            // 
            // cmbBoxCity
            // 
            this.cmbBoxCity.FormattingEnabled = true;
            this.cmbBoxCity.Location = new System.Drawing.Point(130, 58);
            this.cmbBoxCity.Name = "cmbBoxCity";
            this.cmbBoxCity.Size = new System.Drawing.Size(206, 21);
            this.cmbBoxCity.TabIndex = 10;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 11;
            this.label1.Text = "County:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(59, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(27, 13);
            this.label2.TabIndex = 12;
            this.label2.Text = "City:";
            // 
            // FormCounty
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 337);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cmbBoxCity);
            this.Controls.Add(this.dataGVCounty);
            this.Controls.Add(this.btnCountyDelete);
            this.Controls.Add(this.btnCountyUpdate);
            this.Controls.Add(this.btnCountyAdd);
            this.Controls.Add(this.txtBoxCounty);
            this.Name = "FormCounty";
            this.Text = "FormCounty";
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCounty)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGVCounty;
        private System.Windows.Forms.Button btnCountyDelete;
        private System.Windows.Forms.Button btnCountyUpdate;
        private System.Windows.Forms.Button btnCountyAdd;
        private System.Windows.Forms.TextBox txtBoxCounty;
        private System.Windows.Forms.ComboBox cmbBoxCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}