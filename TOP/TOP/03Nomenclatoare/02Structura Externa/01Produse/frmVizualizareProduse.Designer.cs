﻿namespace TOP
{
    partial class frmVizualizareProduse
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
            this.msMenu = new System.Windows.Forms.MenuStrip();
            this.btnIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvProduse = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire,
            this.btnAdaugareProduse,
            this.btnModificareProduse});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(634, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // btnIesire
            // 
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(46, 20);
            this.btnIesire.Text = "&Iesire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnAdaugareProduse
            // 
            this.btnAdaugareProduse.Name = "btnAdaugareProduse";
            this.btnAdaugareProduse.Size = new System.Drawing.Size(116, 20);
            this.btnAdaugareProduse.Text = "&Adaugare produse";
            this.btnAdaugareProduse.Click += new System.EventHandler(this.btnAdaugareProduse_Click);
            // 
            // btnModificareProduse
            // 
            this.btnModificareProduse.Name = "btnModificareProduse";
            this.btnModificareProduse.Size = new System.Drawing.Size(122, 20);
            this.btnModificareProduse.Text = "&Modificare produse";
            this.btnModificareProduse.Click += new System.EventHandler(this.btnModificareProduse_Click);
            // 
            // dgvProduse
            // 
            this.dgvProduse.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvProduse.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProduse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvProduse.Location = new System.Drawing.Point(0, 24);
            this.dgvProduse.Name = "dgvProduse";
            this.dgvProduse.ReadOnly = true;
            this.dgvProduse.RowHeadersVisible = false;
            this.dgvProduse.Size = new System.Drawing.Size(634, 417);
            this.dgvProduse.TabIndex = 1;
            // 
            // frmVizualizareProduse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.dgvProduse);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmVizualizareProduse";
            this.Text = "Vizualizare produse";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProduse)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.DataGridView dgvProduse;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareProduse;
        private System.Windows.Forms.ToolStripMenuItem btnModificareProduse;
    }
}