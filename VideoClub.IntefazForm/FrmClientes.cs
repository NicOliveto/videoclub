using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Entidades;
using VideoClub.Negocio;

namespace VideoClub.IntefazForm
{
    public partial class FrmClientes : Form
    {


        private VideoClubNegocio _videoClubNegocio; 
        public FrmClientes(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void FrmClientes_Load(object sender, EventArgs e)
        {

            CargarListado();
           

        }
        private void CargarListado()
        {
            List<Cliente> lstClientes = _videoClubNegocio.GetListClientes();
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "IdCliente";

        }



        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarClientes_Click(object sender, EventArgs e)
        {
            FrmIngresoCliente frmIngresoCliente = new FrmIngresoCliente(this);
            frmIngresoCliente.Show();

            this.Hide();
        }

        private void _cmbClientes_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
