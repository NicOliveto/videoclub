using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoClub.Negocio;

namespace VideoClub.IntefazForm
{
    public partial class FrmIngresarPelicula : Form
    {


        private VideoClubNegocio _videoClubNegocio;
        public FrmIngresarPelicula(Form padre)
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

        private void _btnAltaPelicula_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatosValidos())
                {
                    _videoClubNegocio.AltaPelicula(Auxiliar.ConvertirAInteger(_txtAnio.Text), Auxiliar.ConvertirAInteger(_txtDuracion.Text), _txtTitulo.Text, _txtDirector.Text, _txtProductora.Text, _txtGenero.Text);
                    MessageBox.Show("Alta realizada correctamente");
                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Complete correctamente los campos");
                }
            }
            catch (Exception ex)
            {

              MessageBox.Show(ex.Message);
            }
        }

        private void Limpiar()
        {
            _txtTitulo.Text = String.Empty;
            _txtProductora.Text = String.Empty;
            _txtGenero.Text = String.Empty;
            _txtDuracion.Text = String.Empty;   
            _txtAnio.Text = String.Empty;
            _txtDirector.Text = String.Empty;

        }

        private bool DatosValidos()
        {
            bool esValido = true;
            int duracionMinimaPelicula = 10;
            int duracionMaximaPelicula = 300;
            int anioMinimoPelicula = 1810;

            if (!(Validador.ValidarStringEspecial(_txtTitulo.Text)))
            {
                esValido = false;
                _txtTitulo.BackColor = Color.Red;
            } 

            if (!(Validador.ValidarString(_txtProductora.Text)))
            {
                esValido = false;
                _txtProductora.BackColor = Color.Red;
            } 

            if (!(Validador.ValidarString(_txtGenero.Text)))
            {
                esValido = false;
                _txtGenero.BackColor = Color.Red;
            } 

            if (!(Validador.ValidarStringNumericoMinMax(_txtDuracion.Text,duracionMinimaPelicula,duracionMaximaPelicula)))
            {
                esValido=false;
                _txtDuracion.BackColor = Color.Red;
            } 

           if (!(Validador.ValidarStringNumericoMinMax(_txtAnio.Text, anioMinimoPelicula, DateTime.Now.Year)))
            {   
                esValido = false;
                _txtAnio.BackColor = Color.Red;
            } 

           if (!(Validador.ValidarString(_txtDirector.Text)))
            {
                esValido = false;
                _txtDirector.BackColor = Color.Red;
            } 
                               


            return esValido;
        }

        private void _txtTitulo_TextChanged(object sender, EventArgs e)
        {
            if (_txtTitulo.BackColor != Color.White)
                _txtTitulo.BackColor = Color.White;

        }

        private void _txtDirector_TextChanged(object sender, EventArgs e)
        {
            if (_txtDirector.BackColor != Color.White)
                _txtDirector.BackColor = Color.White;
        }

        private void _txtAnio_TextChanged(object sender, EventArgs e)
        {
            if (_txtAnio.BackColor != Color.White)
                _txtAnio.BackColor = Color.White;
        }

        private void _txtDuracion_TextChanged(object sender, EventArgs e)
        {
            if (_txtDuracion.BackColor != Color.White)
                _txtDuracion.BackColor = Color.White;

        }

        private void _txtProductora_TextChanged(object sender, EventArgs e)
        {
            if (_txtProductora.BackColor != Color.White)
                _txtProductora.BackColor = Color.White;

        }

        private void _txtGenero_TextChanged(object sender, EventArgs e)
        {
            if (_txtGenero.BackColor != Color.White)
                _txtGenero.BackColor = Color.White;
        }
    }

}