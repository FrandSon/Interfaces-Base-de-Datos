using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Interfaces_Base_de_Datos
{
    public partial class frmEliminar : Form
    {
        public frmEliminar()
        {
            InitializeComponent();
        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmMenú menu = new frmMenú();
            menu.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Código",1);
            eliminarParametro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Nombre",0);
            eliminarParametro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Precio",1);
            eliminarParametro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Unidad",1);
            eliminarParametro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Código Proveedor",1);
            eliminarParametro.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmEliminarConParámetro eliminarParametro = new frmEliminarConParámetro("Código Tipo",1);
            eliminarParametro.ShowDialog();
        }
    }
}
