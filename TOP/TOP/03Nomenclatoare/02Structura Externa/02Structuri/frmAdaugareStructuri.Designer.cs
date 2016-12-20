namespace TOP
{
    partial class frmAdaugareStructuri
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
            this.panouGeneral = new System.Windows.Forms.Panel();
            this.btnAdauga = new System.Windows.Forms.Button();
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
            this.fisierToolStripMenuItem});
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
            this.btnIesire.Size = new System.Drawing.Size(152, 22);
            this.btnIesire.Text = "I&esire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // panouGeneral
            // 
            this.panouGeneral.Controls.Add(this.btnAdauga);
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
            // btnAdauga
            // 
            this.btnAdauga.Enabled = false;
            this.btnAdauga.Location = new System.Drawing.Point(104, 85);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(200, 23);
            this.btnAdauga.TabIndex = 6;
            this.btnAdauga.Text = "Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Click += new System.EventHandler(this.btnAdauga_Click);
            // 
            // txtDenumire
            // 
            this.txtDenumire.Location = new System.Drawing.Point(104, 33);
            this.txtDenumire.Name = "txtDenumire";
            this.txtDenumire.Size = new System.Drawing.Size(489, 20);
            this.txtDenumire.TabIndex = 2;
            this.txtDenumire.TextChanged += new System.EventHandler(this.txtDenumire_TextChanged);
            // 
            // txtCod
            // 
            this.txtCod.Enabled = false;
            this.txtCod.Location = new System.Drawing.Point(104, 7);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(74, 20);
            this.txtCod.TabIndex = 1;
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
            // frmAdaugareStructuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 411);
            this.Controls.Add(this.dgvStructuri);
            this.Controls.Add(this.panouGeneral);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmAdaugareStructuri";
            this.Text = "Adaugare structuri";
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
        private System.Windows.Forms.Button btnAdauga;
        private System.Windows.Forms.DataGridView dgvStructuri;
    }
}