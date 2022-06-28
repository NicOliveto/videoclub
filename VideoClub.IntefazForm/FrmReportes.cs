using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using VideoClub.Entidades;
using VideoClub.Negocio;

namespace VideoClub.IntefazForm
{
    public partial class FrmReportes : Form
    {
        private VideoClubNegocio _videoClubNegocio;
        public FrmReportes(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void FrmReportes_Load(object sender, EventArgs e)
        {
            CargarListadoClientes();
            CargarListadoPeliculas();
        }

        private void CargarListadoClientes()
        {
            List<Cliente> lstClientes = _videoClubNegocio.ConsultarClientes();
            _cmbPrestamoPorCliente.DisplayMember = "ComboDisplay";
            _cmbPrestamoPorCliente.ValueMember = "Id";
            _cmbPrestamoPorCliente.DataSource = null;
            _cmbPrestamoPorCliente.DataSource = lstClientes;
        }

        private void CargarListadoPeliculas()
        {
            List<Pelicula> lstPeliculas = _videoClubNegocio.ConsultarPeliculas();
            _cmbCopiasPorPelicula.DisplayMember = "ComboDisplay";
            _cmbCopiasPorPelicula.ValueMember = "Id";
            _cmbCopiasPorPelicula.DataSource = null;
            _cmbCopiasPorPelicula.DataSource = lstPeliculas;
        }

        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnPrestamosPorCliente_Click(object sender, EventArgs e)
        {
            try
            {
                int idCliente = Convert.ToInt32(_cmbPrestamoPorCliente.SelectedValue);
                List<Prestamo> prestamos = _videoClubNegocio.ConsultarPrestamosPorIdCliente(idCliente);

                if (prestamos.Count == 0)
                {
                    MessageBox.Show("El cliente seleccionado no posee prestamos.");
                }
                else
                {
                    _lstPrestamos.DataSource = null;
                    _lstPrestamos.DataSource = prestamos;
                }

                //LimpiarPrestamo();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void _btnCopiasPorPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                int idPelicula = Convert.ToInt32(_cmbCopiasPorPelicula.SelectedValue);
                List<Copia> copias = _videoClubNegocio.ConsultarCopiasPorIdPelicula(idPelicula);

                if (copias.Count == 0)
                {
                    MessageBox.Show("La película seleccionada no posee copias.");
                }
                else
                {
                    _lstCopias.DataSource = null;
                    _lstCopias.DataSource = copias;
                }

                //LimpiarCopia();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void _lstCopias_Click(object sender, EventArgs e)
        {
            try
            {
                Copia copia = (Copia)_lstCopias.SelectedValue;

                if (copia != null)
                {
                    _lblIdCopia.Text = copia.Id.ToString();
                    _lblPrecio.Text = copia.Precio.ToString();
                    _lblFechaAlta.Text = copia.FechaAlta.ToString();
                    _lblObservaciones.Text = copia.Observaciones;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void _lstPrestamos_Click(object sender, EventArgs e)
        {
            try
            {
                Prestamo prestamo = (Prestamo)_lstPrestamos.SelectedValue;

                if (prestamo != null)
                {
                    _lblIdCopiaPrestamo.Text = prestamo.IdCopia.ToString();
                    _lblFechaPrestamo.Text = prestamo.FechaPrestamo.ToString();
                    _lblFechaDevolucionReal.Text = prestamo.FechaDevolucionReal.ToString();
                    _lblFechaDevolucionTentativa.Text = prestamo.FechaDevolucionTentativa.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void LimpiarCopia()
        {
            _lblIdCopia.Text = string.Empty;
            _lblPrecio.Text = string.Empty;
            _lblFechaAlta.Text = string.Empty;
            _lblObservaciones.Text = string.Empty;
            _lstCopias.DataSource = null;
        }

        private void LimpiarPrestamo()
        {
            _lblIdCopiaPrestamo.Text = string.Empty;
            _lblFechaPrestamo.Text = string.Empty;
            _lblFechaDevolucionReal.Text = string.Empty;
            _lblFechaDevolucionTentativa.Text = string.Empty;
            _lstPrestamos.DataSource = null;
        }

        private void _cmbPrestamoPorCliente_SelectedValueChange(object sender, EventArgs e)
        {
            if (_cmbPrestamoPorCliente.SelectedIndex != -1)
                LimpiarPrestamo();
        }

        private void _cmbCopiasPorPelicula_SelectedValueChange(object sender, EventArgs e)
        {
            if (_cmbCopiasPorPelicula.SelectedIndex != -1)
                LimpiarCopia();
        }

        /*
        private void _btnPrestamosPorCliente_Click(object sender, EventArgs e)
        {
            int idCliente = Convert.ToInt32(_cmbPrestamoPorCliente.SelectedValue);
            List<Prestamo> prestamos = _videoClubNegocio.ConsultarPrestamosPorIdCliente(idCliente);

            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Title = "Save as .csv File";
            saveFileDialog.Filter = "csv files (*.csv)|*.csv";
            saveFileDialog.FilterIndex = 2;
            saveFileDialog.FileName = "prestamos_" + DateTime.Now.ToString("yyyyMMddHHmmss") + ".csv";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                if (saveFileDialog.FileName != "")
                {
                    StreamWriter csv = CrearCSV(prestamos, saveFileDialog.FileName);
                }
            }
        }

        private StreamWriter CrearCSV<T>(List<T> genericList, string strFilePath)
        {
            var info = typeof(T).GetProperties();
            var linea = new StringBuilder();
            var cabecera = "";
            StreamWriter csv = new StreamWriter(strFilePath, false);

            //headers 
            foreach (var prop in typeof(T).GetProperties())
            {
                cabecera += prop.Name + "; ";
            }
            cabecera = cabecera.Substring(0, cabecera.Length - 2);
            linea.AppendLine(cabecera);
            csv.Write(linea.ToString());
            linea.Clear();

            //body
            foreach (var obj in genericList)
            {
                var cuerpo = "";
                foreach (var prop in info)
                {
                    cuerpo += prop.GetValue(obj, null) + "; ";
                }
                cuerpo = cuerpo.Substring(0, cuerpo.Length - 2);
                linea.AppendLine(cuerpo);
                csv.Write(linea.ToString());
                linea.Clear();
            }

            csv.Close();

            return csv;
        }
        */
    }
}
