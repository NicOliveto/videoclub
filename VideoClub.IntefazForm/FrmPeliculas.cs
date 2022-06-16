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
    public partial class FrmPeliculas : Form
    {

        private VideoClubNegocio _videoClubNegocio;
        public FrmPeliculas(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;


        }

        private void _btnMenuPrincipal2_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarPeliculas_Click(object sender, EventArgs e)
        {
            FrmIngresarPelicula frmIngresarPelicula = new FrmIngresarPelicula(this);
            frmIngresarPelicula.Show();
            this.Hide();

        }
    }
}
