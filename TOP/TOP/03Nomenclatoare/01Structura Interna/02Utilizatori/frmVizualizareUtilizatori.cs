using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmVizualizareUtilizatori : Form
    {
        public frmVizualizareUtilizatori()
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
                    comanda.CommandText = "select idUser as \"Cod\", numeUser as \"Nume\", denumireFunctie AS \"Functie\", activareUser as \"Utilizator activ?\" FROM utilizatori inner join Functii on Utilizatori.functieUser = Functii.codFunctie order by idUser asc";

                    try
                    {
                        conexiune.Open();
                        OdbcDataAdapter da = new OdbcDataAdapter();
                        da.SelectCommand = comanda;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;

                        dgvUtilizatori.DataSource = bs;

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

        private void btnAdaugareUtilizatori_Click(object sender, EventArgs e)
        {
            Form form = new frmAdaugareUtilizatori();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmAdaugareUtilizatori))
                {
                    forms.WindowState = FormWindowState.Normal;
                    forms.Activate();
                    return;
                }
            }

            form.Show();

            Close();
        }

        private void btnModificareUtilzatori_Click(object sender, EventArgs e)
        {
            Form form = new frmModificareUtilizatori();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmModificareUtilizatori))
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