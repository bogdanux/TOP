﻿using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmVizualizareProduse : Form
    {
        public frmVizualizareProduse()
        {
            InitializeComponent();

            incarcareDGV();
        }

        ConexiuniDB con = new ConexiuniDB();

        private void incarcareDGV()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codProdus as \"Cod\", denumireProdus as \"Denumire\", dataAdaugareProd AS \"Data adaugare\", descriereProdus AS \"Descriere\", produsActiv as \"Produs activ?\" FROM ProduseSoftware order by codProdus asc";

                    try
                    {
                        conexiune.Open();
                        OdbcDataAdapter da = new OdbcDataAdapter();
                        da.SelectCommand = comanda;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;

                        dgvProduse.DataSource = bs;

                        da.Update(dt);
                    }
                    catch (Exception exceptie)
                    {
                        MessageBox.Show(exceptie.Message);
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        private void btnAdaugareProduse_Click(object sender, EventArgs e)
        {
            Form form = new frmAdaugareProduse();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmAdaugareProduse))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }

        private void btnModificareProduse_Click(object sender, EventArgs e)
        {
            Form form = new frmModificareProduse();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmModificareProduse))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
