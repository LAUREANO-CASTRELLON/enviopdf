using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Mail;
using Entity;

namespace Infraestructura
{
    public class Email
    {
        private MailMessage email;
        private SmtpClient Smtp;
        public Email()
        {
            Smtp = new SmtpClient();
        }
        private void ConfigurarSmt()
        {
            Smtp.Host = "smtp.gmail.com";
            Smtp.Port = 587;
            Smtp.EnableSsl = true;
            Smtp.UseDefaultCredentials = false;
            Smtp.Credentials = new System.Net.NetworkCredential("lcastrellonperez@gmail.com", "lauflo05");
        }
        private void ConfigurarEmail(Persona persona)
        {
            email = new MailMessage();
            email.To.Add(persona.Email);
            email.From = new MailAddress("lcastrellonperez@gmail.com");
            email.Subject = " Laureano Esteban Castrellon Perez Registro De Usuario" + DateTime.Now.ToString("dd/MMM/yyy hh:mm:ss");
            string Reporte = "Nombre :" + persona.Nombre + "<br/>" + "Edad:" + persona.Edad.ToString() + "<br/>" + "Sexo:" + persona.Sexo.ToString() + "Idenficiacion:" + persona.Identificacion.ToString() + "pulsaciones:" + persona.Pulsacion.ToString();
            email.Body = Reporte;
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }
        public string EnviarEmail(Persona persona)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmail(persona);
                Smtp.Send(email);
                return (" Correo Enviado");
            }
            catch (Exception e)
            {
                return ("Corro no Enviado " + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        public string EnviarEmailReporte(string correo, string ruta)
        {
            try
            {
                ConfigurarSmt();
                ConfigurarEmailReporte(correo, ruta);
                Smtp.Send(email);
                return ("correo enviado correctamente");
            }
            catch (Exception e)
            {
                return ("Corro no Enviado " + e.Message);
            }
            finally
            {
                email.Dispose();
            }
        }

        private void ConfigurarEmailReporte(string correo, string ruta)
        {
            email = new MailMessage();
            email.To.Add(correo);
            email.From = new MailAddress(correo);
            email.Subject = "registro de usuario" +
                DateTime.Now.ToString("dd/MMM/YY hh:mm:ss");
            email.Body = $"<b>Sr {correo}</b> <br" +
                $"> ENVIO DE REPORTE";
            System.Net.Mail.Attachment adjunto = new System.Net.Mail.Attachment(ruta);
            email.Attachments.Add(adjunto);
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;
        }

    }
}
