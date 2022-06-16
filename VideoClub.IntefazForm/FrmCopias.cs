﻿using System;
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
    public partial class FrmCopias : Form
    {


        private VideoClubNegocio _videoClubNegocio;
        public FrmCopias(Form padre)
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

        private void _btnIngresarCopias_Click(object sender, EventArgs e)
        {
            FrmIngresarCopia frmIngresarCopia = new FrmIngresarCopia(this);
            frmIngresarCopia.Show();
            this.Hide();

        }
    }
}
