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
                        

            if (!(Validador.ValidarString(_txtApellido.Text))) 
            {
                esValido = false;
                _txtApellido.BackColor = Color.Red;
            } 

            if (!(Validador.ValidarDni(_txtDNI.Text)))
            {
                esValido = false;
                _txtDNI.BackColor = Color.Red;
            } 

            if (!(Validador.ValidarStringEspecial(_txtMail.Text)))
            {
                esValido = false;
                _txtMail.BackColor = Color.Red;
            } 
                           
            if (!(Validador.ValidarStringEspecial(_txtDireccion.Text)))
            {
                esValido = false;
                _txtDireccion.BackColor = Color.Red;

            } 
                
            if (!(Validador.ValidarStringNumerico(_txtTelefono.Text)))
            {
                esValido = false;
                _txtTelefono.BackColor = Color.Red;

            } 

            if (!(Validador.ValidarFecha(_txtFechaNac.Text, out fechaValidada)))
            {
                esValido = false;
                _txtFechaNac.BackColor = Color.Red;

            } 

            return esValido;
        }

        private void _txtNombre_TextChanged(object sender, EventArgs e)
        {
            if (_txtNombre.BackColor != Color.White)
                _txtNombre.BackColor = Color.White;
        }

        private void _txtApellido_TextChanged(object sender, EventArgs e)
        {
            if (_txtApellido.BackColor != Color.White)
                _txtApellido.BackColor = Color.White;
        }

        private void _txtDireccion_TextChanged(object sender, EventArgs e)
        {
            if (_txtDireccion.BackColor != Color.White)
                _txtDireccion.BackColor= Color.White;

        }

        private void _txtDNI_TextChanged(object sender, EventArgs e)
        {
            if (_txtDNI.BackColor != Color.White)
                _txtDNI.BackColor = Color.White;

        }

        private void _txtTelefono_TextChanged(object sender, EventArgs e)
        {
            if (_txtTelefono.BackColor != Color.White)
                _txtTelefono.BackColor = Color.White;
        }

        private void _txtMail_TextChanged(object sender, EventArgs e)
        {
            if (_txtMail.BackColor != Color.White)
                _txtMail.BackColor = Color.White;

        }

        private void _txtFechaNac_TextChanged(object sender, EventArgs e)
        {
            if (_txtFechaNac.BackColor != Color.White)
                _txtFechaNac.BackColor = Color.White;
        }
    }
}
