namespace CodeFirst_BillingProject
{
    partial class Form1
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.supportTablesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ınvoiceTransactionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cityDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.countyDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.unitDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.productDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.customerDefinationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.supportTablesToolStripMenuItem,
            this.ınvoiceTransactionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // supportTablesToolStripMenuItem
            // 
            this.supportTablesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.cityDefinationToolStripMenuItem,
            this.countyDefinationToolStripMenuItem,
            this.unitDefinationToolStripMenuItem,
            this.productDefinationToolStripMenuItem,
            this.customerDefinationToolStripMenuItem});
            this.supportTablesToolStripMenuItem.Name = "supportTablesToolStripMenuItem";
            this.supportTablesToolStripMenuItem.Size = new System.Drawing.Size(98, 20);
            this.supportTablesToolStripMenuItem.Text = "Support Tables";
            // 
            // ınvoiceTransactionsToolStripMenuItem
            // 
            this.ınvoiceTransactionsToolStripMenuItem.Name = "ınvoiceTransactionsToolStripMenuItem";
            this.ınvoiceTransactionsToolStripMenuItem.Size = new System.Drawing.Size(127, 20);
            this.ınvoiceTransactionsToolStripMenuItem.Text = "Invoice Transactions";
            // 
            // cityDefinationToolStripMenuItem
            // 
            this.cityDefinationToolStripMenuItem.Name = "cityDefinationToolStripMenuItem";
            this.cityDefinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.cityDefinationToolStripMenuItem.Text = "City Defination";
            this.cityDefinationToolStripMenuItem.Click += new System.EventHandler(this.cityDefinationToolStripMenuItem_Click);
            // 
            // countyDefinationToolStripMenuItem
            // 
            this.countyDefinationToolStripMenuItem.Name = "countyDefinationToolStripMenuItem";
            this.countyDefinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.countyDefinationToolStripMenuItem.Text = "County Defination";
            this.countyDefinationToolStripMenuItem.Click += new System.EventHandler(this.countyDefinationToolStripMenuItem_Click);
            // 
            // unitDefinationToolStripMenuItem
            // 
            this.unitDefinationToolStripMenuItem.Name = "unitDefinationToolStripMenuItem";
            this.unitDefinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.unitDefinationToolStripMenuItem.Text = "Unit Defination";
            this.unitDefinationToolStripMenuItem.Click += new System.EventHandler(this.unitDefinationToolStripMenuItem_Click);
            // 
            // productDefinationToolStripMenuItem
            // 
            this.productDefinationToolStripMenuItem.Name = "productDefinationToolStripMenuItem";
            this.productDefinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.productDefinationToolStripMenuItem.Text = "Product Defination";
            this.productDefinationToolStripMenuItem.Click += new System.EventHandler(this.productDefinationToolStripMenuItem_Click);
            // 
            // customerDefinationToolStripMenuItem
            // 
            this.customerDefinationToolStripMenuItem.Name = "customerDefinationToolStripMenuItem";
            this.customerDefinationToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.customerDefinationToolStripMenuItem.Text = "Customer Defination";
            this.customerDefinationToolStripMenuItem.Click += new System.EventHandler(this.customerDefinationToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem supportTablesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ınvoiceTransactionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cityDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem countyDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem unitDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem productDefinationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem customerDefinationToolStripMenuItem;
    }
}

