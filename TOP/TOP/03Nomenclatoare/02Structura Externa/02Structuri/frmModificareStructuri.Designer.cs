﻿namespace TOP
{
    partial class frmModificareStructuri
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
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugareStructuri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVizualizareStructuri = new System.Windows.Forms.ToolStripMenuItem();
            this.panouGeneral = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnModifica = new System.Windows.Forms.Button();
            this.txtDenumire = new System.Windows.Forms.TextBox();
            this.txtCod = new System.Windows.Forms.TextBox();
            this.dtDataAdaugare = new System.Windows.Forms.DateTimePicker();
            this.lblDataAdaugare = new System.Windows.Forms.Label();
            this.lblDenumireProdus = new System.Windows.Forms.Label();
            this.lblCod = new System.Windows.Forms.Label();
            this.dgvStructuri = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            this.panouGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructuri)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem,
            this.btnAdaugareStructuri,
            this.btnVizualizareStructuri});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(634, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // btnIesire
            // 
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(101, 22);
            this.btnIesire.Text = "I&esire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // btnAdaugareStructuri
            // 
            this.btnAdaugareStructuri.Name = "btnAdaugareStructuri";
            this.btnAdaugareStructuri.Size = new System.Drawing.Size(117, 20);
            this.btnAdaugareStructuri.Text = "&Adaugare structuri";
            this.btnAdaugareStructuri.Click += new System.EventHandler(this.btnAdaugareStructuri_Click);
            // 
            // btnVizualizareStructuri
            // 
            this.btnVizualizareStructuri.Name = "btnVizualizareStructuri";
            this.btnVizualizareStructuri.Size = new System.Drawing.Size(121, 20);
            this.btnVizualizareStructuri.Text = "&Vizualizare structuri";
            this.btnVizualizareStructuri.Click += new System.EventHandler(this.btnVizualizareStructuri_Click);
            // 
            // panouGeneral
            // 
            this.panouGeneral.Controls.Add(this.btnOK);
            this.panouGeneral.Controls.Add(this.btnModifica);
            this.panouGeneral.Controls.Add(this.txtDenumire);
            this.panouGeneral.Controls.Add(this.txtCod);
            this.panouGeneral.Controls.Add(this.dtDataAdaugare);
            this.panouGeneral.Controls.Add(this.lblDataAdaugare);
            this.panouGeneral.Controls.Add(this.lblDenumireProdus);
            this.panouGeneral.Controls.Add(this.lblCod);
            this.panouGeneral.Location = new System.Drawing.Point(12, 32);
            this.panouGeneral.Name = "panouGeneral";
            this.panouGeneral.Size = new System.Drawing.Size(610, 116);
            this.panouGeneral.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(184, 5);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(40, 23);
            this.btnOK.TabIndex = 7;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnModifica
            // 
            this.btnModifica.Enabled = false;
            this.btnModifica.Location = new System.Drawing.Point(104, 85);
            this.btnModifica.Name = "btnModifica";
            this.btnModifica.Size = new System.Drawing.Size(200, 23);
            this.btnModifica.TabIndex = 6;
            this.btnModifica.Text = "Modifica";
            this.btnModifica.UseVisualStyleBackColor = true;
            this.btnModifica.Click += new System.EventHandler(this.btnModifica_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Enabled = false;
            this.txtDenumire.Location = new System.Drawing.Point(104, 33);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(489, 20);
            this.txtDenumire.TabIndex = 2;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtDenumire_TextChanged);
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(104, 7);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(74, 20);
            this.txtCod.TabIndex = 1;
            this.txtCod.TextChanged += new System.EventHandler(this.txtCod_TextChanged);
            // 
            // dtDataAdaugare
            // 
            this.dtDataAdaugare.Enabled = false;
            this.dtDataAdaugare.Location = new System.Drawing.Point(104, 59);
            this.dtDataAdaugare.Name = "dtDataAdaugare";
            this.dtDataAdaugare.Size = new System.Drawing.Size(200, 20);
            this.dtDataAdaugare.TabIndex = 3;
            // 
            // lblDataAdaugare
            // 
            this.lblDataAdaugare.AutoSize = true;
            this.lblDataAdaugare.Location = new System.Drawing.Point(20, 62);
            this.lblDataAdaugare.Name = "lblDataAdaugare";
            this.lblDataAdaugare.Size = new System.Drawing.Size(78, 13);
            this.lblDataAdaugare.TabIndex = 0;
            this.lblDataAdaugare.Text = "Data adaugare";
            // 
            // lblDenumireProdus
            // 
            this.lblDenumireProdus.AutoSize = true;
            this.lblDenumireProdus.Location = new System.Drawing.Point(46, 36);
            this.lblDenumireProdus.Name = "lblDenumireProdus";
            this.lblDenumireProdus.Size = new System.Drawing.Size(52, 13);
            this.lblDenumireProdus.TabIndex = 0;
            this.lblDenumireProdus.Text = "Denumire";
            // 
            // lblCod
            // 
            this.lblCod.AutoSize = true;
            this.lblCod.Location = new System.Drawing.Point(28, 10);
            this.lblCod.Name = "lblCod";
            this.lblCod.Size = new System.Drawing.Size(70, 13);
            this.lblCod.TabIndex = 0;
            this.lblCod.Text = "Cod structura";
            // 
            // dgvStructuri
            // 
            this.dgvStructuri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStructuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStructuri.Location = new System.Drawing.Point(12, 154);
            this.dgvStructuri.Name = "dgvStructuri";
            this.dgvStructuri.ReadOnly = true;
            this.dgvStructuri.RowHeadersVisible = false;
            this.dgvStructuri.Size = new System.Drawing.Size(610, 247);
            this.dgvStructuri.TabIndex = 7;
            // 
            // frmModificareStructuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.dgvStructuri);
            this.Controls.Add(this.panouGeneral);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmModificareStructuri";
            this.Text = "Modificare structuri";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panouGeneral.ResumeLayout(false);
            this.panouGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.Panel panouGeneral;
        private System.Windows.Forms.Label lblCod;
        private System.Windows.Forms.Label lblDenumireProdus;
        private System.Windows.Forms.DateTimePicker dtDataAdaugare;
        private System.Windows.Forms.Label lblDataAdaugare;
        private System.Windows.Forms.TextBox txtCod;
        private System.Windows.Forms.TextBox txtDenumire;
        private System.Windows.Forms.Button btnModifica;
        private System.Windows.Forms.DataGridView dgvStructuri;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareStructuri;
        private System.Windows.Forms.ToolStripMenuItem btnVizualizareStructuri;
    }
}