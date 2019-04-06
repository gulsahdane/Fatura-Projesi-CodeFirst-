namespace CodeFirst_BillingProject
{
    partial class FormCity
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
            this.txtBoxCity = new System.Windows.Forms.TextBox();
            this.btnCityAdd = new System.Windows.Forms.Button();
            this.btnCityUpdate = new System.Windows.Forms.Button();
            this.btnCityDelete = new System.Windows.Forms.Button();
            this.dataGVCity = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCity)).BeginInit();
            this.SuspendLayout();
            // 
            // txtBoxCity
            // 
            this.txtBoxCity.Location = new System.Drawing.Point(130, 21);
            this.txtBoxCity.Name = "txtBoxCity";
            this.txtBoxCity.Size = new System.Drawing.Size(206, 20);
            this.txtBoxCity.TabIndex = 0;
            // 
            // btnCityAdd
            // 
            this.btnCityAdd.Location = new System.Drawing.Point(24, 55);
            this.btnCityAdd.Name = "btnCityAdd";
            this.btnCityAdd.Size = new System.Drawing.Size(100, 23);
            this.btnCityAdd.TabIndex = 1;
            this.btnCityAdd.Text = "ADD";
            this.btnCityAdd.UseVisualStyleBackColor = true;
            this.btnCityAdd.Click += new System.EventHandler(this.btnCityAdd_Click);
            // 
            // btnCityUpdate
            // 
            this.btnCityUpdate.Location = new System.Drawing.Point(130, 55);
            this.btnCityUpdate.Name = "btnCityUpdate";
            this.btnCityUpdate.Size = new System.Drawing.Size(100, 23);
            this.btnCityUpdate.TabIndex = 2;
            this.btnCityUpdate.Text = "UPDATE";
            this.btnCityUpdate.UseVisualStyleBackColor = true;
            this.btnCityUpdate.Click += new System.EventHandler(this.btnCityUpdate_Click);
            // 
            // btnCityDelete
            // 
            this.btnCityDelete.Location = new System.Drawing.Point(236, 55);
            this.btnCityDelete.Name = "btnCityDelete";
            this.btnCityDelete.Size = new System.Drawing.Size(100, 23);
            this.btnCityDelete.TabIndex = 3;
            this.btnCityDelete.Text = "DELETE";
            this.btnCityDelete.UseVisualStyleBackColor = true;
            this.btnCityDelete.Click += new System.EventHandler(this.btnCityDelete_Click);
            // 
            // dataGVCity
            // 
            this.dataGVCity.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGVCity.Location = new System.Drawing.Point(24, 84);
            this.dataGVCity.Name = "dataGVCity";
            this.dataGVCity.Size = new System.Drawing.Size(312, 201);
            this.dataGVCity.TabIndex = 4;
            this.dataGVCity.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGVCity_CellContentClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(59, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "City:";
            // 
            // FormCity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGVCity);
            this.Controls.Add(this.btnCityDelete);
            this.Controls.Add(this.btnCityUpdate);
            this.Controls.Add(this.btnCityAdd);
            this.Controls.Add(this.txtBoxCity);
            this.Name = "FormCity";
            this.Text = "FormCity";
            this.Load += new System.EventHandler(this.FormCity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGVCity)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBoxCity;
        private System.Windows.Forms.Button btnCityAdd;
        private System.Windows.Forms.Button btnCityUpdate;
        private System.Windows.Forms.Button btnCityDelete;
        private System.Windows.Forms.DataGridView dataGVCity;
        private System.Windows.Forms.Label label1;
    }
}