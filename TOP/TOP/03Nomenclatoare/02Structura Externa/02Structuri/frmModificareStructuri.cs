using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmModificareStructuri : Form
    {
        public frmModificareStructuri()
        {
            InitializeComponent();

            incarcareDGV();
        }

        Structura struc = new Structura();

        ConexiuniDB con = new ConexiuniDB();

        private void incarcareDGV()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codStructura as \"Cod\", denumireStructura as \"Denumire\", dataAdaugareStruct AS \"Data adaugare\" FROM Structuri order by codStructura asc";

                    try
                    {
                        conexiune.Open();
                        OdbcDataAdapter da = new OdbcDataAdapter();
                        da.SelectCommand = comanda;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;

                        dgvStructuri.DataSource = bs;

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

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            struc.codstructura = Int32.Parse(txtCod.Text);

            struc.verificareStrucModificare();

            if (struc.bevm == false)
            {
                txtCod.Enabled = false;

                btnOK.Enabled = false;

                txtDenumire.Enabled = true;
                txtDenumire.Text = struc.denumirestructura;

                dtDataAdaugare.Enabled = true;
                dtDataAdaugare.Value = struc.dataadaugarestruct;

                btnModifica.Enabled = true;
            }
            else
            {
                MessageBox.Show(struc.scvm);
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
                btnModifica.Enabled = true;
            }
            else
            {
                dtDataAdaugare.Enabled = false;
                btnModifica.Enabled = false;
            }
        }

        private void btnModifica_Click(object sender, EventArgs e)
        {
            struc.codstructura = Int32.Parse(txtCod.Text);
            struc.denumirestructura = txtDenumire.Text.ToString();
            struc.dataadaugarestruct = dtDataAdaugare.Value;

            struc.modificareStructura();

            if (struc.bem == false)
            {
                MessageBox.Show("Structura a fost modificata cu succes.");

                incarcareDGV();

                btnModifica.Enabled = false;

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
                MessageBox.Show(struc.scm);
            }
        }

        private void btnAdaugareStructuri_Click(object sender, EventArgs e)
        {
            Form form = new frmAdaugareStructuri();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmAdaugareStructuri))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }

        private void btnVizualizareStructuri_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareStructuri();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareStructuri))
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
