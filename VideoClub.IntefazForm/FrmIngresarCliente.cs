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
                DateTime fechaValida;
                if (DatosValidos(out fechaValida))
                {
                    _videoClubNegocio.AltaCliente(_txtNombre.Text, _txtApellido.Text, Auxiliar.ConvertirDNI(_txtDNI.Text), _txtMail.Text, _txtDireccion.Text, _txtTelefono.Text, fechaValida);
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

        private bool DatosValidos(out DateTime fechaValidada)
        {
            bool esValido = true;

            if (!(Validador.ValidarString(_txtNombre.Text)))
            {
                esValido = false;
                _txtNombre.BackColor = Color.Red;
            }
            else _txtNombre.BackColor = Color.White;               

            if (!(Validador.ValidarString(_txtApellido.Text))) 
            {
                esValido = false;
                _txtApellido.BackColor = Color.Red;
            } else _txtApellido.BackColor = Color.White;

            if (!(Validador.ValidarDni(_txtDNI.Text)))
            {
                esValido = false;
                _txtDNI.BackColor = Color.Red;
            } else _txtDNI.BackColor = Color.White;

            if (!(Validador.ValidarStringEspecial(_txtMail.Text)))
            {
                esValido = false;
                _txtMail.BackColor = Color.Red;
            } else _txtMail.BackColor = Color.White;
                           
            if (!(Validador.ValidarStringEspecial(_txtDireccion.Text)))
            {
                esValido = false;
                _txtDireccion.BackColor = Color.Red;

            } else _txtDireccion.BackColor = Color.White;
                
            if (!(Validador.ValidarStringNumerico(_txtTelefono.Text)))
            {
                esValido = false;
                _txtTelefono.BackColor = Color.Red;

            } else _txtTelefono.BackColor= Color.White;

            if (!(Validador.ValidarFecha(_txtFechaNac.Text, out fechaValidada)))
            {
                esValido = false;
                _txtFechaNac.BackColor = Color.Red;

            } else _txtFechaNac.BackColor = Color.White;

            return esValido;
        }       
    }
}
