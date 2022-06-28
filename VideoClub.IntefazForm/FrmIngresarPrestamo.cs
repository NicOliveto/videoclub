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
                if (Validador.ValidarStringNumerico(_tbPlazo.Text))
                {
                    int plazo = Convert.ToInt32(_tbPlazo.Text);
                    int idCliente = Convert.ToInt32(_cmbClientes.SelectedValue);
                    int idCopia = Convert.ToInt32(_cmbCopias.SelectedValue);
                    DateTime fechaPrestamo = DateTime.Now;
                    DateTime fechaDevTentativa = fechaPrestamo.AddDays(plazo);
                    DateTime fechaDevReal = fechaPrestamo.AddDays(plazo);
                    if (idCopia == 0)
                    {
                        MessageBox.Show("Seleccione una copia");
                    } else
                    {
                        _videoClubNegocio.AltaPrestamo(idCliente, idCopia, plazo, true, fechaPrestamo,
                            fechaDevTentativa, fechaDevReal);

                        MessageBox.Show("Alta realizada correctamente");
                        _tbPlazo.Text = string.Empty;

                        CargarListadoCopias(Convert.ToInt32(_cmbPeliculas.SelectedValue));

                    }

                }
                else 
                {
                    _tbPlazo.BackColor = Color.Red;
                    MessageBox.Show("Complete el campo plazo correctamente"); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void FrmIngresarPrestamo_Load(object sender, EventArgs e)
        {
            CargarListadoClientes();
            CargarListadoPeliculas();            
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
                _lblMessage.Text = "No hay copias disponibles para alquilar de la pelicula seleccionada";
        }

        private void _cmbPeliculas_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_cmbPeliculas.SelectedIndex != -1)
            {
                _lblMessage.Text = string.Empty;
                CargarListadoCopias(Convert.ToInt32(_cmbPeliculas.SelectedValue));
            }
        }

        private void _tbPlazo_TextChanged(object sender, EventArgs e)
        {
            if(_tbPlazo.BackColor != Color.White)
                _tbPlazo.BackColor = Color.White;
        }

        private void _cmbCopias_SelectedValueChanged(object sender, EventArgs e)
        {
            if (_cmbCopias.SelectedIndex != -1)               
            {
                _cmbCopias.DisplayMember = "ComboDisplay";
                _cmbCopias.ValueMember = "Id";
                Copia copia = _videoClubNegocio.ConsultarCopiaPorIdCopia(Convert.ToInt32(_cmbCopias.SelectedValue));                
                _lblPrecioCopia.Text = copia.Precio.ToString();
            }
        }
    }
}
