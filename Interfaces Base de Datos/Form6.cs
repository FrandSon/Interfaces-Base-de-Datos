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
    public partial class frmConsultarConParámetro : Form
    {
        private Parametros parametro;
        string strConn = BaseDeDatos.getConexion();
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;

        public frmConsultarConParámetro(Parametros parametro, int v)
        {
            InitializeComponent();
            this.parametro = parametro;
            activarCajasDeTexto(v);
        }

        private void activarCajasDeTexto(int v)
        {
            if (v == 0)
            {
                txtParámetroParaConsultar.Enabled = true;
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
            frmConsultar consultar = new frmConsultar();
            consultar.ShowDialog();
        }
        private void btnConsultar_Click(object sender, EventArgs e)
        {
            string condicion = "";
            using (conn = new SqlConnection(strConn))
            {
                condicion = obtenerCondicion(comboBoxNumeros);
                conn.Open();
                switch (parametro)
                {
                    case Parametros.CODIGO:
                        strComm = "SELECT * FROM Productos WHERE id_producto" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                    case Parametros.NOMBRE:
                        strComm = "SELECT * FROM Productos WHERE nombre_prod LIKE '%" + txtParámetroParaConsultar.Text + "%'";
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                    case Parametros.PRECIO:
                        strComm = "SELECT * FROM Productos WHERE precio_unit" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                    case Parametros.UNIDAD:
                        strComm = "SELECT * FROM Productos WHERE unidad" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                    case Parametros.CODIGO_PROVEEDOR:
                        strComm = "SELECT * FROM Productos WHERE id_proveedor" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                    case Parametros.CODIGO_TIPO:
                        strComm = "SELECT * FROM Productos WHERE id_tipo" + condicion + txtParametroNumero.Text;
                        using (comm = new SqlCommand(strComm, conn))
                        {
                            SqlDataReader rdr = comm.ExecuteReader();
                            mensajeDeVerificación(rdr);
                        }
                        break;
                }
                txtParámetroParaConsultar.Text = "";
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

        private void mensajeDeVerificación(SqlDataReader reader)
        {
            frmMostrarProductos mostrar = new frmMostrarProductos(reader);
            mostrar.ShowDialog();
        }

        private void txtParámetroParaConsultar_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            txtParámetroParaConsultar.Text = "";
            txtParametroNumero.Text = "";
        }

        private void frmConsultarConParámetro_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
