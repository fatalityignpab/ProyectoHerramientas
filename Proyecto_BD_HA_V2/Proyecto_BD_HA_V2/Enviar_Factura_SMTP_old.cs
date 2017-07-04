using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_HA_V2
{
    class Enviar_Factura_SMTP_old
    {
        public void MetodoProtocolo()
        {
            MailMessage email = new MailMessage();
            email.To.Add(new MailAddress("ignaciopabloro2@gmail.com"));
            email.From = new MailAddress("ignaciopabloro2@gmail.com");
            email.Subject = "Asunto ( " + DateTime.Now.ToString("dd / MMM / yyy hh:mm:ss") + " ) ";
            email.Body = "Cualquier contenido en <b>HTML</b> para enviarlo por correo electrónico.";
            email.IsBodyHtml = true;
            email.Priority = MailPriority.Normal;

            SmtpClient smtp = new SmtpClient();
            smtp.Host = "smtp.gmail.com"; // Servira para enviar hacia el servidor SMTP de Google
            smtp.Port = 2525;
            smtp.EnableSsl = false;
            smtp.UseDefaultCredentials = false;
            smtp.Credentials = new NetworkCredential("email_from@example.com", "contraseña");

            string output = null;

            try
            {
                smtp.Send(email);
                email.Dispose();
                output = "Corre electrónico fue enviado satisfactoriamente.";
            }
            catch (Exception ex)
            {
                output = "Error enviando correo electrónico: " + ex.Message;
            }

            Console.WriteLine(output);
        }
    }
}
