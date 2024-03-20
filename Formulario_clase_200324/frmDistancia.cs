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
    public partial class frmDistancia : Form
    {
        public frmDistancia()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int v, t;
            float D;
            v = int.Parse(txtVelocidad.Text);
            t = int.Parse(txtVelocidad.Text);
            D = v * t;
            lblResultado.Text = D.ToString();
        }

        private void lblResultado_Click(object sender, EventArgs e)
        {

        }
    }
}
