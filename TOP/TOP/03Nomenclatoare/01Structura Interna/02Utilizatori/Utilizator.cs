using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP
{
    class Utilizator
    {
        private int idUser;
        public int iduser
        {
            get
            {
                return idUser;
            }
            set
            {
                idUser = value;
            }
        }

        private string numeUser = string.Empty;
        public string numeuser
        {
            get
            {
                return numeUser;
            }
            set
            {
                numeUser = value;
            }
        }

        private int functieUser;
        public int functieuser
        {
            get
            {
                return functieUser;
            }
            set
            {
                functieUser = value;
            }
        }

        private string activareUser;
        public string activareuser
        {
            get
            {
                return activareUser;
            }
            set
            {
                activareUser = value;
            }
        }

        private bool BEC = false;
        private string SCC = string.Empty;
        public bool bec
        {
            get
            {
                return BEC;
            }
        }
        public string scc
        {
            get
            {
                return SCC;
            }
        }

        private bool BEA = false;
        private string SCA = string.Empty;
        public bool bea
        {
            get
            {
                return BEA;
            }
        }
        public string sca
        {
            get
            {
                return SCA;
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

        private bool BEV = false;
        private string SCV = string.Empty;
        public bool bev
        {
            get
            {
                return BEV;
            }
        }
        public string scv
        {
            get
            {
                return SCV;
            }
        }

        private bool BEM = false;
        private string SCM = string.Empty;
        public bool bem
        {
            get
            {
                return BEM;
            }
        }
        public string scm
        {
            get
            {
                return SCM;
            }
        }

        private bool BECO = false;
        private string SCCO = string.Empty;
        public bool beco
        {
            get
            {
                return BECO;
            }
        }
        public string scco
        {
            get
            {
                return SCCO;
            }
        }

        ConexiuniDB con = new ConexiuniDB();

        public void citireIdUserAdaugare()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select iduser from utilizatori order by iduser desc limit 1";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            idUser = 1;
                        }
                        else
                        {
                            idUser = cititor.GetInt32(0) + 1;
                        }
                    }
                    catch (Exception exceptie)
                    {
                        SCC = exceptie.Message;
                        BEC = true;
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        public void adaugareUser()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "insert into utilizatori values (?, ?, ?, ?)";
                    comanda.Parameters.AddWithValue("@idUser", OdbcType.Int).Value = idUser;
                    comanda.Parameters.AddWithValue("@numeUser", OdbcType.NVarChar).Value = numeUser;
                    comanda.Parameters.AddWithValue("@functieUser", OdbcType.Int).Value = functieUser;
                    comanda.Parameters.AddWithValue("@activareUser", OdbcType.NVarChar).Value = activareUser;

                    try
                    {
                        conexiune.Open();
                        int recordsAffected = comanda.ExecuteNonQuery();
                    }
                    catch (Exception exadaugareUser)
                    {
                        SCA = exadaugareUser.Message;
                        BEA = true;
                    }
                    finally
                    {
                        conexiune.Close();
                    }
                }
            }
        }

        public void verifIdUserModificare()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select * from Utilizatori where idUser = ?";
                    comanda.Parameters.AddWithValue("@codFunctie", OdbcType.Int).Value = idUser;

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            BEVM = true;
                            SCVM = "Utilizatorul cautat nu exista in baza de date.";
                        }
                        else
                        {
                            idUser = cititor.GetInt32(0);
                            numeUser = cititor.GetString(1);
                            functieUser = cititor.GetInt32(2);

                            if (cititor.GetBoolean(3) == true)
                            {
                                activareUser = "true";
                            }
                            else
                            {
                                activareUser = "false";
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

        public void modificareUser()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "update utilizatori set numeUser = ?, functieUser = ?, activareUser = ? where idUser = ?";
                    comanda.Parameters.AddWithValue("@numeUser", OdbcType.NVarChar).Value = numeUser;
                    comanda.Parameters.AddWithValue("@functieUser", OdbcType.Int).Value = functieUser;
                    comanda.Parameters.AddWithValue("@activareUser", OdbcType.NVarChar).Value = activareUser;
                    comanda.Parameters.AddWithValue("@idUser", OdbcType.Int).Value = idUser;

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
