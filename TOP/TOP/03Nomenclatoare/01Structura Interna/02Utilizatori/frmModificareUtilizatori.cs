using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmModificareUtilizatori : Form
    {
        public frmModificareUtilizatori()
        {
            InitializeComponent();

            incarcareDGV();
            incarcareCMBFunctie();
        }

        Utilizator util = new Utilizator();

        ConexiuniDB con = new ConexiuniDB();

        private void tsIesire_Click(object sender, EventArgs e)
        {
            Close();
        }
        private void txtCodFunctie_TextChanged(object sender, EventArgs e)
        {
            if (txtCodUtilizator.Text != string.Empty)
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
            if (txtNume.Text != string.Empty)
            {
                cmbFunctie.Enabled = true;
                cmbFunctie.SelectedIndex = -1;

                chkActiv.Enabled = true;
                chkActiv.Checked = true;

                btnModificare.Enabled = true;
            }
            else
            {
                btnModificare.Enabled = false;

                chkActiv.Checked = false;
                chkActiv.Enabled = false;

                cmbFunctie.Enabled = false;
                cmbFunctie.SelectedIndex = -1;
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
        private void incarcareCMBFunctie()
        {
            cmbFunctie.Items.Clear();
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codFunctie, denumireFunctie from functii order by codFunctie asc";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();
                        cititor = comanda.ExecuteReader();
                        while (cititor.Read())
                        {
                            int intCMBFunctie = cititor.GetInt32(0);
                            string strCMBFunctie = cititor.GetString(1);
                            cmbFunctie.Items.Add(intCMBFunctie + " -   " + strCMBFunctie);
                        }
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
            btnModificare.Enabled = false;

            chkActiv.Checked = false;
            chkActiv.Enabled = false;

            cmbFunctie.SelectedIndex = -1;
            cmbFunctie.Enabled = false;

            txtNume.Clear();
            txtNume.Enabled = false;

            btnGO.Enabled = false;

            txtCodUtilizator.Clear();
            txtCodUtilizator.Enabled = true;
            txtCodUtilizator.Focus();
        }
        private void btnGO_Click(object sender, EventArgs e)
        {
            util.iduser = Int32.Parse(txtCodUtilizator.Text);

            util.verifIdUserModificare();

            if (util.bevm == false)
            {
                txtCodUtilizator.Enabled = false;

                btnGO.Enabled = false;

                txtNume.Clear();
                txtNume.Enabled = true;
                txtNume.Focus();

                txtNume.Text = util.numeuser;

                cmbFunctie.SelectedIndex = util.functieuser - 1;

                if (util.activareuser == "true")
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
                txtNume.Clear();
                txtNume.Enabled = false;
                MessageBox.Show(util.scvm);
            }
        }
        private void btnModificare_Click(object sender, EventArgs e)
        {
            util.iduser = Int32.Parse(txtCodUtilizator.Text);
            util.numeuser = txtNume.Text;
            util.functieuser = Int32.Parse(cmbFunctie.Text.Substring(0, 1));
            if (chkActiv.Checked)
            {
                util.activareuser = "Y";
            }
            else
            {
                util.activareuser = "N";
            }

            util.modificareUser();

            if (util.bem == false)
            {
                MessageBox.Show("Utilizatorul a fost modificat cu succes.");

                incarcareDGV();

                txtCodUtilizator.Enabled = true;
                txtCodUtilizator.Clear();
                txtCodUtilizator.Focus();

                txtNume.Clear();
                txtNume.Enabled = false;

                cmbFunctie.SelectedIndex = -1;
            }
            else
            {
                MessageBox.Show(util.scm);
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

        private void btnVizualizareUtilizatori_Click(object sender, EventArgs e)
        {
            Form form = new frmVizualizareUtilizatori();

            form.MdiParent = this.ParentForm;

            foreach (Form forms in Application.OpenForms)
            {
                if (forms.GetType() == typeof(frmVizualizareUtilizatori))
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
