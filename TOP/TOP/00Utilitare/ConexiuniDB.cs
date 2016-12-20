using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TOP
{
    class ConexiuniDB
    {
        public static string SirConTOP = "Dsn=PostgreSQL35W;server=localhost;port=5432;uid=postgres;pwd=12345;";

        public string sirconTOP
        {
            get
            {
                return SirConTOP;
            }
        }
    }
}
