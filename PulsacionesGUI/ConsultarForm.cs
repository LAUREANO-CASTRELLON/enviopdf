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
    public partial class ConsultarForm : Form
    {
        PersonaService personaService;
        Persona persona;
        public ConsultarForm()
        {
            InitializeComponent();
            personaService = new PersonaService(ConfigConnection.connectionString);
        }
        public void Limpiar()
        {
            IdentificacioTxt.Text = "";
            NombreTxt.Text = "";
            EdadTxt.Text = "";
            SexoCmb.Text = "";
            PulsacionesTxt.Text = "";
            EmailTxt.Text = "";
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
        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            BusquedaPersonaRespuesta respuesta = new BusquedaPersonaRespuesta();
            string identificacion = IdentificacioTxt.Text;
            if (identificacion != "")
            {
                respuesta = personaService.BuscarxIdentificacion(identificacion);

                if (respuesta.Persona != null)
                {
                    NombreTxt.Text = respuesta.Persona.Nombre;
                    EdadTxt.Text = respuesta.Persona.Edad.ToString();
                    PulsacionesTxt.Text = respuesta.Persona.Pulsacion.ToString();
                    SexoCmb.Text = respuesta.Persona.Sexo;
                    PulsacionesTxt.Text = respuesta.Persona.Pulsacion.ToString();
                    EmailTxt.Text = respuesta.Persona.Email;
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

            }
            else
            {
                MessageBox.Show("Por favor digite una identificación", "Datos", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void BtnCalcularPulsacion_Click(object sender, EventArgs e)
        {
            Persona persona = MapearPersona();
            persona.CalcularPulsacion();
            PulsacionesTxt.Text = persona.Pulsacion.ToString();

        }

        private void ModificarBtn_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Está seguro de Modificar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                Persona persona = MapearPersona();
                string mensaje = personaService.Modificar(persona);
            }
            Limpiar();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            string identificacion = IdentificacioTxt.Text;
            if (identificacion != "")
            {
                var respuesta = MessageBox.Show("Está seguro de eliminar la información", "Mensaje de Eliminación", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (respuesta == DialogResult.Yes)
                {
                    string mensaje = personaService.Eliminar(identificacion);
                    MessageBox.Show(mensaje, "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Por favor digite la cedula de la persona a modificar y presione el boton buscar", "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void ConsultarForm_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
