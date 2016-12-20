using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmModificareProduse : Form
    {
        public frmModificareProduse()
        {
            InitializeComponent();

            incarcareDGV();
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

        private void txtCod_TextChanged(object sender, EventArgs e)
        {
            if (txtCod.Text != string.Empty)
            {
                btnOK.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
            }
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

                btnModifica.Enabled = false;
            }
        }

        private void txtDescriere_TextChanged(object sender, EventArgs e)
        {
            if (txtDescriere.Text != string.Empty)
            {
                chkActiv.Enabled = true;
                chkActiv.Checked = true;
                btnModifica.Enabled = true;
            }
            else
            {
                chkActiv.Enabled = false;
                chkActiv.Checked = false;
                btnModifica.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            prod.codprodus = Int32.Parse(txtCod.Text);

            prod.verificareProdModificare();

            if (prod.bevm == false)
            {
                txtCod.Enabled = false;

                btnOK.Enabled = false;

                txtDenumire.Enabled = true;
                txtDenumire.Text = prod.denumireprod;

                dtDataAdaugare.Enabled = true;
                dtDataAdaugare.Value = prod.dataadaugare;

                txtDescriere.Enabled = true;
                txtDescriere.Text = prod.descriereprodus;

                chkActiv.Enabled = true;
                
                if (Int32.Parse(prod.activareprodus) == 1)
                {
                    chkActiv.Checked = true;
                }
                else
                {
                    chkActiv.Checked = false;
                }

                btnModifica.Enabled = true;
            }
            else
            {
                MessageBox.Show(prod.scvm);
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            prod.codprodus = Int32.Parse(txtCod.Text);
            prod.denumireprod = txtDenumire.Text.ToString();
            prod.dataadaugare = dtDataAdaugare.Value;
            prod.descriereprodus = txtDescriere.Text.ToString();

            if (chkActiv.Checked)
            {
                prod.activareprodus = "true";
            }
            else
            {
                prod.activareprodus = "false";
            }

            prod.modificareProdus();

            if (prod.bem == false)
            {
                MessageBox.Show("Produsul a fost modificat cu succes.");

                incarcareDGV();

                btnModifica.Enabled = false;

                chkActiv.Checked = false;
                chkActiv.Enabled = false;

                txtDescriere.Clear();
                txtDescriere.Enabled = false;

                dtDataAdaugare.Enabled = false;

                txtDenumire.Clear();
                txtDenumire.Enabled = false;

                btnOK.Enabled = false;

                txtCod.Clear();
                txtCod.Enabled = true;
                txtCod.Focus();
            }
            else
            {
                MessageBox.Show(prod.scm);
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

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
