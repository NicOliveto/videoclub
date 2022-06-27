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
    public partial class FrmIngresarCliente : Form
    {
        private VideoClubNegocio _videoClubNegocio;
        public FrmIngresarCliente(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void _btnVolverClientes_Click(object sender, EventArgs e)
        {
            this.Owner.Show();            
            this.Close();
        }

        private void _btnAltaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                if (DatosValidos())
                {
                    _videoClubNegocio.AltaCliente(_txtNombre.Text, _txtApellido.Text, 1122335544/*_txtDNI*/, _txtMail.Text, _txtDireccion.Text, _txtTelefono.Text, /*_txtFechaNac*/DateTime.Now.AddDays(-5000));

                    Limpiar();
                }
                else
                {
                    MessageBox.Show("Complete correctamente los campos");
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void Limpiar()
        {
            _txtApellido.Text = string.Empty;
            _txtNombre.Text = string.Empty;
            _txtDNI.Text = string.Empty;
            _txtMail.Text = string.Empty;
            _txtDireccion.Text = string.Empty;
            _txtTelefono.Text = string.Empty;
            _txtFechaNac.Text = string.Empty;
        }

        private bool DatosValidos()
        {
            if (!(Validador.ValidarString(_txtNombre.Text)))
                return false;

            if (!(Validador.ValidarString(_txtApellido.Text)))
                return false;

            //if (!(Validador VALIDAR DNI!!!) ) !!!!!!!!!!!
            //    return false;

            if (!(Validador.ValidarStringEspecial(_txtMail.Text)))
               return false;
            
            if (!(Validador.ValidarStringEspecial(_txtDireccion.Text)))
                return false;

            if (!(Validador.ValidarStringNumerico(_txtTelefono.Text)))
                return false;

            //if (VALIDAR FECHA NACIMIENTO)     !!!!!!!!

            return true;
        }
    }
}
