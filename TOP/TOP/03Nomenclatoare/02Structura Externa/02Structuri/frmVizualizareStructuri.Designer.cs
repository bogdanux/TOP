namespace TOP
{
    partial class frmVizualizareStructuri
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
            this.dgvStructuri = new System.Windows.Forms.DataGridView();
            this.msMenu.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructuri)).BeginInit();
            this.SuspendLayout();
            // 
            // msMenu
            // 
            this.msMenu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFisier});
            this.msMenu.Location = new System.Drawing.Point(0, 0);
            this.msMenu.Name = "msMenu";
            this.msMenu.Size = new System.Drawing.Size(634, 24);
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
            // dgvStructuri
            // 
            this.dgvStructuri.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvStructuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvStructuri.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvStructuri.Location = new System.Drawing.Point(0, 24);
            this.dgvStructuri.Name = "dgvStructuri";
            this.dgvStructuri.ReadOnly = true;
            this.dgvStructuri.RowHeadersVisible = false;
            this.dgvStructuri.Size = new System.Drawing.Size(634, 417);
            this.dgvStructuri.TabIndex = 1;
            // 
            // frmVizualizareStructuri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 441);
            this.Controls.Add(this.dgvStructuri);
            this.Controls.Add(this.msMenu);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.msMenu;
            this.Name = "frmVizualizareStructuri";
            this.Text = "Vizualizare structuri";
            this.msMenu.ResumeLayout(false);
            this.msMenu.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvStructuri)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMenu;
        private System.Windows.Forms.ToolStripMenuItem btnFisier;
        private System.Windows.Forms.ToolStripMenuItem btnIesire;
        private System.Windows.Forms.DataGridView dgvStructuri;
    }
}