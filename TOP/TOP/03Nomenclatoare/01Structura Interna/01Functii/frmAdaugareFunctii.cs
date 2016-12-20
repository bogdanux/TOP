using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmAdaugareFunctii : Form
    {
        public frmAdaugareFunctii()
        {
            InitializeComponent();

            txtDenumireFunctie.Clear();
            txtDenumireFunctie.Focus();

            func.verifIdFunctie();

            if (func.bev == true)
            {
                MessageBox.Show(func.scv);
            }
            else
            {
                txtCodFunctie.Text = func.codfunctie.ToString();
            }

            incarcareDGV();
        }

        ConexiuniDB con = new ConexiuniDB();

        Functie func = new Functie();

        private void tsIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDenumireFunctie_TextChanged(object sender, EventArgs e)
        {
            if (txtDenumireFunctie.Text != string.Empty)
            {
                cmbNivel.Enabled = true;
                chkActiv.Enabled = true;
                chkActiv.Checked = true;
                btnAdaugare.Enabled = true;
            }
            else
            {
                cmbNivel.Enabled = false;
                chkActiv.Checked = false;
                chkActiv.Enabled = false;
                btnAdaugare.Enabled = false;
            }
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
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

            func.adaugareFunctie();

            if (func.bea == true)
            {
                MessageBox.Show(func.sca);
            }
            else
            {
                MessageBox.Show("Functia a fost adaugata cu succes.");
                cmbNivel.SelectedIndex = -1;
                txtDenumireFunctie.Clear();
                txtDenumireFunctie.Focus();

                incarcareDGV();

                func.verifIdFunctie();

                if (func.bev == true)
                {
                    MessageBox.Show(func.scv);
                }
                else
                {
                    txtCodFunctie.Text = func.codfunctie.ToString();
                }
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

        private void btnModificareFunctii_Click(object sender, EventArgs e)
        {
            Form form = new frmModificareFunctii();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmModificareFunctii))
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
