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
                    _videoClubNegocio.AltaPelicula(Auxiliar.ConvertirAInteger(_txtAnio.Text), Auxiliar.ConvertirAInteger(_txtDuracion.Text), _txtTitulo.Text, _txtDirector.Text, _txtProductora.Text, _txtGenero.Text, 881188);
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

            if (!(Validador.ValidarStringEspecial(_txtTitulo.Text)))
            {
                esValido = false;
                _txtTitulo.BackColor = Color.Red;
            } else _txtTitulo.BackColor = Color.White;

            if (!(Validador.ValidarString(_txtProductora.Text)))
            {
                esValido = false;
                _txtProductora.BackColor = Color.Red;
            } else _txtProductora.BackColor = Color.White;

            if (!(Validador.ValidarString(_txtGenero.Text)))
            {
                esValido = false;
                _txtGenero.BackColor = Color.Red;
            } else _txtGenero.BackColor = Color.White;

            if (!(Validador.ValidarStringNumericoMinMax(_txtDuracion.Text,10, 300)))
            {
                esValido=false;
                _txtDuracion.BackColor = Color.Red;
            } else _txtDuracion.BackColor= Color.White;

           if (!(Validador.ValidarStringNumericoMinMax(_txtAnio.Text, 1850, DateTime.Now.Year)))
            {   
                esValido = false;
                _txtAnio.BackColor = Color.Red;
            } else _txtAnio.BackColor = Color.White;

           if (!(Validador.ValidarString(_txtDirector.Text)))
            {
                esValido = false;
                _txtDirector.BackColor = Color.Red;
            } else _txtDirector.BackColor = Color.White;
                               


            return esValido;
        }



    }

}