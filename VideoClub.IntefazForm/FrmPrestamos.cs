using System;
using System.Collections.Generic;
using System.Windows.Forms;
using VideoClub.Entidades;
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

        private void FrmPrestamos_Load(object sender, EventArgs e)
        {
            CargarListado();

        }

        private void CargarListado()
        {
            List<Prestamo> lstPrestamosAbiertos = _videoClubNegocio.GetListPrestamosAbiertos();
            _cmbPrestamosAbiertos.DataSource = null;
            _cmbPrestamosAbiertos.DataSource = lstPrestamosAbiertos;
            _cmbPrestamosAbiertos.DisplayMember = "ComboDisplay";
            _cmbPrestamosAbiertos.ValueMember = "Id";

        }




    }
}

