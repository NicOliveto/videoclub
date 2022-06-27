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
    public partial class FrmIngresarCopia : Form
    {
        private VideoClubNegocio _videoClubNegocio;

        public FrmIngresarCopia(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void _btnVolver_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void FrmIngresarCopia_Load(object sender, EventArgs e)
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

        private void _btnConsultarCopias_Click(object sender, EventArgs e)
        {
            try
            {
                double precio = 0;
                if (Validador.ValidarPrecio(_txtPrecio.Text, out precio))
                {
                    DateTime fechaAlta = DateTime.Now;
                    int idpelicula = Convert.ToInt32(_cmbPeliculas.SelectedValue);
                    _videoClubNegocio.AltaCopia(idpelicula, _txtObservaciones.Text, precio, fechaAlta);

                    MessageBox.Show("Alta realizada correctamente");
                    _txtObservaciones.Text = string.Empty;
                    _txtPrecio.Text = string.Empty;
                }
                else
                {
                    _txtPrecio.BackColor = Color.Red;
                    MessageBox.Show("Complete correctamente los campos");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void _txtPrecio_TextChanged(object sender, EventArgs e)
        {
            if (_txtPrecio.BackColor != Color.White)
                _txtPrecio.BackColor = Color.White;
        }
    }
}
