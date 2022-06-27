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
            }// else true


            //if (!(Validador.ValidarString(_txtNombre.Text)))
            //{
            //    esValido = false;
            //    _txtNombre.BackColor = Color.Red;
            //}
            //else _txtNombre.BackColor = Color.White;



            return esValido;
        }



    }

}