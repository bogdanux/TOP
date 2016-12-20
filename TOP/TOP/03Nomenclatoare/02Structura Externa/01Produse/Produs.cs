using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP
{
    class Produs
    {

        ConexiuniDB con = new ConexiuniDB();

        private int codProdus;
        public int codprodus
        {
            get
            {
                return codProdus;
            }
            set
            {
                codProdus = value;
            }
        }

        private string denumireProd;
        public string denumireprod
        {
            get
            {
                return denumireProd;
            }
            set
            {
                denumireProd = value;
            }
        }

        private DateTime dataAdaugare;
        public DateTime dataadaugare
        {
            get
            {
                return dataAdaugare;
            }
            set
            {
                dataAdaugare = value;
            }
        }

        private string descriereProdus;
        public string descriereprodus
        {
            get
            {
                return descriereProdus;
            }
            set
            {
                descriereProdus = value;
            }
        }

        private string activareProdus;
        public string activareprodus
        {
            get
            {
                return activareProdus;
            }
            set
            {
                activareProdus = value;
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

        public void verifCodProdus()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select codProdus from ProduseSoftware order by codProdus desc limit 1";

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        if (cititor.HasRows == false)
                        {
                            codProdus = 1;
                        }
                        else
                        {
                            codProdus = cititor.GetInt32(0) + 1;
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

        public void adaugareProdus()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "insert into ProduseSoftware values (?, ?, ?, ?, ?)";
                    comanda.Parameters.AddWithValue("@codProdus", OdbcType.Int).Value = codProdus;
                    comanda.Parameters.AddWithValue("@denumireProdus", OdbcType.NVarChar).Value = denumireProd;
                    comanda.Parameters.AddWithValue("@dataAdaugareProd", OdbcType.Date).Value = dataAdaugare;
                    comanda.Parameters.AddWithValue("@descriereProdus", OdbcType.NVarChar).Value = descriereProdus;
                    comanda.Parameters.AddWithValue("@produsActiv", OdbcType.NVarChar).Value = activareProdus;

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

        public void verificareProdModificare()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "select * from ProduseSoftware where codProdus = ?";
                    comanda.Parameters.AddWithValue("@codProdus", OdbcType.Int).Value = codProdus;

                    OdbcDataReader cititor;

                    try
                    {
                        conexiune.Open();

                        cititor = comanda.ExecuteReader();

                        string[] produseSoftware = new string[cititor.FieldCount];

                        while (cititor.Read())
                        {
                            for (int i = 0; i < cititor.FieldCount; i++)
                            {
                                produseSoftware[i] = cititor[i].ToString();
                            }
                        }

                        if (cititor.HasRows == false)
                        {
                            BEVM = true;
                            SCVM = "Produsul cautat nu exista in baza de date.";
                        }
                        else
                        {
                            codProdus = Int32.Parse(produseSoftware[0]);
                            denumireProd = produseSoftware[1];
                            dataAdaugare = DateTime.Parse(produseSoftware[2]);
                            descriereProdus = produseSoftware[3];
                            activareProdus = produseSoftware[4];
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

        public void modificareProdus()
        {
            using (OdbcConnection conexiune = new OdbcConnection(con.sirconTOP))
            {
                using (OdbcCommand comanda = new OdbcCommand())
                {
                    comanda.Connection = conexiune;
                    comanda.CommandType = CommandType.Text;
                    comanda.CommandText = "update ProduseSoftware set denumireProdus = ?, dataAdaugareProd = ?, descriereProdus = ?, produsActiv = ? where codProdus = ?";
                    comanda.Parameters.AddWithValue("@denumireProdus", OdbcType.NVarChar).Value = denumireProd;
                    comanda.Parameters.AddWithValue("@dataAdaugareProd", OdbcType.Date).Value = dataAdaugare;
                    comanda.Parameters.AddWithValue("@descriereProdus", OdbcType.NVarChar).Value = descriereProdus;
                    comanda.Parameters.AddWithValue("@produsActiv", OdbcType.NVarChar).Value = activareProdus;
                    comanda.Parameters.AddWithValue("@codProdus", OdbcType.Int).Value = codProdus;

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
