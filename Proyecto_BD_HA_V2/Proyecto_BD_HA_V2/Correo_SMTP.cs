using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Net; /* Libreria que contiene clases
que proporcionan una interfaz de programación sencillo
para una serie de protocolos de red*/
using System.Net.Mail; /* Libreria para implementar
las clases del protocolo de correo (SMTP)*/
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2 // Nombre de la paquetería (workspace)
{
    class Correo_SMTP // Nombre de la clase.
    {
        MailMessage correos = new MailMessage(); // Representa un mensaje de correo electrónico que puede enviarse mediante la clase SmtpClient.
                                                 // Sirve para especificar las caracteristicas que tiene un correo convencional.
        SmtpClient envios = new SmtpClient(); // Permite a las aplicaciones enviar correo electrónico mediante el protocolo Simple de transferencia de correo (SMTP).

        public void enviarCorreo(string emisor, string password, string mensaje, string asunto, string destinatario, string ruta, string servidor)
        // Recibiremos los parametros donde esta la pantalla Pantalla_Enviar
        {
            try // Se usa principalmente para evitar errores en caso de que haya una anomalía al enviar el correo.
            {
                correos.To.Clear(); // Aqui borraremos en el buffer el destinatario para recibir mas correos del cliente
                correos.Body = ""; // Aqui inicializamos el cuerpo del correo electrónico
                correos.Subject = ""; // Aqui inicializamos el asunto del correo electrónico
                correos.Body = mensaje; // Aqui cargaremos en el buffer el mensaje de que recibimos en el parametro.
                correos.Subject = asunto;// Aqui cargaremos en el buffer el asunto de que recibimos en el parametro.
                correos.IsBodyHtml = true; // Aqui se hace una validacion de que si en la pagina web que recibira el correo esté construido en HTML
                correos.To.Add(destinatario.Trim()); // Aqui cargaremos en el buffer el destinatario del correo lo cual recibimos en el parametro

                if (ruta.Equals("") == false) // Condicion de que si se enviará un archivo
                {
                    System.Net.Mail.Attachment archivo = new System.Net.Mail.Attachment(ruta); // Aqui crearemos un objeto lo cual almacenara el archivo que vamos a enviar
                    correos.Attachments.Add(archivo); // Aqui se cargará el archivo.
                }

                correos.From = new MailAddress(emisor); // Aqui cargaremos de quien está enviando el correo.
                envios.Credentials = new NetworkCredential(emisor, password); // Aqui se cargara el emisor con su contraseña para darle privilegio de enviar correo.

                //Aqui no se debe de modificar, ya que en esa sección se hará la conexion a un servidor (en este caso Gmail)
                switch (servidor)
                {
                    case "Gmail":
                        envios.Host = "smtp.gmail.com"; // Aqui definimos el servidor con lo cual nos conectaremos para enviar correo
                        break;
                    case "Hotmail":
                        envios.Host = "smtp.live.com"; // Aqui definimos el servidor con lo cual nos conectaremos para enviar correo
                        break;
                    case "Yahoo":
                        envios.Host = "smtp.mail.yahoo.com"; // Aqui definimos el servidor con lo cual nos conectaremos para enviar correo
                        break;
                }
                envios.Port = 587; // Aqui definimos el puerto que se usa para enviar correo. Puerto usado para soporte de conexiones no encriptadas
                envios.EnableSsl = true; // Aqui se cifra los datos del correo.
                envios.Send(correos); // Aqui se enviará todo lo que cargamos en el objeto de correos que estabamos definiendo
                MessageBox.Show("El mensaje fue enviado correctamente"); // Mensaje de confirmación
                correos.Attachments.Clear(); // Aqui se limpiara en el buffer los correos
            }
            catch (Exception ex) // En caso de que tire error
            {
                MessageBox.Show(ex.Message, "No se envio el correo correctamente", MessageBoxButtons.OK, MessageBoxIcon.Error); // Mensaje de que no se envío el correo
            }
        }
    }
}
