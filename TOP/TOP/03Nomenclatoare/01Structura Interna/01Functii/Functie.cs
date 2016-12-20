using System;
using System.Data;
using System.Data.Odbc;
using System.Windows.Forms;

namespace TOP
{
    class Functie
    {
        ConexiuniDB con = new ConexiuniDB();

        private int codFunctie;
        private string denumireFunctie;
        private int nivelFunctie;
        private string activareFunctie;

        public int codfunctie
        {
            get
            {
                return codFunctie;
            }
            set
            {
                codFunctie = value;
            }
        }
        public string denumirefunctie
        {
            get
            {
                return denumireFunctie;
            }
            set
            {
                denumireFunctie = value;
            }
        }
        public int nivelfunctie
        {
            get
            {
                return nivelFunctie;
            }
            set
            {
                nivelFunctie = value;
            }
        }
        public string activarefunctie
        {
            get
            {
                return activareFunctie;
            }
            set
            {
                activareFunctie = value;
            }
        }

        private string SCV = string.Empty;
        public string scv
        {
            get
            {
                return SCV;
            }
        }
        private bool BEV = false;
        public bool bev
        {
            get
            {
                return BEV;
            }
        }

        private string SCA = string.Empty;
        public string sca
        {
            get
            {
                return SCA;
            }
        }
        private bool BEA = false;
        public bool bea
        {
            get
            {
                return BEA;
            }
        }

        private string SCVM = string.Empty;
        public string scvm
        {
            get
            {
                return SCVM;
            }
            set
            {
                SCVM = value;
            }
        }
        private bool BEVM = false;
        public bool bevm
        {
            get
            {
                return BEVM;
            }
            set
            {
                BEVM = value;
            }
        }

        private string SCM = string.Empty;
        public string scm
        {
            get
            {
                return SCM;
            }
            set
            {
                SCM = value;
            }
        }
        private bool BEM = false;
        public bool bem
        {
            get
            {
                return BEM;
            }
            set
            {
                BEM = value;
            }
        }

        private string SCI = string.Empty;
        public string sci
        {
            get
            {
                return SCI;
            }
        }
        private bool BEI = false;
        public bool bei
        {
            get
            {
                return BEI;
            }
        }

        public void verifIdFunctie()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codFunctie from Functii order by codFunctie desc limit 1";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        while (cititor.Read())
                        {
                            if (cititor.HasRows == false)
                            {
                                codFunctie = 1;
                            }
                            else
                            {
                                codFunctie = cititor.GetInt32(0) + 1;
                            }
                        }
                    }
                    catch (Exception exceptie)
                    {
                        BEV = true;
                        SCV = exceptie.Message;
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        public void adaugareFunctie()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "insert into functii values (?, ?, ?, ?)";
                    comanda.Parameters.AddWithValue("@codFunctie", OdbcType.Int).Value = codFunctie;
                    comanda.Parameters.AddWithValue("@denumireFunctie", OdbcType.NVarChar).Value = denumireFunctie;
                    comanda.Parameters.AddWithValue("@nivelFunctie", OdbcType.Int).Value = nivelFunctie;
                    comanda.Parameters.AddWithValue("@activareFunctie", OdbcType.NVarChar).Value = activareFunctie;

                    try
                    {
                        conexiune.Open();
                        int recordsAffected = comanda.ExecuteNonQuery();
                    }
                    catch (Exception exceptie)
                    {
                        SCA = exceptie.Message;
                        BEA = true;
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        public void verifIdFunctieModificare()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select * from Functii where codFunctie = ?";
                    comanda.Parameters.AddWithValue("@codFunctie", OdbcType.Int).Value = codFunctie;

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            BEVM = true;
                            SCVM = "Functia cautata nu exista in baza de date.";
                        }
                        else
                        {
                            codFunctie = cititor.GetInt32(0);
                            denumireFunctie = cititor.GetString(1);
                            nivelFunctie = cititor.GetInt32(2);

                            if (cititor.GetBoolean(3) == true)
                            {
                                activareFunctie = "true";
                            }
                            else
                            {
                                activareFunctie = "false";
                            }
                        }
                    }
                    catch (Exception exceptie)
                    {
                        BEVM = true;
                        SCVM = exceptie.Message;
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        public void modificareFunctie()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "update functii set denumireFunctie = ?, nivelFunctie = ?, activareFunctie = ? where codFunctie = ?";
                    comanda.Parameters.AddWithValue("@denumireFunctie", OdbcType.NVarChar).Value = denumireFunctie;
                    comanda.Parameters.AddWithValue("@nivelFunctie", OdbcType.Int).Value = nivelFunctie;
                    comanda.Parameters.AddWithValue("@activareFunctie", OdbcType.NVarChar).Value = activareFunctie;
                    comanda.Parameters.AddWithValue("@codFunctie", OdbcType.Int).Value = codFunctie;

                    try
                    {
                        conexiune.Open();
                        int recordsAffected = comanda.ExecuteNonQuery();
                    }
                    catch (Exception exceptie)
                    {
                        SCM = exceptie.Message;
                        BEM = true;
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
