using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    public partial class frmAdaugareUtilizatori : Form
    {
        public frmAdaugareUtilizatori()
        {
            InitializeComponent();

            incarcareDGV();
            incarcareCMBFunctie();

            util.citireIdUserAdaugare();

            if (util.bev == false)
            {
                txtCodUtilizator.Text = util.iduser.ToString();
            }
            else
            {
                MessageBox.Show(util.scc);
            }
        }

        ConexiuniDB con = new ConexiuniDB();

        Utilizator util = new Utilizator();

        private void tsIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAdaugare_Click(object sender, EventArgs e)
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

            util.adaugareUser();

            if (util.bea == true)
            {
                MessageBox.Show(util.sca);
            }
            else
            {
                MessageBox.Show("Utilizatorul a fost adaugat cu succes.");
                cmbFunctie.SelectedIndex = -1;
                txtNume.Clear();
                txtNume.Focus();

                incarcareDGV();

                util.citireIdUserAdaugare();

                if (util.bec == true)
                {
                    MessageBox.Show(util.scc);
                }
                else
                {
                    txtCodUtilizator.Text = util.iduser.ToString();
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

        private void txtNume_TextChanged(object sender, EventArgs e)
        {
            if (txtNume.Text != string.Empty)
            {
                cmbFunctie.Enabled = true;
                cmbFunctie.SelectedIndex = -1;
            }
            else
            {
                btnAdaugare.Enabled = false;

                chkActiv.Checked = false;
                chkActiv.Enabled = false;

                cmbFunctie.SelectedIndex = -1;
                cmbFunctie.Enabled = false;
            }
        }

        private void cmbFunctie_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbFunctie.SelectedIndex != -1)
            {
                chkActiv.Enabled = true;
                btnAdaugare.Enabled = true;
            }
            else
            {
                chkActiv.Enabled = false;
                btnAdaugare.Enabled = false;
            }
        }

        private void btnModificareUtilizatori_Click(object sender, EventArgs e)
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
