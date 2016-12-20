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

        private void incarcareDGV(int codStructura)
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select denumireStructura as \"Denumire structura\", nrNiveluri as \"Numar nivele\", nivela as \"Nivel 1\", nivelb as \"Nivel 2\", nivelc as \"Nivel 3\", niveld as \"Nivel 4\", nivele as \"Nivel 5\", nivelf as \"Nivel 6\", nivelg as \"Nivel 7\", nivelh as \"Nivel 8\", niveli as \"Nivel 9\", nivelj as \"Nivel 10\", nivelk as \"Nivel 11\", nivell as \"Nivel 12\", nivelm as \"Nivel 13\", niveln as \"Nivel 14\", nivelo as \"Nivel 15\" from denumiriNiveluri inner join Structuri on denumiriNiveluri.codStrucDenumiriNiv = Structuri.codStructura where codStrucDenumiriNiv = ? order by codStrucDenumiriNiv asc";
                    comanda.Parameters.AddWithValue("@codStrucDenumiriNiv", OdbcType.Int).Value = codStructura;

                    try
                    {
                        conexiune.Open();
                        OdbcDataAdapter da = new OdbcDataAdapter();
                        da.SelectCommand = comanda;

                        DataTable dt = new DataTable();
                        da.Fill(dt);

                        BindingSource bs = new BindingSource();
                        bs.DataSource = dt;

                        dgvNiveluri.DataSource = bs;

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

        private void btnOK_Click(object sender, EventArgs e)
        {
            int idStructura = Int32.Parse(cmbStructuri.Text.Substring(0,1));

            if (idStructura != 0)
            {
                using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
                {
                    using (OdbcCommand comanda = new OdbcCommand())
                    {
                        comanda.Connection = conexiune;
                        comanda.CommandType = CommandType.Text;
                        comanda.CommandText = "select nrNiveluri from denumiriNiveluri where codStrucDenumiriNiv = ?";
                        comanda.Parameters.AddWithValue("@codStrucDenumiriNiv", OdbcType.Int).Value = idStructura;

                        OdbcDataReader cititor;

                        try
                        {
                            conexiune.Open();
                            cititor = comanda.ExecuteReader();

                            if (cititor.HasRows != false)
                            {
                                incarcareDGV(idStructura);
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
        }
    }
}
