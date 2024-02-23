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
    public partial class frmEliminarConParámetro : Form
    {
        private Parametros parametro;
        string strConn = BaseDeDatos.getConexion();
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;

        public frmEliminarConParámetro(Parametros parametro, int v)
        {
            InitializeComponent();
            this.parametro = parametro;
            activarCajasDeTexto(v);
        }

        private void activarCajasDeTexto(int v)
        {
            if(v == 0)
            {
                txtParámetroParaEliminar.Enabled = true;
            }
            else
            {
                txtParametroNumero.Enabled = true;
                comboBoxNumeros.Enabled = true;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminar eliminar = new frmEliminar();
            eliminar.ShowDialog();
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            using (conn = new SqlConnection(strConn))
            {
                condicion = obtenerCondicion(comboBoxNumeros);
                conn.Open();
                switch (parametro)
                {
                    case Parametros.CODIGO:
                        strComm = "DELETE FROM Productos WHERE id_producto" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                    case Parametros.NOMBRE:
                        strComm = "DELETE FROM Productos WHERE nombre_prod LIKE '%" + txtParámetroParaEliminar.Text + "%'";
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                    case Parametros.PRECIO:
                        strComm = "DELETE FROM Productos WHERE precio_unit" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                    case Parametros.UNIDAD:
                        strComm = "DELETE FROM Productos WHERE unidad" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                    case Parametros.CODIGO_PROVEEDOR:
                        strComm = "DELETE FROM Productos WHERE id_proveedor" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                    case Parametros.CODIGO_TIPO:
                        strComm = "DELETE FROM Productos WHERE id_tipo" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            mensajeDeVerificación(comm.ExecuteNonQuery());
                        }
                        break;
                }
                txtParámetroParaEliminar.Text = "";
            }
        }

        private string obtenerCondicion(ComboBox comboBoxNumeros)
        {
            string condicion = "";
            switch (comboBoxNumeros.SelectedIndex)
            {
                case 0:
                    condicion = " = ";
                    break;
                case 1:
                    condicion = " > ";
                    break;
                case 2:
                    condicion = " < ";
                    break;
                case 3:
                    condicion = " >= ";
                    break;
                case 4:
                    condicion = " <= ";
                    break;
                default:
                    if (comboBoxNumeros.Enabled == true)
                    {
                        MessageBox.Show("Tiene que escoger una condición", "Mensaje", MessageBoxButtons.OK);
                    }
                    break;

            }
            return condicion;
        }

        private void mensajeDeVerificación(int v)
        {
            if (v >= 1)
            {
                MessageBox.Show("Producto eliminado con éxito", "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void txtParámetroParaEliminar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtParámetroParaEliminar.Text = "";
            txtParametroNumero.Text = "";
        }

        private void frmEliminarConParámetro_Load(object sender, EventArgs e)
        {

        }
    }

}
