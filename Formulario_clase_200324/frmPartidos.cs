using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Formulario_clase_200324
{
    public partial class frmPartidos : Form
    {
        public frmPartidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtGanados.Text = string.Empty;
            txtEmpatados.Text = string.Empty;
            txtPerdidos.Text = string.Empty;
            txtGanados.Focus();


        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {

            int PG, PE;
            int PGT, PET;
            int pTotal;
            PG = int.Parse(txtGanados.Text);
            PE = int.Parse(txtEmpatados.Text);

            PGT = (PG * 3);
            PET = (PE * 2);
            pTotal = (PGT + PET);
            lblTotal.Text = "El resultado es " + pTotal.ToString();
        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
