namespace Gestor_contraseñas
{
    public partial class Form1 : Form
    {
        private string pass = "1243";
        public Form1()
        {
            InitializeComponent();
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (pass == tbx1.Text)
            {
                MessageBox.Show("La clave es correcta");
            }
            
            else
            {
                MessageBox.Show("La clave es incorrecta");
            }
        }

        private void checkOcultar_CheckedChanged(object sender, EventArgs e)
        {
            if (checkOcultar.Checked)
            {
                tbx1.PasswordChar = '\0';
            }
            else
            {
                tbx1.PasswordChar = '*';
            }
        }
    }
}
