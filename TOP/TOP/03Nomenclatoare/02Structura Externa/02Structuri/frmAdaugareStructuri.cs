using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmAdaugareStructuri : Form
    {
        public frmAdaugareStructuri()
        {
            InitializeComponent();

            incarcareDGV();

            verificareStructuriBD();
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

        private void verificareStructuriBD()
        {
            struc.verifCodStruct();
            if (struc.bev == false)
            {
                txtCod.Text = struc.codstructura.ToString();
            }
            else
            {
                MessageBox.Show(struc.scv);
            }
        }

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtDenumire_TextChanged(object sender, EventArgs e)
        {
            if (txtDenumire.Text != string.Empty)
            {
                dtDataAdaugare.Enabled = true;
                btnAdauga.Enabled = true;
            }
            else
            {
                dtDataAdaugare.Enabled = false;
                btnAdauga.Enabled = false;
            }
        }

        private void btnAdauga_Click(object sender, EventArgs e)
        {
            struc.codstructura = Int32.Parse(txtCod.Text);
            struc.denumirestructura = txtDenumire.Text.ToString();
            struc.dataadaugarestruct = dtDataAdaugare.Value;

            struc.adaugareStructura();

            if (struc.bea == false)
            {
                MessageBox.Show("Structura a fost adaugata cu succes.");

                btnAdauga.Enabled = false;

                dtDataAdaugare.Enabled = false;

                txtDenumire.Clear();
                txtDenumire.Focus();

                verificareStructuriBD();

                incarcareDGV();
            }
            else
            {
                MessageBox.Show(struc.sca);
            }
        }

        private void btnModificareStructuri_Click(object sender, EventArgs e)
        {
            Form form = new frmModificareStructuri();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmModificareStructuri))
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
