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
    public partial class frmPreguntas : Form
    {
        public frmPreguntas()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            int RC, RI, RB;
            int RCT, RIT, RBT;
            int Total;
            RC = int.Parse(txtCorrectas.Text);
            RI = int.Parse(txtIncorrectas.Text);
            RB = int.Parse(txtBlanco.Text);

            RCT = (RC * 4);
            RIT = (RI * -1);
            RBT = (RB * 0);
            Total = (RCT + RIT + RBT);
            lblTotal.Text = "El resultado es " + Total.ToString();

        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            txtCorrectas.Text = string.Empty;
            txtIncorrectas.Text = string.Empty;
            txtBlanco.Text = string.Empty;
            txtCorrectas.Focus();
        }

        private void txtIncorrectas_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
