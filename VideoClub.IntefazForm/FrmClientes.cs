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
            CargarListadoClientes();
        }

        private void CargarListadoClientes()
        {
            List<Cliente> lstClientes = _videoClubNegocio.ConsultarClientes();
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";
        }
        
        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarClientes_Click(object sender, EventArgs e)
        {
            FrmIngresarCliente frmIngresoCliente = new FrmIngresarCliente(this);
            frmIngresoCliente.Show();

            this.Hide();
        }

        private void _btnConsultarCliente_Click(object sender, EventArgs e)
        {         
            string idCliente = (string)_cmbClientes.SelectedValue;
            Cliente cliente = _videoClubNegocio.ConsultarClientePorIdCliente(idCliente);                             

            if (cliente != null)
            {
                _lblClienteParaMostrar.Text = cliente.ToString();

            }
            else
            {
                MessageBox.Show("No hay informacion del cliente seleccionado");
            }                      
        }

        private void _btnActualizarListado_Click(object sender, EventArgs e)
        {
            CargarListadoClientes();
        }
    }
}
