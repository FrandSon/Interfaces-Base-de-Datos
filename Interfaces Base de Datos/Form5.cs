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
    public partial class frmConsultar : Form
    {
        public frmConsultar()
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
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.CODIGO, 1);
            consultarParametro.ShowDialog();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.NOMBRE, 0);
            consultarParametro.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.PRECIO, 1);
            consultarParametro.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.UNIDAD, 1);
            consultarParametro.ShowDialog();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.CODIGO_PROVEEDOR, 1);
            consultarParametro.ShowDialog();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmConsultarConParámetro consultarParametro = new frmConsultarConParámetro(Parametros.CODIGO_TIPO, 1);
            consultarParametro.ShowDialog();
        }
    }
}
