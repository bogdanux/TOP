namespace TOP
{
    partial class frmVizualizareNiveluri
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
            this.btnFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.btnIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.panouGeneral = new System.Windows.Forms.Panel();
            this.btnOK = new System.Windows.Forms.Button();
            this.cmbStructuri = new System.Windows.Forms.ComboBox();
            this.lblStructura = new System.Windows.Forms.Label();
            this.dgvNiveluri = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            this.panouGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveluri)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFisier});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(1008, 24);
            this.msMenu.TabIndex = 0;
            this.msMenu.Text = "menuStrip1";
            // 
            // btnFisier
            // 
            this.btnFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire});
            this.btnFisier.Name = "btnFisier";
            this.btnFisier.Size = new System.Drawing.Size(46, 20);
            this.btnFisier.Text = "&Fisier";
            // 
            // btnIesire
            // 
            this.btnIesire.Name = "btnIesire";
            this.btnIesire.Size = new System.Drawing.Size(101, 22);
            this.btnIesire.Text = "I&esire";
            this.btnIesire.Click += new System.EventHandler(this.btnIesire_Click);
            // 
            // panouGeneral
            // 
            this.panouGeneral.Controls.Add(this.btnOK);
            this.panouGeneral.Controls.Add(this.cmbStructuri);
            this.panouGeneral.Controls.Add(this.lblStructura);
            this.panouGeneral.Location = new System.Drawing.Point(12, 32);
            this.panouGeneral.Name = "panouGeneral";
            this.panouGeneral.Size = new System.Drawing.Size(984, 36);
            this.panouGeneral.TabIndex = 1;
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(475, 6);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(57, 23);
            this.btnOK.TabIndex = 1;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // cmbStructuri
            // 
            this.cmbStructuri.FormattingEnabled = true;
            this.cmbStructuri.Location = new System.Drawing.Point(106, 7);
            this.cmbStructuri.Name = "cmbStructuri";
            this.cmbStructuri.Size = new System.Drawing.Size(363, 21);
            this.cmbStructuri.TabIndex = 0;
            this.cmbStructuri.SelectedIndexChanged += new System.EventHandler(this.cmbStructuri_SelectedIndexChanged);
            // 
            // lblStructura
            // 
            this.lblStructura.AutoSize = true;
            this.lblStructura.Location = new System.Drawing.Point(8, 10);
            this.lblStructura.Name = "lblStructura";
            this.lblStructura.Size = new System.Drawing.Size(92, 13);
            this.lblStructura.TabIndex = 0;
            this.lblStructura.Text = "Selectati structura";
            // 
            // dgvNiveluri
            // 
            this.dgvNiveluri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvNiveluri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvNiveluri.Enabled = false;
            this.dgvNiveluri.Location = new System.Drawing.Point(12, 74);
            this.dgvNiveluri.Name = "dgvNiveluri";
            this.dgvNiveluri.RowHeadersVisible = false;
            this.dgvNiveluri.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvNiveluri.Size = new System.Drawing.Size(984, 355);
            this.dgvNiveluri.TabIndex = 2;
            // 
            // frmVizualizareNiveluri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1008, 441);
            this.Controls.Add(this.dgvNiveluri);
            this.Controls.Add(this.panouGeneral);
            this.Controls.Add(this.msMenu);
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmVizualizareNiveluri";
            this.Text = "Vizualizare niveluri";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            this.panouGeneral.ResumeLayout(false);
            this.panouGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvNiveluri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem btnFisier;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.Panel panouGeneral;
        private System.Windows.Forms.Label lblStructura;
        private System.Windows.Forms.ComboBox cmbStructuri;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.DataGridView dgvNiveluri;
    }
}