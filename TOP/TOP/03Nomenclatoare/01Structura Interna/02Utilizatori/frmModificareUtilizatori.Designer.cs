namespace TOP
{
    partial class frmModificareUtilizatori
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
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.panouModificare = new System.Windows.Forms.Panel();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.btnGO = new System.Windows.Forms.Button();
            this.btnModificare = new System.Windows.Forms.Button();
            this.lblCodUtilizator = new System.Windows.Forms.Label();
            this.lblFunctie = new System.Windows.Forms.Label();
            this.lblNume = new System.Windows.Forms.Label();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.txtCodUtilizator = new System.Windows.Forms.TextBox();
            this.msMeniuAdaugareFunctii = new System.Windows.Forms.MenuStrip();
            this.tsIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.tsResetareCampuri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAdaugareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVizualizareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            this.panouModificare.SuspendLayout();
            this.msMeniuAdaugareFunctii.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvUtilizatori
            // 
            this.dgvUtilizatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori.Location = new System.Drawing.Point(13, 179);
            this.dgvUtilizatori.Name = "dgvUtilizatori";
            this.dgvUtilizatori.ReadOnly = true;
            this.dgvUtilizatori.RowHeadersVisible = false;
            this.dgvUtilizatori.Size = new System.Drawing.Size(609, 249);
            this.dgvUtilizatori.TabIndex = 3;
            // 
            // panouModificare
            // 
            this.panouModificare.Controls.Add(this.cmbFunctie);
            this.panouModificare.Controls.Add(this.btnGO);
            this.panouModificare.Controls.Add(this.btnModificare);
            this.panouModificare.Controls.Add(this.lblCodUtilizator);
            this.panouModificare.Controls.Add(this.lblFunctie);
            this.panouModificare.Controls.Add(this.lblNume);
            this.panouModificare.Controls.Add(this.chkActiv);
            this.panouModificare.Controls.Add(this.txtNume);
            this.panouModificare.Controls.Add(this.txtCodUtilizator);
            this.panouModificare.Location = new System.Drawing.Point(12, 32);
            this.panouModificare.Name = "panouModificare";
            this.panouModificare.Size = new System.Drawing.Size(610, 141);
            this.panouModificare.TabIndex = 5;
            // 
            // cmbFunctie
            // 
            this.cmbFunctie.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbFunctie.Enabled = false;
            this.cmbFunctie.FormattingEnabled = true;
            this.cmbFunctie.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbFunctie.Location = new System.Drawing.Point(66, 61);
            this.cmbFunctie.Name = "cmbFunctie";
            this.cmbFunctie.Size = new System.Drawing.Size(210, 21);
            this.cmbFunctie.TabIndex = 4;
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
            // lblCodUtilizator
            // 
            this.lblCodUtilizator.AutoSize = true;
            this.lblCodUtilizator.Location = new System.Drawing.Point(34, 11);
            this.lblCodUtilizator.Name = "lblCodUtilizator";
            this.lblCodUtilizator.Size = new System.Drawing.Size(26, 13);
            this.lblCodUtilizator.TabIndex = 0;
            this.lblCodUtilizator.Text = "Cod";
            // 
            // lblFunctie
            // 
            this.lblFunctie.AutoSize = true;
            this.lblFunctie.Location = new System.Drawing.Point(29, 64);
            this.lblFunctie.Name = "lblFunctie";
            this.lblFunctie.Size = new System.Drawing.Size(31, 13);
            this.lblFunctie.TabIndex = 0;
            this.lblFunctie.Text = "Nivel";
            // 
            // lblNume
            // 
            this.lblNume.AutoSize = true;
            this.lblNume.Location = new System.Drawing.Point(8, 37);
            this.lblNume.Name = "lblNume";
            this.lblNume.Size = new System.Drawing.Size(52, 13);
            this.lblNume.TabIndex = 0;
            this.lblNume.Text = "Denumire";
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
            // txtNume
            // 
            this.txtNume.Enabled = false;
            this.txtNume.Location = new System.Drawing.Point(66, 34);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(535, 20);
            this.txtNume.TabIndex = 3;
            this.txtNume.TextChanged += new System.EventHandler(this.txtDenumireFunctie_TextChanged);
            // 
            // txtCodUtilizator
            // 
            this.txtCodUtilizator.Location = new System.Drawing.Point(66, 8);
            this.txtCodUtilizator.Name = "txtCodUtilizator";
            this.txtCodUtilizator.Size = new System.Drawing.Size(74, 20);
            this.txtCodUtilizator.TabIndex = 1;
            this.txtCodUtilizator.TextChanged += new System.EventHandler(this.txtCodFunctie_TextChanged);
            // 
            // msMeniuAdaugareFunctii
            // 
            this.msMeniuAdaugareFunctii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIesire,
            this.tsResetareCampuri,
            this.btnAdaugareUtilizatori,
            this.btnVizualizareUtilizatori});
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
            // btnAdaugareUtilizatori
            // 
            this.btnAdaugareUtilizatori.Name = "btnAdaugareUtilizatori";
            this.btnAdaugareUtilizatori.Size = new System.Drawing.Size(122, 20);
            this.btnAdaugareUtilizatori.Text = "&Adaugare utilizatori";
            this.btnAdaugareUtilizatori.Click += new System.EventHandler(this.btnAdaugareUtilizatori_Click);
            // 
            // btnVizualizareUtilizatori
            // 
            this.btnVizualizareUtilizatori.Name = "btnVizualizareUtilizatori";
            this.btnVizualizareUtilizatori.Size = new System.Drawing.Size(126, 20);
            this.btnVizualizareUtilizatori.Text = "&Vizualizare utilizatori";
            this.btnVizualizareUtilizatori.Click += new System.EventHandler(this.btnVizualizareUtilizatori_Click);
            // 
            // frmModificareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.panouModificare);
            this.Controls.Add(this.dgvUtilizatori);
            this.Controls.Add(this.msMeniuAdaugareFunctii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMeniuAdaugareFunctii;
            this.Name = "frmModificareUtilizatori";
            this.Text = "Modificare utilizatori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            this.panouModificare.ResumeLayout(false);
            this.panouModificare.PerformLayout();
            this.msMeniuAdaugareFunctii.ResumeLayout(false);
            this.msMeniuAdaugareFunctii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.Panel panouModificare;
        private System.Windows.Forms.Button btnModificare;
        private System.Windows.Forms.Label lblCodUtilizator;
        private System.Windows.Forms.Label lblNume;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.TextBox txtCodUtilizator;
        private System.Windows.Forms.Button btnGO;
        private System.Windows.Forms.MenuStrip msMeniuAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem tsIesire;
        private System.Windows.Forms.ComboBox cmbFunctie;
        private System.Windows.Forms.Label lblFunctie;
        private System.Windows.Forms.ToolStripMenuItem tsResetareCampuri;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnVizualizareUtilizatori;
    }
}