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
    public partial class FrmIngresarPrestamo : Form
    {
        private VideoClubNegocio _videoClubNegocio;

        public FrmIngresarPrestamo(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void _btnVolverPrestamo_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnAltaPrestamo_click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(_cmbClientes.SelectedValue);
                int idCopia = Convert.ToInt32(_cmbCopias.SelectedValue);
                int plazo = Convert.ToInt32(_lblPlazoPrestamo.Text);
                DateTime fechaPrestamo = DateTime.Now;
                DateTime fechaDevTentativa = fechaPrestamo.AddDays(plazo);
                DateTime fechaDevReal = fechaPrestamo.AddDays(plazo);

                _videoClubNegocio.AltaPrestamo(idCliente, idCopia, plazo, true, fechaPrestamo, 
                    fechaDevTentativa, fechaDevReal);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void FrmIngresarPrestamo_Load(object sender, EventArgs e)
        {
            CargarListadoClientes();
            CargarListadoPeliculas();
            CargarListadoCopias(Convert.ToInt32(_cmbPeliculas.SelectedValue));
        }

        private void CargarListadoClientes()
        {
            List<Cliente> lstClientes = _videoClubNegocio.ConsultarClientes();
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";
        }

        private void CargarListadoPeliculas()
        {
            List<Pelicula> lstPeliculas = _videoClubNegocio.ConsultarPeliculas();
            _cmbPeliculas.DataSource = null;
            _cmbPeliculas.DataSource = lstPeliculas;
            _cmbPeliculas.DisplayMember = "ComboDisplay";
            _cmbPeliculas.ValueMember = "Id";
        }

        private void CargarListadoCopias(int idpelicula)
        {
            List<Copia> lstCopias = _videoClubNegocio.ConsultarCopiasPorIdPelicula(idpelicula);
            _cmbCopias.DataSource = null;
            _cmbCopias.DataSource = lstCopias;
            _cmbCopias.DisplayMember = "ComboDisplay";
            _cmbCopias.ValueMember = "Id";
        }
    }
}
