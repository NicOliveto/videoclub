using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoClub.IntefazForm
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

    




        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void _btnClientes_Click(object sender, EventArgs e)
        {
            FrmClientes frmClientes = new FrmClientes(this);
            frmClientes.Show();
            this.Hide();

        }

        private void _btnPrestamos_Click(object sender, EventArgs e)
        {
            FrmPrestamos frmPrestamos = new FrmPrestamos(this);
            frmPrestamos.Show();
            this.Hide();



        }

        private void _btnpeliculas_Click(object sender, EventArgs e)
        {

        }

        private void _btnCopias_Click(object sender, EventArgs e)
        {

        }

        private void _btnReportes_Click(object sender, EventArgs e)
        {

        }
    }
}
