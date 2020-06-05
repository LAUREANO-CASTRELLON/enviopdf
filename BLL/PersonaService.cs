using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using Infraestructura;
using Entity;

namespace BLL
{
    public class PersonaService
    {
        private readonly ConnectionManager conexion;
        private readonly PersonaRepository repositorio;
        Email email = new Email();
        public PersonaService(string connectionString)
        {
            conexion = new ConnectionManager(connectionString);
            repositorio = new PersonaRepository(conexion);
        }
        public string Guardar(Persona persona)
        {
            Email email = new Email();
            string mensajeEmail = string.Empty;
            try
            {
                persona.CalcularPulsacion();
                conexion.Open();
                repositorio.Guardar(persona);
                mensajeEmail = email.EnviarEmail(persona);
                return "SE GUARDO CORRECTAMENTE" + mensajeEmail;

            }
            catch (Exception ex)
            {

                return " ERROR EN LOS DATOS: " + ex.Message;
            }
            finally
            {
                conexion.Close();
            }
        }
        public string GuardarPDF(List<Persona> personas, string filename)
        {
            GenerarPDF generarPDF = new GenerarPDF();
            generarPDF.GuardarPDF(personas, filename);
            return "se genero el pdf en la ruta:" + filename;
        }
        public string EnviarReporte(string correo, string ruta)
        {
            try
            {
                string mensaje = email.EnviarEmailReporte(correo, ruta);
                return mensaje;
            }
            catch (Exception ex)
            {

                return $"Error al enviar el correo {ex.Message}";
            }
        }
        public ConsultaPersonaRespuesta ConsultarTodos()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Personas = repositorio.ConsultarTodos();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Personas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public ConsultaPersonaRespuesta ConsultarMujer()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Personas = repositorio.ConsultarMujer();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Personas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConsultaPersonaRespuesta ConsultarHombre()
        {
            ConsultaPersonaRespuesta respuesta = new ConsultaPersonaRespuesta();
            try
            {
                conexion.Open();
                respuesta.Personas = repositorio.ConsultarHombre();
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = (respuesta.Personas.Count > 0) ? "Se consultan los Datos" : "No hay datos para consultar";
                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public string Eliminar(string identificacion)
        {
            try
            {
                conexion.Open();
                var persona = repositorio.BuscarPorIdentificacion(identificacion);
                if (persona != null)
                {
                    repositorio.Eliminar(persona);
                    conexion.Close();
                    return ($"El registro {persona.Nombre} se ha eliminado satisfactoriamente.");
                }
                return ($"Lo sentimos, {identificacion} no se encuentra registrada.");
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public string Modificar(Persona personaNueva)
        {
            try
            {
                personaNueva.CalcularPulsacion();
                conexion.Open();
                var personaVieja = repositorio.BuscarPorIdentificacion(personaNueva.Identificacion);
                if (personaVieja != null)
                {
                    repositorio.Modificar(personaNueva);
                    return ($"El registro de {personaNueva.Nombre} se ha modificado satisfactoriamente.");
                }
                else
                {
                    return ($"Lo sentimos, la persona con Identificación {personaNueva.Identificacion} no se encuentra registrada.");
                }
            }
            catch (Exception e)
            {

                return $"Error de la Aplicación: {e.Message}";
            }
            finally { conexion.Close(); }

        }
        public BusquedaPersonaRespuesta BuscarxIdentificacion(string identificacion)
        {
            BusquedaPersonaRespuesta respuesta = new BusquedaPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Persona = repositorio.BuscarPorIdentificacion(identificacion);
                conexion.Close();
                respuesta.Mensaje = (respuesta.Persona != null) ? "Se encontró la Persona buscada" : "La persona buscada no existe";
                respuesta.Error = false;
                return respuesta;
            }
            catch (Exception e)
            {

                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }
        }
        public ConteoPersonaRespuesta Totalizar()
        {
            ConteoPersonaRespuesta respuesta = new ConteoPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.Totalizar(); ;
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }
        public ConteoPersonaRespuesta TotalizarTipo(string tipo)
        {
            ConteoPersonaRespuesta respuesta = new ConteoPersonaRespuesta();
            try
            {

                conexion.Open();
                respuesta.Cuenta = repositorio.TotalizarTipo(tipo);
                conexion.Close();
                respuesta.Error = false;
                respuesta.Mensaje = "Se consultan los Datos";

                return respuesta;
            }
            catch (Exception e)
            {
                respuesta.Mensaje = $"Error de la Aplicacion: {e.Message}";
                respuesta.Error = true;
                return respuesta;
            }
            finally { conexion.Close(); }

        }

    }

    public class ConsultaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public IList<Persona> Personas { get; set; }
    }


    public class BusquedaPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public Persona Persona { get; set; }
    }



    public class ConteoPersonaRespuesta
    {
        public bool Error { get; set; }
        public string Mensaje { get; set; }
        public int Cuenta { get; set; }
    }
}