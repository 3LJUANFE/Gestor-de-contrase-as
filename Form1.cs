using Microsoft.Extensions.Configuration;

namespace Gestor_contraseñas
{
    public partial class Form1 : Form
    {
        private int errores = 0;
        Clases.ConfiguracionProteccion configuracionProteccion = new Clases.ConfiguracionProteccion();  

        public Form1()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form1_KeyDown);
            InitializeComponent();
        }

        public void abrirForm2()
        {
            var configuration = configuracionProteccion.configuration();
            string pass = configuration["EncryptionSettings:SecretPass"];
            if (pass == tbx1.Text)
            {
                MessageBox.Show("La clave es correcta");
                Form2 form2 = new Form2();
                this.Hide();
                form2.Show();
                form2.FormClosed += (s, args) => Application.Exit();
            }

            else
            {
                MessageBox.Show("La clave es incorrecta");
                errores += 1;
                if (errores == 3)
                {
                    MessageBox.Show("Demasiados intengots fallidos");
                    this.Close();
                }
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            // Verifica si se presionó la tecla Enter
            if (e.KeyCode == Keys.Enter)
            {
                // Llama a un método o realiza la acción que desees
                abrirForm2();
            }

            // Verifica si se presionó la tecla Esc para cerrar el formulario, por ejemplo
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            abrirForm2();
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
