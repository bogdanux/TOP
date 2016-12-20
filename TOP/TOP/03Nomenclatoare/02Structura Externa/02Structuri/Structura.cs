using System;
using System.Data;
using System.Data.Odbc;

namespace TOP
{
    class Structura
    {
        ConexiuniDB con = new ConexiuniDB();

        private int codStructura;
        public int codstructura
        {
            get
            {
                return codStructura;
            }
            set
            {
                codStructura = value;
            }
        }

        private string denumireStructura;
        public string denumirestructura
        {
            get
            {
                return denumireStructura;
            }
            set
            {
                denumireStructura = value;
            }
        }

        private DateTime dataAdaugareStruct;
        public DateTime dataadaugarestruct
        {
            get
            {
                return dataAdaugareStruct;
            }
            set
            {
                dataAdaugareStruct = value;
            }
        }
        
        private bool BEV;
        public bool bev
        {
            get
            {
                return BEV;
            }
        }

        private string SCV;
        public string scv
        {
            get
            {
                return SCV;
            }
        }

        private bool BEA;
        public bool bea
        {
            get
            {
                return BEA;
            }
        }

        private string SCA;
        public string sca
        {
            get
            {
                return SCA;
            }
        }

        private bool BEVM;
        public bool bevm
        {
            get
            {
                return BEVM;
            }
        }

        private string SCVM;
        public string scvm
        {
            get
            {
                return SCVM;
            }
        }

        private bool BEM;
        public bool bem
        {
            get
            {
                return BEM;
            }
        }

        private string SCM;
        public string scm
        {
            get
            {
                return SCM;
            }
        }

        public void verifCodStruct()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codStructura from Structuri order by codStructura desc limit 1";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            codStructura = 1;
                        }
                        else
                        {
                            codStructura = cititor.GetInt32(0) + 1;
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

        public void adaugareStructura()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "insert into Structuri values (?, ?, ?)";
                    comanda.Parameters.AddWithValue("@codStructura", OdbcType.Int).Value = codStructura;
                    comanda.Parameters.AddWithValue("@denumireStructura", OdbcType.NVarChar).Value = denumireStructura;
                    comanda.Parameters.AddWithValue("@dataAdaugareStruct", OdbcType.Date).Value = dataAdaugareStruct;

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

        public void verificareStrucModificare()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select * from Structuri where codStructura = ?";
                    comanda.Parameters.AddWithValue("@codStructura", OdbcType.Int).Value = codStructura;

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        string[] structuriOrg = new string[cititor.FieldCount];

                        while (cititor.Read())
                        {
                            for (int i = 0; i < cititor.FieldCount; i++)
                            {
                                structuriOrg[i] = cititor[i].ToString();
                            }
                        }

                        if (cititor.HasRows == false)
                        {
                            BEVM = true;
                            SCVM = "Structura cautata nu exista in baza de date.";
                        }
                        else
                        {
                            codStructura = Int32.Parse(structuriOrg[0]);
                            denumireStructura = structuriOrg[1];
                            dataAdaugareStruct = DateTime.Parse(structuriOrg[2]);
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

        public void modificareStructura()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "update Structuri set denumireStructura = ?, dataAdaugareStruct = ? where codStructura = ?";
                    comanda.Parameters.AddWithValue("@denumireProdus", OdbcType.NVarChar).Value = denumireStructura;
                    comanda.Parameters.AddWithValue("@dataAdaugareProd", OdbcType.Date).Value = dataAdaugareStruct;
                    comanda.Parameters.AddWithValue("@codProdus", OdbcType.Int).Value = codStructura;

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
