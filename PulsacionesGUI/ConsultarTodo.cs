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
    public partial class ConsultarTodo : Form
    {
        PersonaService personaService;
        List<Persona> personas;
        public ConsultarTodo()
        {

            personaService = new PersonaService(ConfigConnection.connectionString);
            InitializeComponent();
            personas = new List<Persona>();
        }

        private void BuscarBtn_Click(object sender, EventArgs e)
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();

            string tipo = ConsultarCmb.Text;
            if (tipo == "Todos")
            {
                DtgPersona.DataSource = null;
                respuesta = personaService.ConsultarTodos();
                DtgPersona.DataSource = respuesta.Personas;
                TotalTxt.Text = personaService.Totalizar().Cuenta.ToString();
                TotalMujeresTxt.Text = personaService.TotalizarTipo("F").Cuenta.ToString();
                TotalHombreTxt.Text = personaService.TotalizarTipo("M").Cuenta.ToString();
                MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tipo == "Mujeres")
            {
                DtgPersona.DataSource = null;
                respuesta = personaService.ConsultarMujer();
                DtgPersona.DataSource = respuesta.Personas;
                TotalMujeresTxt.Text = personaService.TotalizarTipo("F").Cuenta.ToString();
                TotalTxt.Text = " ";
                TotalHombreTxt.Text = " ";
                MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            if (tipo == "Hombres")
            {
                DtgPersona.DataSource = null;
                respuesta = personaService.ConsultarHombre();
                DtgPersona.DataSource = respuesta.Personas;
                TotalHombreTxt.Text = personaService.TotalizarTipo("M").Cuenta.ToString();
                TotalTxt.Text = " ";
                TotalMujeresTxt.Text = " ";
                MessageBox.Show(respuesta.Mensaje, "Busqueda", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void NombreTxt_TextChanged(object sender, EventArgs e)
        {

        }
        private void DtgPersona_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void pedirRuta()
        {
            SaveFileDialog fileDialog = new SaveFileDialog();
            fileDialog.InitialDirectory = @"c:/Downloads";
            fileDialog.Title = "Guardar Reporte";
            fileDialog.DefaultExt = "pdf";
            fileDialog.Filter = "pdf files (*.pdf)|*.pdf| all files (*.*)|*.*";
            fileDialog.FilterIndex = 2;
            fileDialog.RestoreDirectory = true;
            string filename = string.Empty;
            personas = personaService.ConsultarTodos().Personas.ToList();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            { 
                filename = fileDialog.FileName;
            
            if (filename.Trim() !="" && personas.Count > 0)
            {
                    string mensaje = personaService.GuardarPDF(personas, filename);
                    MessageBox.Show(mensaje, "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                    MessageBox.Show("NO SE HA GUARDADO", "MENSAJE", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    
            }
            }
        }
        private void button1_Click(object sender, EventArgs e)
        {
            pedirRuta();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (!TxtCorreo.Text.Equals("") || !TxtAdjuntarArchivo.Equals(""))
            {
                string mensaje = personaService.EnviarReporte(TxtCorreo.Text, TxtAdjuntarArchivo.Text);
                MessageBox.Show(mensaje, "MENSAJE");
                TxtCorreo.Text = "";
                TxtAdjuntarArchivo.Text = "";
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OpenFileDialog FileDialog = new OpenFileDialog();
            string filename = string.Empty;
            FileDialog.RestoreDirectory = true;
            FileDialog.Filter = "Pdf Files| *.pdf";
            FileDialog.ShowDialog();
            if (!FileDialog.FileName.Equals(""))
            {
                filename = FileDialog.FileName;
                TxtAdjuntarArchivo.Text = filename;
            }
        }
    }
}
