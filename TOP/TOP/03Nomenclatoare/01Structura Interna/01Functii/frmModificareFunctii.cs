using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmModificareFunctii : Form
    {
        public frmModificareFunctii()
        {
            InitializeComponent();

            incarcareDGV();
        }

        Functie func = new Functie();

        ConexiuniDB con = new ConexiuniDB();

        private void tsIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtCodFunctie_TextChanged(object sender, EventArgs e)
        {
            if (txtCodFunctie.Text != string.Empty)
            {
                btnGO.Enabled = true;
            }
            else
            {
                btnGO.Enabled = false;
            }
        }

        private void txtDenumireFunctie_TextChanged(object sender, EventArgs e)
        {
            if (txtDenumireFunctie.Text != string.Empty)
            {
                cmbNivel.Enabled = true;
                chkActiv.Enabled = true;
                chkActiv.Checked = true;
                btnModificare.Enabled = true;
            }
            else
            {
                btnModificare.Enabled = false;
                chkActiv.Checked = false;
                chkActiv.Enabled = false;
                cmbNivel.Enabled = false;
            }
        }

        private void incarcareDGV()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codFunctie as \"Cod\", denumireFunctie as \"Denumire\", nivelFunctie AS \"Nivel\", activareFunctie AS \"Functie activa?\" FROM functii order by codFunctie asc";

                    try
                    {
                        conexiune.Open();
                        OdbcDataAdapter da = new OdbcDataAdapter();
                        da.SelectCommand = comanda;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;

                        dgvFunctii.DataSource = bs;

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

        private void tsResetareCampuri_Click(object sender, EventArgs e)
        {
            chkActiv.Checked = false;
            chkActiv.Enabled = false;

            cmbNivel.SelectedIndex = -1;
            cmbNivel.Enabled = false;

            txtDenumireFunctie.Clear();
            txtDenumireFunctie.Enabled = false;

            btnGO.Enabled = false;

            txtCodFunctie.Clear();
            txtCodFunctie.Enabled = true;
        }

        private void btnGO_Click(object sender, EventArgs e)
        {
            func.codfunctie = Int32.Parse(txtCodFunctie.Text);

            func.verifIdFunctieModificare();

            if (func.bevm == false)
            {
                txtCodFunctie.Enabled = false;

                btnGO.Enabled = false;

                txtDenumireFunctie.Clear();
                txtDenumireFunctie.Enabled = true;
                txtDenumireFunctie.Focus();

                txtDenumireFunctie.Text = func.denumirefunctie;
                cmbNivel.SelectedIndex = func.nivelfunctie;

                if (func.activarefunctie == "true")
                {
                    chkActiv.Checked = true;
                }
                else
                {
                    chkActiv.Checked = false;
                }
                btnModificare.Enabled = true;
            }
            else
            {
                txtDenumireFunctie.Enabled = false;
                MessageBox.Show(func.scvm);
            }
        }

        private void btnModificare_Click(object sender, EventArgs e)
        {
            func.codfunctie = Int32.Parse(txtCodFunctie.Text);
            func.denumirefunctie = txtDenumireFunctie.Text;
            func.nivelfunctie = cmbNivel.SelectedIndex;
            if (chkActiv.Checked)
            {
                func.activarefunctie = "Y";
            }
            else
            {
                func.activarefunctie = "N";
            }

            func.modificareFunctie();

            if (func.bem == false)
            {
                MessageBox.Show("Functia a fost modificata cu succes.");

                incarcareDGV();

                txtCodFunctie.Enabled = true;
                txtCodFunctie.Clear();
                txtCodFunctie.Focus();

                txtDenumireFunctie.Clear();
                txtDenumireFunctie.Enabled = false;

                cmbNivel.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(func.scm);
            }
        }

        private void btnAdaugareFunctii_Click(object sender, EventArgs e)
        {
            Form form = new frmAdaugareFunctii();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmAdaugareFunctii))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }

        private void btnVizualizareFunctii_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareFunctii();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareFunctii))
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
