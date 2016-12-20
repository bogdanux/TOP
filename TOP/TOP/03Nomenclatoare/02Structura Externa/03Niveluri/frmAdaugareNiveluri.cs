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
    public partial class frmAdaugareNiveluri : Form
    {
        public frmAdaugareNiveluri()
        {
            InitializeComponent();

            verificareNiveleBD();
        }

        ConexiuniDB con = new ConexiuniDB();

        private void iesireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void txtNrNiveluri_TextChanged(object sender, EventArgs e)
        {
            bool booltxtNeNivele;
            int vartxtNrNivele;

            if (txtNrNiveluri.Text != string.Empty)
            {
                booltxtNeNivele = Int32.TryParse(txtNrNiveluri.Text, out vartxtNrNivele);

                if (!booltxtNeNivele)
                {
                    txtNrNiveluri.Clear();
                    MessageBox.Show("Va rugam introduceti doar numere in aceasta caseta de text.");
                }
                else if (vartxtNrNivele > 15)
                {
                    txtNrNiveluri.Clear();
                    MessageBox.Show("Numarul de nivele maxim admis este 15.");
                }
                else if (vartxtNrNivele < 1)
                {
                    txtNrNiveluri.Clear();
                    MessageBox.Show("Numarul de nivele minim admis este 1.");
                }
                else
                {
                    btnOK.Enabled = true;
                }
            }
            else
            {
                btnOK.Enabled = false;
            }
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            aranjareCampuri();

            txtNrNiveluri.Enabled = false;

            btnOK.Enabled = false;

            btnNOK.Visible = true;
            btnNOK.Enabled = true;

            btnAdauga.Visible = true;
            btnAdauga.Enabled = true;
        }

        private void btnNOK_Click(object sender, EventArgs e)
        {
            panouControale.Controls.Clear();
            btnOK.Enabled = true;
            txtNrNiveluri.Enabled = true;
            txtNrNiveluri.Clear();
            txtNrNiveluri.Focus();
            btnNOK.Visible = false;
            btnAdauga.Visible = false;
        }

        private bool verificareNiveleBD()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select nrNivele from ConfigurareStructura";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();
                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            txtNrNiveluri.Enabled = true;
                            btnOK.Enabled = true;
                            return false;
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

            return true;
        }

        private void aranjareCampuri()
        {
            Label lblNumeCamp = new Label();
            lblNumeCamp.Name = "lblNumeCamp";
            lblNumeCamp.Text = "Denumire";
            lblNumeCamp.TextAlign = ContentAlignment.MiddleCenter;
            lblNumeCamp.Top = 0;
            lblNumeCamp.Left = 100;
            lblNumeCamp.Height = 26;
            lblNumeCamp.Width = 150;
            lblNumeCamp.AutoSize = false;

            Label lblValoareCamp = new Label();
            lblValoareCamp.Name = "lblNumeCamp";
            lblValoareCamp.Text = "Valoare";
            lblValoareCamp.TextAlign = ContentAlignment.MiddleCenter;
            lblValoareCamp.Top = 0;
            lblValoareCamp.Left = 300;
            lblValoareCamp.Height = 26;
            lblValoareCamp.Width = 150;
            lblValoareCamp.AutoSize = false;

            panouControale.Controls.Add(lblNumeCamp);
            panouControale.Controls.Add(lblValoareCamp);

            for (int i = 1; i <= Int32.Parse(txtNrNiveluri.Text); i++)
            {
                TextBox txta = new TextBox();
                txta.Name = "txtNumeCamp" + i.ToString();
                txta.Enabled = true;
                txta.Top = i * 26;
                txta.Left = 0;
                txta.Width = 250;
                txta.Height = 20;

                TextBox txtb = new TextBox();
                txtb.Name = "txtValoareCamp" + i.ToString();
                txtb.Enabled = true;
                txtb.Top = i * 26;
                txtb.Left = 256;
                txtb.Width = 370;
                txtb.Height = 20;

                panouControale.Controls.Add(txta);
                panouControale.Controls.Add(txtb);
            }
        }

        private void incarcareDinBD()
        {

        }
    }
}
