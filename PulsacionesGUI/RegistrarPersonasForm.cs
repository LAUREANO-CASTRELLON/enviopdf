using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using Entity;

namespace PulsacionesGUI
{
    public partial class RegistrarPersonasForm : Form
    {
        PersonaService personaService;
        Persona persona;
        public RegistrarPersonasForm()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnection.connectionString);
        }
        private Persona MapearPersona()
        {
            persona = new Persona();
            persona.Identificacion = IdentificacioTxt.Text;
            persona.Nombre = NombreTxt.Text;
            persona.Edad = int.Parse(EdadTxt.Text);
            persona.Sexo = SexoCmb.Text;
            persona.Email = EmailTxt.Text;
            return persona;

        }
        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            string mensaje = personaService.Guardar(persona);
            MessageBox.Show(mensaje, "Mensaje de Guardado", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);
            Limpiar();
        }
        public void Limpiar()
        {
            IdentificacioTxt.Text = "";
            NombreTxt.Text = "";
            EdadTxt.Text = "";
            SexoCmb.Text = "";
            EmailTxt.Text = "";
            PulsacionesTxt.Text = "";
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}

