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
        private void FrmIngresarPrestamo_Load(object sender, EventArgs e)
        {
            CargarListadoClientes();
            CargarListadoPeliculas();
        }
        private void CargarListadoClientes()
        {
            List<Cliente> lstClientes = _videoClubNegocio.GetListClientes();
            _cmbClientes.DataSource = null;
            _cmbClientes.DataSource = lstClientes;
            _cmbClientes.DisplayMember = "ComboDisplay";
            _cmbClientes.ValueMember = "Id";
        }
        private void CargarListadoPeliculas()
        {
            List<Pelicula> lstPeliculas = _videoClubNegocio.GetListPeliculas();
            _cmbPeliculas.DataSource = null;
            _cmbPeliculas.DataSource = lstPeliculas;
            _cmbPeliculas.DisplayMember = "ComboDisplay";
            _cmbPeliculas.ValueMember = "Id";
        }

    }
}
