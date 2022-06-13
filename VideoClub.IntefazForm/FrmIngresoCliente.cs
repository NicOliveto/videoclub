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
    public partial class FrmIngresoCliente : Form
    {
        private VideoClubNegocio _videoClubNegocio;
        public FrmIngresoCliente(Form padre)
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

      
    }
}
