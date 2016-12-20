namespace TOP
{
    partial class frmVizualizareUtilizatori
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
            this.btnAdaugareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareUtilzatori = new System.Windows.Forms.ToolStripMenuItem();
            this.dgvUtilizatori = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnIesire,
            this.btnAdaugareUtilizatori,
            this.btnModificareUtilzatori});
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
            // btnAdaugareUtilizatori
            // 
            this.btnAdaugareUtilizatori.Name = "btnAdaugareUtilizatori";
            this.btnAdaugareUtilizatori.Size = new System.Drawing.Size(122, 20);
            this.btnAdaugareUtilizatori.Text = "&Adaugare utilizatori";
            this.btnAdaugareUtilizatori.Click += new System.EventHandler(this.btnAdaugareUtilizatori_Click);
            // 
            // btnModificareUtilzatori
            // 
            this.btnModificareUtilzatori.Name = "btnModificareUtilzatori";
            this.btnModificareUtilzatori.Size = new System.Drawing.Size(128, 20);
            this.btnModificareUtilzatori.Text = "&Modificare utilizatori";
            this.btnModificareUtilzatori.Click += new System.EventHandler(this.btnModificareUtilzatori_Click);
            // 
            // dgvUtilizatori
            // 
            this.dgvUtilizatori.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvUtilizatori.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUtilizatori.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvUtilizatori.Location = new System.Drawing.Point(0, 24);
            this.dgvUtilizatori.Name = "dgvUtilizatori";
            this.dgvUtilizatori.ReadOnly = true;
            this.dgvUtilizatori.RowHeadersVisible = false;
            this.dgvUtilizatori.Size = new System.Drawing.Size(634, 417);
            this.dgvUtilizatori.TabIndex = 1;
            // 
            // frmVizualizareUtilizatori
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.dgvUtilizatori);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmVizualizareUtilizatori";
            this.Text = "Vizualizare utilizatori";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUtilizatori)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.DataGridView dgvUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnModificareUtilzatori;
    }
}