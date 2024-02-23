using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_Base_de_Datos
{
    public partial class frmInsertar : Form
    {
        public frmInsertar()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {

        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenú menu = new frmMenú();
            menu.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarConsola();
        }

        private void limpiarConsola()
        {
            txtCódigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtUnidad.Text = "";
            txtCódigoProveedor.Text = "";
            txtCódigoTipo.Text = "";
        }

        string strConn = null;
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;
        string idProd = "";
        string nombre = "";
        string precio = "";
        string unidad = "";
        string idTipo = "";
        string idProveedor = "";
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            idProd = txtCódigo.Text;
            nombre = "'" + txtNombre.Text + "'";
            precio = txtPrecio.Text;
            unidad = txtUnidad.Text;
            idTipo = txtCódigoTipo.Text;
            idProveedor = txtCódigoProveedor.Text;
            strConn = BaseDeDatos.getConexion();
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "INSERT INTO productos VALUES(" + idProd + "," + nombre + "," + precio + "," + unidad + "," + idTipo + "," + idProveedor + ")";
                using (comm = new SqlCommand(strComm, conn))
                {
                    int num = comm.ExecuteNonQuery();
                    if (num == 1)
                    {
                        MessageBox.Show("Producto ingresado con exito","Mensaje", MessageBoxButtons.OK);
                    }
                    limpiarConsola();
                }
            }
        }
    }
}
