using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VideoClub.Entidades;
using VideoClub.Negocio;

namespace VideoClub.IntefazForm
{
    public partial class FrmPrestamos : Form
    {
        
        private VideoClubNegocio _videoClubNegocio;


        public FrmPrestamos(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarPrestamos_Click(object sender, EventArgs e)
        {
            FrmIngresarPrestamo frmIngresarPrestamo = new FrmIngresarPrestamo(this);
            frmIngresarPrestamo.Show();
            this.Hide();

        }

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarListadoPrestamosAbiertos();
            CargarListadoClientes();
            CargarListadoPrestamosCerrados();
        }
        private void CargarListadoClientes()
        {
            List<Cliente> lstClientes = _videoClubNegocio.ConsultarClientes();
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";

        }


        private void CargarListadoPrestamosAbiertos()
        {
            List<Prestamo> lstPrestamosAbiertos = _videoClubNegocio.ConsultarPrestamosPorCondicion(true);
            _cmbPrestamosAbiertos.DisplayMember = "ComboDisplay";
            _cmbPrestamosAbiertos.ValueMember = "IdPrestamo";
            _cmbPrestamosAbiertos.DataSource = null;
            _cmbPrestamosAbiertos.DataSource = lstPrestamosAbiertos;            

        }

        private void CargarListadoPrestamosCerrados()
        {
            List<Prestamo> lstPrestamosCerrados = _videoClubNegocio.ConsultarPrestamosPorCondicion(false);
            _cmbPrestamosCerrados.DisplayMember = "ComboDisplay";
            _cmbPrestamosCerrados.ValueMember = "IdPrestamo";
            _cmbPrestamosCerrados.DataSource = null;
            _cmbPrestamosCerrados.DataSource = lstPrestamosCerrados;
            
        }

        private void _btnActualizarListado_Click(object sender, EventArgs e)
        {
            CargarListadoPrestamosAbiertos();
        }

        private void _btnConsultarPrestamoAbierto_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(_cmbPrestamosAbiertos.SelectedValue);
            Prestamo prestamo = _videoClubNegocio.ConsultarPrestamoPorIdPrestamo(idPrestamo);
            if (prestamo != null)
            {
                _lblPrestamoAbierto.Text = prestamo.Display(true);

            }
            else
            {
                MessageBox.Show("No hay informacion del cliente prestamo seleccionado");
            }
        }

        private void _btnConsultarPrestamoCerrado_Click(object sender, EventArgs e)
        {
            int idPrestamo = Convert.ToInt32(_cmbPrestamosCerrados.SelectedValue);
            Prestamo prestamo = _videoClubNegocio.ConsultarPrestamoPorIdPrestamo(idPrestamo);
            if (prestamo != null)
            {
                _lblPrestamoCerrado.Text = prestamo.Display(false);
            }
            else
            {
                MessageBox.Show("No hay informacion del prestamo seleccionado");
            }
        }
    }

}

