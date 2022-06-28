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
    public partial class FrmCopias : Form
    {
        private VideoClubNegocio _videoClubNegocio;

        public FrmCopias(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;          
        }

        private void FrmCopias_Load(object sender, EventArgs e)
        {
            // CargarListadoCopias();
            CargarListadoPeliculas();
        }
        private void CargarListadoPeliculas()
        {
            List<Pelicula> lstPeliculas = _videoClubNegocio.ConsultarPeliculas();
            _cmbPeliculas.DisplayMember = "ComboDisplay";
            _cmbPeliculas.ValueMember = "Id";
            _cmbPeliculas.DataSource = null;
            _cmbPeliculas.DataSource = lstPeliculas;
        }

        private void CargarListadoCopias(int idpelicula)
        {
            List<Copia> lstCopias = _videoClubNegocio.ConsultarCopiasDisponiblesPorIdPelicula(idpelicula);
            _cmbCopias.DataSource = null;
            _cmbCopias.DataSource = lstCopias;
            _cmbCopias.DisplayMember = "ComboDisplay";
            _cmbCopias.ValueMember = "Id";

            if (lstCopias.Count == 0)
            {
                _lblNoHayCopia.Text = "No hay copias de esta película";
            }
            else _lblNoHayCopia.Text = String.Empty;
                

        }
      

        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarCopias_Click(object sender, EventArgs e)
        {
            FrmIngresarCopia frmIngresarCopia = new FrmIngresarCopia(this);
            frmIngresarCopia.Show();
            this.Hide();
        }

        private void _btnActualizarListado_Click(object sender, EventArgs e)
        {
            if (_cmbPeliculas.SelectedIndex != -1)
            {
                CargarListadoCopias(Convert.ToInt32(_cmbPeliculas.SelectedValue));
            }
        }

        private void _btnConsultarCopias_Click(object sender, EventArgs e)
        {
            int idCopia = Convert.ToInt32(_cmbCopias.SelectedValue);
            Copia copia = _videoClubNegocio.ConsultarCopiaPorIdCopia(idCopia);

            if (copia != null)
            {
                _lblCopiaParaMostrar.Text = copia.ToString();
            }
            else
            {
                MessageBox.Show("No hay informacion de la copia seleccionada");
            }
        }

        private void _cmbPeliculas_SelectedValueChanged(object sender, EventArgs e)
        {                       
                if (_cmbPeliculas.SelectedIndex != -1)
                {
                    CargarListadoCopias(Convert.ToInt32(_cmbPeliculas.SelectedValue));
                }            
        }
    }
}
