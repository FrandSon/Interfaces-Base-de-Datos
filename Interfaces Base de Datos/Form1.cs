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
    public partial class frmMenú : Form
    {
        public frmMenú()
        {
            InitializeComponent();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnSalir_MouseEnter(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Bisque;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            btnSalir.BackColor = Color.Transparent;
        }

        private void btnInsertar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            frmInsertar insertar = new frmInsertar();
            insertar.ShowDialog();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            frmEliminar eliminar = new frmEliminar();
            eliminar.ShowDialog();
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            frmConsultar consultar = new frmConsultar();
            consultar.ShowDialog();
        }
    }
}
