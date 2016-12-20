namespace TOP
{
    partial class frmAdaugareNiveluri
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fisierToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.iesireToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.panouGeneral = new System.Windows.Forms.Panel();
            this.txtNrNiveluri = new System.Windows.Forms.TextBox();
            this.btnNOK = new System.Windows.Forms.Button();
            this.btnOK = new System.Windows.Forms.Button();
            this.panouControale = new System.Windows.Forms.Panel();
            this.lblNrNiveluri = new System.Windows.Forms.Label();
            this.btnAdauga = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            this.panouGeneral.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fisierToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(675, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fisierToolStripMenuItem
            // 
            this.fisierToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.iesireToolStripMenuItem});
            this.fisierToolStripMenuItem.Name = "fisierToolStripMenuItem";
            this.fisierToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.fisierToolStripMenuItem.Text = "&Fisier";
            // 
            // iesireToolStripMenuItem
            // 
            this.iesireToolStripMenuItem.Name = "iesireToolStripMenuItem";
            this.iesireToolStripMenuItem.Size = new System.Drawing.Size(101, 22);
            this.iesireToolStripMenuItem.Text = "I&esire";
            this.iesireToolStripMenuItem.Click += new System.EventHandler(this.iesireToolStripMenuItem_Click);
            // 
            // panouGeneral
            // 
            this.panouGeneral.Controls.Add(this.txtNrNiveluri);
            this.panouGeneral.Controls.Add(this.btnAdauga);
            this.panouGeneral.Controls.Add(this.btnNOK);
            this.panouGeneral.Controls.Add(this.btnOK);
            this.panouGeneral.Controls.Add(this.panouControale);
            this.panouGeneral.Controls.Add(this.lblNrNiveluri);
            this.panouGeneral.Location = new System.Drawing.Point(13, 28);
            this.panouGeneral.Name = "panouGeneral";
            this.panouGeneral.Size = new System.Drawing.Size(650, 498);
            this.panouGeneral.TabIndex = 1;
            // 
            // txtNrNiveluri
            // 
            this.txtNrNiveluri.Location = new System.Drawing.Point(108, 15);
            this.txtNrNiveluri.Name = "txtNrNiveluri";
            this.txtNrNiveluri.Size = new System.Drawing.Size(100, 20);
            this.txtNrNiveluri.TabIndex = 6;
            this.txtNrNiveluri.TextChanged += new System.EventHandler(this.txtNrNiveluri_TextChanged);
            // 
            // btnNOK
            // 
            this.btnNOK.Enabled = false;
            this.btnNOK.Location = new System.Drawing.Point(271, 14);
            this.btnNOK.Name = "btnNOK";
            this.btnNOK.Size = new System.Drawing.Size(97, 22);
            this.btnNOK.TabIndex = 5;
            this.btnNOK.Text = "&Gresit?";
            this.btnNOK.UseVisualStyleBackColor = true;
            this.btnNOK.Visible = false;
            this.btnNOK.Click += new System.EventHandler(this.btnNOK_Click);
            // 
            // btnOK
            // 
            this.btnOK.Enabled = false;
            this.btnOK.Location = new System.Drawing.Point(214, 14);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(51, 22);
            this.btnOK.TabIndex = 5;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // panouControale
            // 
            this.panouControale.Location = new System.Drawing.Point(0, 42);
            this.panouControale.Name = "panouControale";
            this.panouControale.Size = new System.Drawing.Size(650, 386);
            this.panouControale.TabIndex = 4;
            // 
            // lblNrNiveluri
            // 
            this.lblNrNiveluri.AutoSize = true;
            this.lblNrNiveluri.Location = new System.Drawing.Point(13, 18);
            this.lblNrNiveluri.Name = "lblNrNiveluri";
            this.lblNrNiveluri.Size = new System.Drawing.Size(89, 13);
            this.lblNrNiveluri.TabIndex = 0;
            this.lblNrNiveluri.Text = "Numar de niveluri";
            // 
            // btnAdauga
            // 
            this.btnAdauga.Location = new System.Drawing.Point(546, 434);
            this.btnAdauga.Name = "btnAdauga";
            this.btnAdauga.Size = new System.Drawing.Size(97, 22);
            this.btnAdauga.TabIndex = 5;
            this.btnAdauga.Text = "&Adauga";
            this.btnAdauga.UseVisualStyleBackColor = true;
            this.btnAdauga.Visible = false;
            this.btnAdauga.Click += new System.EventHandler(this.btnNOK_Click);
            // 
            // frmAdaugareNiveluri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(675, 538);
            this.Controls.Add(this.panouGeneral);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmAdaugareNiveluri";
            this.Text = "Adaugare niveluri";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panouGeneral.ResumeLayout(false);
            this.panouGeneral.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fisierToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem iesireToolStripMenuItem;
        private System.Windows.Forms.Panel panouGeneral;
        private System.Windows.Forms.Label lblNrNiveluri;
        private System.Windows.Forms.Panel panouControale;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.TextBox txtNrNiveluri;
        private System.Windows.Forms.Button btnNOK;
        private System.Windows.Forms.Button btnAdauga;
    }
}