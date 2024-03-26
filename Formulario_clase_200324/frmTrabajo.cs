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
    public partial class frmTrabajo : Form
    {
        public frmTrabajo()
        {
            InitializeComponent();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            double Horas, Tarifa;
            double Total;
            Horas = double.Parse(txtHoras.Text);
            Tarifa = double.Parse(txtTarifa.Text);

            Total = (Horas * Tarifa);
            lblTotal.Text = "Tu sueldo es " + Total.ToString();
        }
    }
}
