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
    public partial class frmActualizar : Form
    {
        private string parametro;
        string strConn = BaseDeDatos.getConexion();
        string strComm = null;
        SqlConnection conn = null;
        SqlCommand comm = null;
        public frmActualizar()
        {
            InitializeComponent();
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                if (checkBoxNombre.Checked && checkBoxPrecio.Checked && checkBoxUnidad.Checked)
                {
                    strComm = "UPDATE Productos SET nombre_prod = '" + txtNombre.Text + "' ,precio_unit = " + txtPrecio.Text + ", unidad = " +
                        txtUnidad.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxNombre.Checked && checkBoxPrecio.Checked)
                {
                    strComm = "UPDATE Productos SET nombre_prod = '" + txtNombre.Text + "' ,precio_unit = " + txtPrecio.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxNombre.Checked && checkBoxUnidad.Checked)
                {
                    strComm = "UPDATE Productos SET nombre_prod = '" + txtNombre.Text + "',unidad = " + txtUnidad.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxPrecio.Checked && checkBoxUnidad.Checked)
                {
                    strComm = "UPDATE Productos SET precio_unit = '" + txtPrecio.Text + "',unidad = " + txtUnidad.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxNombre.Checked)
                {
                    strComm = "UPDATE Productos SET nombre_prod = '" + txtNombre.Text + "' WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxPrecio.Checked)
                {
                    strComm = "UPDATE Productos SET precio_unit = " + txtPrecio.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else if (checkBoxUnidad.Checked)
                {
                    strComm = "UPDATE Productos SET unidad = " + txtUnidad.Text + " WHERE id_producto = " + txtCódigo.Text;
                    using (comm = new SqlCommand(strComm, conn))
                    {
                        mostrarMensaje(comm.ExecuteNonQuery());
                    }
                }
                else
                {
                    MessageBox.Show("No se a seleccionado nada para actualizar", "Mensaje", MessageBoxButtons.OK);
                }
            }
            limpiarEntradas();
        }
    

        private void mostrarMensaje(int v)
        {
            if (v == 1)
            {
                MessageBox.Show("Producto actualizado con éxito", "Mensaje", MessageBoxButtons.OK);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxPrecio.Checked)
            {
                txtPrecio.Enabled = true;
            }
            else
            {
                txtPrecio.Enabled = false;
            }
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenú menu = new frmMenú();
            menu.ShowDialog();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            using (conn = new SqlConnection(strConn))
            {
                conn.Open();
                strComm = "SELECT nombre_prod, precio_unit, unidad FROM Productos WHERE id_producto = " + txtCódigo.Text;
                using (comm = new SqlCommand(strComm, conn))
                {
                    SqlDataReader reader = comm.ExecuteReader();
                    while (reader.Read())
                    {
                        txtNombre.Text = reader.GetString(0);
                        txtPrecio.Text = reader.GetDecimal(1).ToString();
                        txtUnidad.Text = reader.GetString(2);
                    }
                }
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            limpiarEntradas();
        }

        private void limpiarEntradas()
        {
            txtCódigo.Text = "";
            txtNombre.Text = "";
            txtPrecio.Text = "";
            txtUnidad.Text = "";
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxNombre.Checked)
            {
                txtNombre.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
            }
        }

        private void checkBoxUnidad_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxUnidad.Checked)
            {
                txtUnidad.Enabled = true;
            }
            else
            {
                txtUnidad.Enabled = false;
            }
        }
    }
}


