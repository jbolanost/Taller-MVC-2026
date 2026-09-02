using System;
using System.Collections.Generic;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TallerModel
{
    public class Sentencias
    {
        Conexion conn = new Conexion();

        public OdbcDataAdapter llenarTbl(string nombreTabla) 
        { 
            string sSQL = "Select * From " + nombreTabla + " ;";
            OdbcDataAdapter daSentencias = new OdbcDataAdapter(sSQL, conn.conexion());
            return daSentencias;
        }
    }
}
