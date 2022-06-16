using System;
using System.Windows.Forms;
using VideoClub.Negocio;

namespace VideoClub.IntefazForm
{
    public partial class FrmPrestamos : Form
    {
        
        private VideoClubNegocio _videoClubNegocio;


        public FrmPrestamos(Form padre)
        {
            InitializeComponent();

            _videoClubNegocio = new VideoClubNegocio();

            this.Owner = padre;
        }

        private void _btnMenuPrincipal_Click(object sender, EventArgs e)
        {
            this.Owner.Show();
            this.Close();
        }

        private void _btnIngresarPrestamos_Click(object sender, EventArgs e)
        {
            FrmIngresarPrestamo frmIngresarPrestamo = new FrmIngresarPrestamo(this);
            frmIngresarPrestamo.Show();
            this.Hide();

        }
    }
    }

