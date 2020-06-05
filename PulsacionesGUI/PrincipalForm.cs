using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PulsacionesGUI
{
    public partial class PrincipalForm : Form
    {
        public PrincipalForm()
        {
            InitializeComponent();
        }

        private void registrarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void ingresarPersonaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistrarPersonasForm registrarPersonasForm = new RegistrarPersonasForm();
            registrarPersonasForm.Show();
        }

        private void consultarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultarForm consultarForm = new ConsultarForm();
            consultarForm.Show();
        }

        private void consultarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ConsultarTodo consultarTodo = new ConsultarTodo();
            consultarTodo.Show();
        }

        private void pulsacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}
