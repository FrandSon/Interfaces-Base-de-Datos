using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_Base_de_Datos
{
    public partial class frmMostrarProductos : Form
    {
        private SqlDataReader reader;
        public frmMostrarProductos(System.Data.SqlClient.SqlDataReader reader)
        {
            InitializeComponent();
            this.reader = reader;
            agregarDatos();
        }

        private void agregarDatos()
        {
            while (reader.Read())
            {
                int id_producto = reader.GetInt32(0);
                string nombre_prod = reader.GetString(1);
                decimal precio_unit = reader.GetDecimal(2);
                string unidad = reader.IsDBNull(3) ? null : reader.GetString(3); // Si la columna permite valores nulos
                int id_tipo = reader.GetInt32(4);
                int id_proveedor = reader.GetInt32(5);

                listBoxProductos.Items.Add($"ID Producto: {id_producto}, Nombre: {nombre_prod}, Precio: {precio_unit}, Unidad: {unidad}, ID Tipo: {id_tipo}, ID Proveedor: {id_proveedor}");

            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
