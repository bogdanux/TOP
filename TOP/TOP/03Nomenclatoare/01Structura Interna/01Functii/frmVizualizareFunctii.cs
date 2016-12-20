using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmVizualizareFunctii : Form
    {
        public frmVizualizareFunctii()
        {
            InitializeComponent();

            incarcareDGV();
        }

        ConexiuniDB con = new ConexiuniDB();

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
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
    }
}
