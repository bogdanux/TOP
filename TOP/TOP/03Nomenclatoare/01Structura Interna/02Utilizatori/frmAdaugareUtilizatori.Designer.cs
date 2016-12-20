namespace TOP
{
    partial class frmAdaugareUtilizatori
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
            this.lblDenumireFunctie = new System.Windows.Forms.Label();
            this.txtNume = new System.Windows.Forms.TextBox();
            this.chkActiv = new System.Windows.Forms.CheckBox();
            this.lblCodFunctie = new System.Windows.Forms.Label();
            this.txtCodUtilizator = new System.Windows.Forms.TextBox();
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.btnAdaugare = new System.Windows.Forms.Button();
            this.PanouAdaugare = new System.Windows.Forms.Panel();
            this.cmbFunctie = new System.Windows.Forms.ComboBox();
            this.lblNivel = new System.Windows.Forms.Label();
            this.msMeniuAdaugareFunctii = new System.Windows.Forms.MenuStrip();
            this.tsIesire = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            this.PanouAdaugare.SuspendLayout();
            this.msMeniuAdaugareFunctii.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblDenumireFunctie
            // 
            this.lblDenumireFunctie.AutoSize = true;
            this.lblDenumireFunctie.Location = new System.Drawing.Point(25, 37);
            this.lblDenumireFunctie.Name = "lblDenumireFunctie";
            this.lblDenumireFunctie.Size = new System.Drawing.Size(35, 13);
            this.lblDenumireFunctie.TabIndex = 0;
            this.lblDenumireFunctie.Text = "Nume";
            // 
            // txtNume
            // 
            this.txtNume.Location = new System.Drawing.Point(66, 34);
            this.txtNume.Name = "txtNume";
            this.txtNume.Size = new System.Drawing.Size(535, 20);
            this.txtNume.TabIndex = 1;
            this.txtNume.TextChanged += new System.EventHandler(this.txtNume_TextChanged);
            // 
            // chkActiv
            // 
            this.chkActiv.AutoSize = true;
            this.chkActiv.CheckAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkActiv.Enabled = false;
            this.chkActiv.Location = new System.Drawing.Point(24, 88);
            this.chkActiv.Name = "chkActiv";
            this.chkActiv.Size = new System.Drawing.Size(56, 17);
            this.chkActiv.TabIndex = 3;
            this.chkActiv.Text = "Activ?";
            this.chkActiv.UseVisualStyleBackColor = true;
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
            // txtCodUtilizator
            // 
            this.txtCodUtilizator.Enabled = false;
            this.txtCodUtilizator.Location = new System.Drawing.Point(66, 8);
            this.txtCodUtilizator.Name = "txtCodUtilizator";
            this.txtCodUtilizator.Size = new System.Drawing.Size(74, 20);
            this.txtCodUtilizator.TabIndex = 0;
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
            // btnAdaugare
            // 
            this.btnAdaugare.Enabled = false;
            this.btnAdaugare.Location = new System.Drawing.Point(66, 111);
            this.btnAdaugare.Name = "btnAdaugare";
            this.btnAdaugare.Size = new System.Drawing.Size(75, 23);
            this.btnAdaugare.TabIndex = 4;
            this.btnAdaugare.Text = "Adaugare";
            this.btnAdaugare.UseVisualStyleBackColor = true;
            this.btnAdaugare.Click += new System.EventHandler(this.btnAdaugare_Click);
            // 
            // PanouAdaugare
            // 
            this.PanouAdaugare.Controls.Add(this.cmbFunctie);
            this.PanouAdaugare.Controls.Add(this.btnAdaugare);
            this.PanouAdaugare.Controls.Add(this.lblCodFunctie);
            this.PanouAdaugare.Controls.Add(this.lblNivel);
            this.PanouAdaugare.Controls.Add(this.lblDenumireFunctie);
            this.PanouAdaugare.Controls.Add(this.chkActiv);
            this.PanouAdaugare.Controls.Add(this.txtNume);
            this.PanouAdaugare.Controls.Add(this.txtCodUtilizator);
            this.PanouAdaugare.Location = new System.Drawing.Point(12, 32);
            this.PanouAdaugare.Name = "PanouAdaugare";
            this.PanouAdaugare.Size = new System.Drawing.Size(610, 141);
            this.PanouAdaugare.TabIndex = 5;
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
            this.cmbFunctie.TabIndex = 2;
            this.cmbFunctie.SelectedIndexChanged += new System.EventHandler(this.cmbFunctie_SelectedIndexChanged);
            // 
            // lblNivel
            // 
            this.lblNivel.AutoSize = true;
            this.lblNivel.Location = new System.Drawing.Point(18, 64);
            this.lblNivel.Name = "lblNivel";
            this.lblNivel.Size = new System.Drawing.Size(42, 13);
            this.lblNivel.TabIndex = 0;
            this.lblNivel.Text = "Functie";
            // 
            // msMeniuAdaugareFunctii
            // 
            this.msMeniuAdaugareFunctii.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsIesire});
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
            // frmAdaugareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.PanouAdaugare);
            this.Controls.Add(this.dgvUtilizatori);
            this.Controls.Add(this.msMeniuAdaugareFunctii);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMeniuAdaugareFunctii;
            this.Name = "frmAdaugareUtilizatori";
            this.Text = "Adaugare utilizatori";
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            this.PanouAdaugare.ResumeLayout(false);
            this.PanouAdaugare.PerformLayout();
            this.msMeniuAdaugareFunctii.ResumeLayout(false);
            this.msMeniuAdaugareFunctii.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDenumireFunctie;
        private System.Windows.Forms.TextBox txtNume;
        private System.Windows.Forms.CheckBox chkActiv;
        private System.Windows.Forms.Label lblCodFunctie;
        private System.Windows.Forms.TextBox txtCodUtilizator;
        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.Button btnAdaugare;
        private System.Windows.Forms.Panel PanouAdaugare;
        private System.Windows.Forms.MenuStrip msMeniuAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem tsIesire;
        private System.Windows.Forms.ComboBox cmbFunctie;
        private System.Windows.Forms.Label lblNivel;
    }
}