using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces_Base_de_Datos
{
    internal class BaseDeDatos
    {
        // Conexión para la base de datos, de ser necesario cambiar el nombre de la base
        const string CONEXION_BASE_DE_DATOS = "Data Source=(Local); database=Facturacion; Integrated Security=SSPI";

        internal static string getConexion()
        {
            return CONEXION_BASE_DE_DATOS;
        }
    }
}
