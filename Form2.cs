using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestor_contraseñas
{
    public partial class Form2 : Form
    {
        private String tarea;
        public Form2()
        {
            this.KeyPreview = true;
            this.KeyDown += new KeyEventHandler(Form2_KeyDown);
            InitializeComponent();
        }

        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
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

    }
}
