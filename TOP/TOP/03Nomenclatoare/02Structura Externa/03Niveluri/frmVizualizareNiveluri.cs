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
    public partial class frmVizualizareNiveluri : Form
    {
        public frmVizualizareNiveluri()
        {
            InitializeComponent();

            incarcareCMBStructuri();
        }

        ConexiuniDB con = new ConexiuniDB();

        private void btnIesire_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmbStructuri_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbStructuri.SelectedIndex != - 1)
            {
                btnOK.Enabled = true;
                dgvNiveluri.Enabled = true;
            }
            else
            {
                btnOK.Enabled = false;
                dgvNiveluri.Enabled = false;
            }
        }

        private void incarcareCMBStructuri()
        {
            cmbStructuri.Items.Clear();
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codStructura, denumireStructura from Structuri order by codStructura asc";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();
                        cititor = comanda.ExecuteReader();
                        while (cititor.Read())
                        {
                            int intCMBStruc = cititor.GetInt32(0);
                            string strCMBStruc = cititor.GetString(1);
                            cmbStructuri.Items.Add(intCMBStruc + " -   " + strCMBStruc);
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

        private void verifExistNivPeStruct()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select * ";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();
                        cititor = comanda.ExecuteReader();



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

        private void btnOK_Click(object sender, EventArgs e)
        {
            int idStructura = Int32.Parse(cmbStructuri.Text.Substring(0,1));


        }
    }
}
