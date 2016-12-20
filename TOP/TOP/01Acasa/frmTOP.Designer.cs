namespace TOP
{
    partial class frmTOP
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
            this.msMeniuTOP = new System.Windows.Forms.MenuStrip();
            this.tsmiFisier = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiIesire = new System.Windows.Forms.ToolStripMenuItem();
            this.nomenclatoareToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnOrgInt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareFunctiiToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdaugareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareFunctii = new System.Windows.Forms.ToolStripMenuItem();
            this.btnUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareUtilizatoriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdaugareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareUtilizatori = new System.Windows.Forms.ToolStripMenuItem();
            this.btnAlocariPeProiecte = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.btnOrgExt = new System.Windows.Forms.ToolStripMenuItem();
            this.btnProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnVizualizareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdaugareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareProduse = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStructuri = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareStructuriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdaugareStructuri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareStructuri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
            this.alocareStructuraProdusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnNiveluri = new System.Windows.Forms.ToolStripMenuItem();
            this.vizualizareNiveluriToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.btnAdaugareNiveluri = new System.Windows.Forms.ToolStripMenuItem();
            this.btnModificareNiveluri = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.msMeniuTOP.SuspendLayout();
            this.SuspendLayout();
            // 
            // msMeniuTOP
            // 
            this.msMeniuTOP.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiFisier,
            this.nomenclatoareToolStripMenuItem});
            this.msMeniuTOP.Location = new System.Drawing.Point(0, 0);
            this.msMeniuTOP.Name = "msMeniuTOP";
            this.msMeniuTOP.Size = new System.Drawing.Size(884, 24);
            this.msMeniuTOP.TabIndex = 0;
            this.msMeniuTOP.Text = "menuStrip1";
            // 
            // tsmiFisier
            // 
            this.tsmiFisier.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiIesire});
            this.tsmiFisier.Name = "tsmiFisier";
            this.tsmiFisier.Size = new System.Drawing.Size(46, 20);
            this.tsmiFisier.Text = "&Fisier";
            // 
            // tsmiIesire
            // 
            this.tsmiIesire.Name = "tsmiIesire";
            this.tsmiIesire.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Q)));
            this.tsmiIesire.Size = new System.Drawing.Size(144, 22);
            this.tsmiIesire.Text = "Iesire";
            this.tsmiIesire.Click += new System.EventHandler(this.tsmiIesire_Click);
            // 
            // nomenclatoareToolStripMenuItem
            // 
            this.nomenclatoareToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnOrgInt,
            this.toolStripSeparator1,
            this.btnOrgExt});
            this.nomenclatoareToolStripMenuItem.Name = "nomenclatoareToolStripMenuItem";
            this.nomenclatoareToolStripMenuItem.Size = new System.Drawing.Size(101, 20);
            this.nomenclatoareToolStripMenuItem.Text = "&Nomenclatoare";
            // 
            // btnOrgInt
            // 
            this.btnOrgInt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnFunctii,
            this.btnUtilizatori,
            this.btnAlocariPeProiecte});
            this.btnOrgInt.Name = "btnOrgInt";
            this.btnOrgInt.Size = new System.Drawing.Size(172, 22);
            this.btnOrgInt.Text = "Organizare &interna";
            // 
            // btnFunctii
            // 
            this.btnFunctii.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareFunctiiToolStripMenuItem,
            this.toolStripSeparator7,
            this.btnAdaugareFunctii,
            this.btnModificareFunctii});
            this.btnFunctii.Name = "btnFunctii";
            this.btnFunctii.Size = new System.Drawing.Size(165, 22);
            this.btnFunctii.Text = "Fun&ctii";
            // 
            // vizualizareFunctiiToolStripMenuItem
            // 
            this.vizualizareFunctiiToolStripMenuItem.Name = "vizualizareFunctiiToolStripMenuItem";
            this.vizualizareFunctiiToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.vizualizareFunctiiToolStripMenuItem.Text = "&Vizualizare functii";
            this.vizualizareFunctiiToolStripMenuItem.Click += new System.EventHandler(this.vizualizareFunctiiToolStripMenuItem_Click);
            // 
            // toolStripSeparator7
            // 
            this.toolStripSeparator7.Name = "toolStripSeparator7";
            this.toolStripSeparator7.Size = new System.Drawing.Size(165, 6);
            // 
            // btnAdaugareFunctii
            // 
            this.btnAdaugareFunctii.Name = "btnAdaugareFunctii";
            this.btnAdaugareFunctii.Size = new System.Drawing.Size(168, 22);
            this.btnAdaugareFunctii.Text = "&Adaugare functii";
            this.btnAdaugareFunctii.Click += new System.EventHandler(this.btnAdaugareFunctii_Click);
            // 
            // btnModificareFunctii
            // 
            this.btnModificareFunctii.Name = "btnModificareFunctii";
            this.btnModificareFunctii.Size = new System.Drawing.Size(168, 22);
            this.btnModificareFunctii.Text = "Mo&dificare functii";
            this.btnModificareFunctii.Click += new System.EventHandler(this.btnModificareFunctii_Click);
            // 
            // btnUtilizatori
            // 
            this.btnUtilizatori.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareUtilizatoriToolStripMenuItem,
            this.toolStripSeparator6,
            this.btnAdaugareUtilizatori,
            this.btnModificareUtilizatori});
            this.btnUtilizatori.Name = "btnUtilizatori";
            this.btnUtilizatori.Size = new System.Drawing.Size(165, 22);
            this.btnUtilizatori.Text = "Utilizatori";
            // 
            // vizualizareUtilizatoriToolStripMenuItem
            // 
            this.vizualizareUtilizatoriToolStripMenuItem.Name = "vizualizareUtilizatoriToolStripMenuItem";
            this.vizualizareUtilizatoriToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.vizualizareUtilizatoriToolStripMenuItem.Text = "&Vizualizare utilizatori";
            this.vizualizareUtilizatoriToolStripMenuItem.Click += new System.EventHandler(this.vizualizareUtilizatoriToolStripMenuItem_Click);
            // 
            // toolStripSeparator6
            // 
            this.toolStripSeparator6.Name = "toolStripSeparator6";
            this.toolStripSeparator6.Size = new System.Drawing.Size(180, 6);
            // 
            // btnAdaugareUtilizatori
            // 
            this.btnAdaugareUtilizatori.Name = "btnAdaugareUtilizatori";
            this.btnAdaugareUtilizatori.Size = new System.Drawing.Size(183, 22);
            this.btnAdaugareUtilizatori.Text = "&Adaugare utilizatori";
            this.btnAdaugareUtilizatori.Click += new System.EventHandler(this.btnAdaugareUtilizatori_Click);
            // 
            // btnModificareUtilizatori
            // 
            this.btnModificareUtilizatori.Name = "btnModificareUtilizatori";
            this.btnModificareUtilizatori.Size = new System.Drawing.Size(183, 22);
            this.btnModificareUtilizatori.Text = "Mo&dificare utilizatori";
            this.btnModificareUtilizatori.Click += new System.EventHandler(this.btnModificareUtilizatori_Click);
            // 
            // btnAlocariPeProiecte
            // 
            this.btnAlocariPeProiecte.Name = "btnAlocariPeProiecte";
            this.btnAlocariPeProiecte.Size = new System.Drawing.Size(165, 22);
            this.btnAlocariPeProiecte.Text = "Alocari / proiecte";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(169, 6);
            // 
            // btnOrgExt
            // 
            this.btnOrgExt.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnProduse,
            this.btnStructuri,
            this.btnNiveluri,
            this.toolStripSeparator2});
            this.btnOrgExt.Name = "btnOrgExt";
            this.btnOrgExt.Size = new System.Drawing.Size(172, 22);
            this.btnOrgExt.Text = "&Organizare &externa";
            // 
            // btnProduse
            // 
            this.btnProduse.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnVizualizareProduse,
            this.toolStripSeparator3,
            this.btnAdaugareProduse,
            this.btnModificareProduse});
            this.btnProduse.Name = "btnProduse";
            this.btnProduse.Size = new System.Drawing.Size(152, 22);
            this.btnProduse.Text = "&Produse";
            // 
            // btnVizualizareProduse
            // 
            this.btnVizualizareProduse.Name = "btnVizualizareProduse";
            this.btnVizualizareProduse.Size = new System.Drawing.Size(177, 22);
            this.btnVizualizareProduse.Text = "&Vizualizare produse";
            this.btnVizualizareProduse.Click += new System.EventHandler(this.btnVizualizareProduse_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(174, 6);
            // 
            // btnAdaugareProduse
            // 
            this.btnAdaugareProduse.Name = "btnAdaugareProduse";
            this.btnAdaugareProduse.Size = new System.Drawing.Size(177, 22);
            this.btnAdaugareProduse.Text = "&Adaugare produse";
            this.btnAdaugareProduse.Click += new System.EventHandler(this.btnAdaugareProduse_Click);
            // 
            // btnModificareProduse
            // 
            this.btnModificareProduse.Name = "btnModificareProduse";
            this.btnModificareProduse.Size = new System.Drawing.Size(177, 22);
            this.btnModificareProduse.Text = "Mo&dificare produse";
            this.btnModificareProduse.Click += new System.EventHandler(this.btnModificareProduse_Click);
            // 
            // btnStructuri
            // 
            this.btnStructuri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareStructuriToolStripMenuItem,
            this.toolStripSeparator4,
            this.btnAdaugareStructuri,
            this.btnModificareStructuri,
            this.toolStripSeparator8,
            this.alocareStructuraProdusToolStripMenuItem});
            this.btnStructuri.Name = "btnStructuri";
            this.btnStructuri.Size = new System.Drawing.Size(152, 22);
            this.btnStructuri.Text = "S&tructuri";
            // 
            // vizualizareStructuriToolStripMenuItem
            // 
            this.vizualizareStructuriToolStripMenuItem.Name = "vizualizareStructuriToolStripMenuItem";
            this.vizualizareStructuriToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.vizualizareStructuriToolStripMenuItem.Text = "&Vizualizare structuri";
            this.vizualizareStructuriToolStripMenuItem.Click += new System.EventHandler(this.vizualizareStructuriToolStripMenuItem_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(209, 6);
            // 
            // btnAdaugareStructuri
            // 
            this.btnAdaugareStructuri.Name = "btnAdaugareStructuri";
            this.btnAdaugareStructuri.Size = new System.Drawing.Size(212, 22);
            this.btnAdaugareStructuri.Text = "&Adaugare structura";
            this.btnAdaugareStructuri.Click += new System.EventHandler(this.btnAdaugareStructuri_Click);
            // 
            // btnModificareStructuri
            // 
            this.btnModificareStructuri.Name = "btnModificareStructuri";
            this.btnModificareStructuri.Size = new System.Drawing.Size(212, 22);
            this.btnModificareStructuri.Text = "Mo&dificare structura";
            this.btnModificareStructuri.Click += new System.EventHandler(this.btnModificareStructuri_Click);
            // 
            // toolStripSeparator8
            // 
            this.toolStripSeparator8.Name = "toolStripSeparator8";
            this.toolStripSeparator8.Size = new System.Drawing.Size(209, 6);
            // 
            // alocareStructuraProdusToolStripMenuItem
            // 
            this.alocareStructuraProdusToolStripMenuItem.Name = "alocareStructuraProdusToolStripMenuItem";
            this.alocareStructuraProdusToolStripMenuItem.Size = new System.Drawing.Size(212, 22);
            this.alocareStructuraProdusToolStripMenuItem.Text = "Alocare &structura / produs";
            // 
            // btnNiveluri
            // 
            this.btnNiveluri.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.vizualizareNiveluriToolStripMenuItem,
            this.toolStripSeparator5,
            this.btnAdaugareNiveluri,
            this.btnModificareNiveluri});
            this.btnNiveluri.Name = "btnNiveluri";
            this.btnNiveluri.Size = new System.Drawing.Size(152, 22);
            this.btnNiveluri.Text = "&Niveluri";
            // 
            // vizualizareNiveluriToolStripMenuItem
            // 
            this.vizualizareNiveluriToolStripMenuItem.Name = "vizualizareNiveluriToolStripMenuItem";
            this.vizualizareNiveluriToolStripMenuItem.Size = new System.Drawing.Size(173, 22);
            this.vizualizareNiveluriToolStripMenuItem.Text = "&Vizualizare niveluri";
            this.vizualizareNiveluriToolStripMenuItem.Click += new System.EventHandler(this.vizualizareNiveluriToolStripMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(170, 6);
            // 
            // btnAdaugareNiveluri
            // 
            this.btnAdaugareNiveluri.Name = "btnAdaugareNiveluri";
            this.btnAdaugareNiveluri.Size = new System.Drawing.Size(173, 22);
            this.btnAdaugareNiveluri.Text = "&Adaugare niveluri";
            this.btnAdaugareNiveluri.Click += new System.EventHandler(this.btnAdaugareNiveluri_Click);
            // 
            // btnModificareNiveluri
            // 
            this.btnModificareNiveluri.Name = "btnModificareNiveluri";
            this.btnModificareNiveluri.Size = new System.Drawing.Size(173, 22);
            this.btnModificareNiveluri.Text = "Mo&dificare niveluri";
            this.btnModificareNiveluri.Click += new System.EventHandler(this.btnModificareNiveluri_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(149, 6);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 539);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(884, 22);
            this.statusStrip1.TabIndex = 2;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // frmTOP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(884, 561);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.msMeniuTOP);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.msMeniuTOP;
            this.Name = "frmTOP";
            this.Text = "Test organizer platform";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.msMeniuTOP.ResumeLayout(false);
            this.msMeniuTOP.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msMeniuTOP;
        private System.Windows.Forms.ToolStripMenuItem tsmiFisier;
        private System.Windows.Forms.ToolStripMenuItem tsmiIesire;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripMenuItem nomenclatoareToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem btnOrgExt;
        private System.Windows.Forms.ToolStripMenuItem btnOrgInt;
        private System.Windows.Forms.ToolStripMenuItem btnProduse;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareProduse;
        private System.Windows.Forms.ToolStripMenuItem btnModificareProduse;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripMenuItem btnStructuri;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareStructuri;
        private System.Windows.Forms.ToolStripMenuItem btnModificareStructuri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.ToolStripMenuItem btnNiveluri;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareNiveluri;
        private System.Windows.Forms.ToolStripMenuItem btnModificareNiveluri;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem btnFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnModificareFunctii;
        private System.Windows.Forms.ToolStripMenuItem btnUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnAdaugareUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnModificareUtilizatori;
        private System.Windows.Forms.ToolStripMenuItem btnAlocariPeProiecte;
        private System.Windows.Forms.ToolStripMenuItem vizualizareFunctiiToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator7;
        private System.Windows.Forms.ToolStripMenuItem vizualizareUtilizatoriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator6;
        private System.Windows.Forms.ToolStripMenuItem btnVizualizareProduse;
        private System.Windows.Forms.ToolStripMenuItem vizualizareStructuriToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem vizualizareNiveluriToolStripMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator8;
        private System.Windows.Forms.ToolStripMenuItem alocareStructuraProdusToolStripMenuItem;
    }
}