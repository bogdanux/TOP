namespace TOP
{
    partial class frmModificareFunctii
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
            this.dgvFunctii = new System.Windows.Forms.DataGridView();
            this.panouModificare = new System.Windows.Forms.Panel();
            this.cmbNivel = new System.Windows.Forms.ComboBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.lblCodFunctie = new System.Windows.Forms.Label();
            this.lblNivel = new System.Windows.Forms.Label();
            this.lblDenumireFunctie = new System.Windows.Forms.Label();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.txtDenumireFunctie = new System.Windows.Forms.TextBox();
            this.txtCodFunctie = new System.Windows.Forms.TextBox();
            this.msMeniuAdaugareFunctii = new System.Windows.Forms.MenuStrip();
            this.tsIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResetareCampuri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVizualizareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctii)).BeginInit();
            this.panouModificare.SuspendLayout();
            this.msMeniuAdaugareFunctii.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvFunctii
            // 
            this.dgvFunctii.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvFunctii.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvFunctii.Location = new System.Drawing.Point(13, 179);
            this.dgvFunctii.Name = "dgvFunctii";
            this.dgvFunctii.ReadOnly = true;
            this.dgvFunctii.RowHeadersVisible = false;
            this.dgvFunctii.Size = new System.Drawing.Size(609, 249);
            this.dgvFunctii.TabIndex = 3;
            // 
            // panouModificare
            // 
            this.panouModificare.Controls.Add(this.cmbNivel);
            this.panouModificare.Controls.Add(this.btnGO);
            this.panouModificare.Controls.Add(this.btnModificare);
            this.panouModificare.Controls.Add(this.lblCodFunctie);
            this.panouModificare.Controls.Add(this.lblNivel);
            this.panouModificare.Controls.Add(this.lblDenumireFunctie);
            this.panouModificare.Controls.Add(this.chkActiv);
            this.panouModificare.Controls.Add(this.txtDenumireFunctie);
            this.panouModificare.Controls.Add(this.txtCodFunctie);
            this.panouModificare.Location = new System.Drawing.Point(12, 32);
            this.panouModificare.Name = "panouModificare";
            this.panouModificare.Size = new System.Drawing.Size(610, 141);
            this.panouModificare.TabIndex = 5;
            // 
            // cmbNivel
            // 
            this.cmbNivel.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbNivel.Enabled = false;
            this.cmbNivel.FormattingEnabled = true;
            this.cmbNivel.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbNivel.Location = new System.Drawing.Point(66, 61);
            this.cmbNivel.Name = "cmbNivel";
            this.cmbNivel.Size = new System.Drawing.Size(210, 21);
            this.cmbNivel.TabIndex = 4;
            // 
            // btnGO
            // 
            this.btnGO.Enabled = false;
            this.btnGO.Location = new System.Drawing.Point(147, 6);
            this.btnGO.Name = "btnGO";
            this.btnGO.Size = new System.Drawing.Size(33, 23);
            this.btnGO.TabIndex = 2;
            this.btnGO.Text = "OK";
            this.btnGO.UseVisualStyleBackColor = true;
            this.btnGO.Click += new System.EventHandler(this.btnGO_Click);
            // 
            // btnModificare
            // 
            this.btnModificare.Enabled = false;
            this.btnModificare.Location = new System.Drawing.Point(66, 111);
            this.btnModificare.Name = "btnModificare";
            this.btnModificare.Size = new System.Drawing.Size(75, 23);
            this.btnModificare.TabIndex = 6;
            this.btnModificare.Text = "Modificare";
            this.btnModificare.UseVisualStyleBackColor = true;
            this.btnModificare.Click += new System.EventHandler(this.btnModificare_Click);
            // 
            // lblCodFunctie
            // 
            this.lblCodFunctie.AutoSize = true;
            this.lblCodFunctie.Location = new System.Drawing.Point(34, 11);
            this.lblCodFunctie.Name = "lblCodFunctie";
            this.lblCodFunctie.Size = new System.Drawing.Size(26, 13);
            this.lblCodFunctie.TabIndex = 0;
            this.lblCodFunctie.Text = "Cod";
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(29, 64);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(31, 13);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Nivel";
            // 
            // lblDenumireFunctie
            // 
            this.lblDenumireFunctie.AutoSize = true;
            this.lblDenumireFunctie.Location = new System.Drawing.Point(8, 37);
            this.lblDenumireFunctie.Name = "lblDenumireFunctie";
            this.lblDenumireFunctie.Size = new System.Drawing.Size(52, 13);
            this.lblDenumireFunctie.TabIndex = 0;
            this.lblDenumireFunctie.Text = "Denumire";
            // 
            // chkActiv
            // 
            this.chkActiv.AutoSize = true;
            this.chkActiv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActiv.Enabled = false;
            this.chkActiv.Location = new System.Drawing.Point(24, 88);
            this.chkActiv.Name = "chkActiv";
            this.chkActiv.Size = new System.Drawing.Size(56, 17);
            this.chkActiv.TabIndex = 5;
            this.chkActiv.Text = "Activ?";
            this.chkActiv.UseVisualStyleBackColor = true;
            // 
            // txtDenumireFunctie
            // 
            this.txtDenumireFunctie.Enabled = false;
            this.txtDenumireFunctie.Location = new System.Drawing.Point(66, 34);
            this.txtDenumireFunctie.Name = "txtDenumireFunctie";
            this.txtDenumireFunctie.Size = new System.Drawing.Size(535, 20);
            this.txtDenumireFunctie.TabIndex = 3;
            this.txtDenumireFunctie.TextChanged += new System.EventHandler(this.txtDenumireFunctie_TextChanged);
            // 
            // txtCodFunctie
            // 
            this.txtCodFunctie.Location = new System.Drawing.Point(66, 8);
            this.txtCodFunctie.Name = "txtCodFunctie";
            this.txtCodFunctie.Size = new System.Drawing.Size(74, 20);
            this.txtCodFunctie.TabIndex = 1;
            this.txtCodFunctie.TextChanged += new System.EventHandler(this.txtCodFunctie_TextChanged);
            // 
            // msMeniuAdaugareFunctii
            // 
            this.msMeniuAdaugareFunctii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIesire,
            this.tsResetareCampuri,
            this.btnAdaugareFunctii,
            this.btnVizualizareFunctii});
            this.msMeniuAdaugareFunctii.Location = new System.Drawing.Point(0, 0);
            this.msMeniuAdaugareFunctii.Name = "msMeniuAdaugareFunctii";
            this.msMeniuAdaugareFunctii.Size = new System.Drawing.Size(634, 24);
            this.msMeniuAdaugareFunctii.TabIndex = 6;
            this.msMeniuAdaugareFunctii.Text = "menuStrip1";
            // 
            // tsIesire
            // 
            this.tsIesire.Name = "tsIesire";
            this.tsIesire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
            this.tsIesire.Size = new System.Drawing.Size(46, 20);
            this.tsIesire.Text = "I&esire";
            this.tsIesire.Click += new System.EventHandler(this.tsIesire_Click);
            // 
            // tsResetareCampuri
            // 
            this.tsResetareCampuri.Name = "tsResetareCampuri";
            this.tsResetareCampuri.Size = new System.Drawing.Size(110, 20);
            this.tsResetareCampuri.Text = "&Resetare campuri";
            this.tsResetareCampuri.Click += new System.EventHandler(this.tsResetareCampuri_Click);
            // 
            // btnAdaugareFunctii
            // 
            this.btnAdaugareFunctii.Name = "btnAdaugareFunctii";
            this.btnAdaugareFunctii.Size = new System.Drawing.Size(107, 20);
            this.btnAdaugareFunctii.Text = "&Adaugare functii";
            this.btnAdaugareFunctii.Click += new System.EventHandler(this.btnAdaugareFunctii_Click);
            // 
            // btnVizualizareFunctii
            // 
            this.btnVizualizareFunctii.Name = "btnVizualizareFunctii";
            this.btnVizualizareFunctii.Size = new System.Drawing.Size(111, 20);
            this.btnVizualizareFunctii.Text = "&Vizualizare functii";
            this.btnVizualizareFunctii.Click += new System.EventHandler(this.btnVizualizareFunctii_Click);
            // 
            // frmModificareFunctii
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.panouModificare);
            this.Controls.Add(this.dgvFunctii);
            this.Controls.Add(this.msMeniuAdaugareFunctii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMeniuAdaugareFunctii;
            this.Name = "frmModificareFunctii";
            this.Text = "Modificare functie";
            ((System.ComponentModel.ISupportInitialize)(this.dgvFunctii)).EndInit();
            this.panouModificare.ResumeLayout(false);
            this.panouModificare.PerformLayout();
            this.msMeniuAdaugareFunctii.ResumeLayout(false);
            this.msMeniuAdaugareFunctii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvFunctii;
        private System.Windows.Forms.Panel panouModificare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Label lblCodFunctie;
        private System.Windows.Forms.Label lblDenumireFunctie;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.TextBox txtDenumireFunctie;
        private System.Windows.Forms.TextBox txtCodFunctie;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.MenuStrip msMeniuAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem tsIesire;
        private System.Windows.Forms.ComboBox cmbNivel;
        private System.Windows.Forms.Label lblNivel;
        private System.Windows.Forms.ToolStripMenuItem tsResetareCampuri;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnVizualizareFunctii;
    }
}