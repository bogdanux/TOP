﻿namespace TOP
{
    partial class frmVizualizareFunctii
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
            this.btnAdaugareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvFunctii = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctii)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire,
            this.btnAdaugareFunctii,
            this.btnModificareFunctii});
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
            // btnAdaugareFunctii
            // 
            this.btnAdaugareFunctii.Name = "btnAdaugareFunctii";
            this.btnAdaugareFunctii.Size = new System.Drawing.Size(107, 20);
            this.btnAdaugareFunctii.Text = "&Adaugare functii";
            this.btnAdaugareFunctii.Click += new System.EventHandler(this.btnAdaugareFunctii_Click);
            // 
            // btnModificareFunctii
            // 
            this.btnModificareFunctii.Name = "btnModificareFunctii";
            this.btnModificareFunctii.Size = new System.Drawing.Size(113, 20);
            this.btnModificareFunctii.Text = "&Modificare functii";
            this.btnModificareFunctii.Click += new System.EventHandler(this.btnModificareFunctii_Click);
            // 
            // dgvFunctii
            // 
            this.dgvFunctii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunctii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctii.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvFunctii.Location = new System.Drawing.Point(0, 24);
            this.dgvFunctii.Name = "dgvFunctii";
            this.dgvFunctii.ReadOnly = true;
            this.dgvFunctii.RowHeadersVisible = false;
            this.dgvFunctii.Size = new System.Drawing.Size(634, 417);
            this.dgvFunctii.TabIndex = 1;
            // 
            // frmVizualizareFunctii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.dgvFunctii);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmVizualizareFunctii";
            this.Text = "Vizualizare functii";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctii)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.DataGridView dgvFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnModificareFunctii;
    }
}