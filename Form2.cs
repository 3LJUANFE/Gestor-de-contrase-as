using System.Windows.Forms;

namespace Gestor_contraseñas
{
    public partial class Form2 : Form
    {
        // Llamo la clase para gestionar las contraseñas
        Clases.GestionDeContraseñas gestionDeContraseñas = new Clases.GestionDeContraseñas();
        private String tarea;
        public Form2()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
            this.MouseDown += new MouseEventHandler(Form2_MouseDown);
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void Form2_MouseDown(object sender, MouseEventArgs e)
        {
            // Verificar si el clic fue fuera del ListBox
            if (!lbx1.ClientRectangle.Contains(lbx1.PointToClient(Cursor.Position)))
            {
                // Deseleccionar el ítem en el ListBox
                lbx1.ClearSelected();
            }
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrWhiteSpace(tbx1.Text))
            {
                MessageBox.Show("Por favor, ingresa una contraseña.");
                return;
            }
            else
            {
                tarea = tbx1.Text;
                lbx1.Items.Add(tarea);
                tbx1.Clear();
            }
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            if (lbx1.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, seleccione una contraseña");
                return;
            }
            else
            {
                lbx1.Items.RemoveAt(lbx1.SelectedIndex);
            }
        }

        private void guardarToolStripMenuItem_Click(object sender, EventArgs e)
        {

            //Aqui va la funcion de guardas las contraseñas
            gestionDeContraseñas.guardarContraseñas(lbx1);
        }

        private void gargarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ;
            List<string> items = gestionDeContraseñas.cargarContraseñas();

            lbx1.Items.Clear();

            foreach (var item in items)
            {
                lbx1.Items.Add(item);
            }
        }
    }
}
