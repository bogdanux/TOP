using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmAdaugareProduse : Form
    {
        public frmAdaugareProduse()
        {
            InitializeComponent();

            incarcareDGV();

            verificareProduseBD();
        }

        Produs prod = new Produs();

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

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDenumire_TextChanged(object sender, EventArgs e)
        {
            if (txtDenumire.Text != string.Empty)
            {
                dtDataAdaugare.Enabled = true;

                txtDescriere.Enabled = true;
                txtDescriere.Clear();
            }
            else
            {
                dtDataAdaugare.Enabled = false;

                txtDescriere.Enabled = false;
                txtDescriere.Clear();

                chkActiv.Enabled = false;
                chkActiv.Checked = false;

                btnAdauga.Enabled = false;
            }
        }

        private void txtDescriere_TextChanged(object sender, EventArgs e)
        {
            if (txtDescriere.Text != string.Empty)
            {
                chkActiv.Enabled = true;
                chkActiv.Checked = true;
                btnAdauga.Enabled = true;
            }
            else
            {
                chkActiv.Enabled = false;
                chkActiv.Checked = false;
                btnAdauga.Enabled = false;
            }
        }

        private void verificareProduseBD()
        {
            prod.verifCodProdus();
            if (prod.bev == false)
            {
                txtCod.Text = prod.codprodus.ToString();
            }
            else
            {
                MessageBox.Show(prod.scv);
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            prod.codprodus = Int32.Parse(txtCod.Text);
            prod.denumireprod = txtDenumire.Text.ToString();
            prod.dataadaugare = dtDataAdaugare.Value;
            prod.descriereprodus = txtDescriere.Text.ToString();
            
            if (chkActiv.Checked)
            {
                prod.activareprodus = "Y";
            }
            else
            {
                prod.activareprodus = "N";
            }

            prod.adaugareProdus();

            if (prod.bea == false)
            {
                MessageBox.Show("Produsul a fost adaugat cu succes.");

                btnAdauga.Enabled = false;

                chkActiv.Checked = false;
                chkActiv.Enabled = false;

                txtDescriere.Clear();
                txtDescriere.Enabled = false;

                dtDataAdaugare.Enabled = false;

                txtDenumire.Clear();

                verificareProduseBD();

                incarcareDGV();

                txtDenumire.Focus();
            }
            else
            {
                MessageBox.Show(prod.sca);
            }
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

        private void btnVizualizareProduse_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareProduse();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareProduse))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }
    }
}
