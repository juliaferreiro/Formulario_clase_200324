namespace Formulario_clase_200324
{
    public partial class lblBienvenidos : Form
    {
        public lblBienvenidos()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            try
            {
                string texto = "hola " + textNombre.Text + " bienvenido";
                lblBIENVENIDO.Text = texto;
            }

            catch (Exception)
            {
                MessageBox.Show("Error");
            }
        }

        private void textNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void lblBienvenidos_Load(object sender, EventArgs e)
        {

        }
    }
}
