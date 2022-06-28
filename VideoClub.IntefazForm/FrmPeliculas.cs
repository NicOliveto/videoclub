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
    public partial class FrmPeliculas : Form
    {

        private VideoClubNegocio _videoClubNegocio;
        public FrmPeliculas(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;


        }

        private void _btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarPeliculas_Click(object sender, EventArgs e)
        {
            FrmIngresarPelicula frmIngresarPelicula = new FrmIngresarPelicula(this);
            frmIngresarPelicula.Show();
            this.Hide();
        }

        private void _btnActualizarListado_Click(object sender, EventArgs e)
        {
            CargarListadoPeliculas();
            _lblPeliculaParaMostrar.Text = String.Empty;
        }

        private void FrmPeliculas_Load(object sender, EventArgs e)
        {
            CargarListadoPeliculas();
        }

        private void CargarListadoPeliculas()
        {
            List<Pelicula> lstPeliculas = _videoClubNegocio.ConsultarPeliculas();
            _cmbPeliculas.DataSource = null;
            _cmbPeliculas.DataSource = lstPeliculas;
            _cmbPeliculas.DisplayMember = "ComboDisplay";
            _cmbPeliculas.ValueMember = "Id";
        }

        private void _btnConsultarPeliculas_Click(object sender, EventArgs e)
        {
            int idPelicula = Convert.ToInt32(_cmbPeliculas.SelectedValue);
            Pelicula pelicula = _videoClubNegocio.ConsultarPeliculaPorIdPelicula(idPelicula);

            if (pelicula != null)
            {
                _lblPeliculaParaMostrar.Text = pelicula.ToString();

            }
            else
            {
                MessageBox.Show("No hay informacion de la pelicula seleccionada");
            }
        }
    }
}
