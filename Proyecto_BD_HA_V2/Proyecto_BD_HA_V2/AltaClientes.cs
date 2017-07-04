using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Text.RegularExpressions;

namespace Proyecto_BD_HA_V2
{
    public partial class AltaClientes : Form
    {
        public AltaClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Cliente pUsuario = new Cliente();
            if (textoNom.Text.Trim() != "" && textoApe.Text.Trim() != "" && textoDir.Text.Trim() != "" && textoTel.Text.Trim() != "" && textoEmail.Text.Trim() != "")
            {
                pUsuario.Nombre = textoNom.Text.Trim();
                pUsuario.Apellidos = textoApe.Text.Trim();
                pUsuario.Direccion = textoDir.Text.Trim();
                pUsuario.Telefono = textoTel.Text.Trim();
                pUsuario.Email = textoEmail.Text.Trim();
                int resultado = TablaCliente.AgregarCliente(pUsuario);

                if (resultado > 0)
                {
                    MessageBox.Show("Usuario Registrado");
                    Hide();
                }
                else
                {
                    MessageBox.Show("El Usuario ya existe");
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }
        }

        bool invalido = false;

        public bool EsCorreo(string email)
        {
            invalido = false;
            if (String.IsNullOrEmpty(email))
                return false;

            try
            {
                email = Regex.Replace(email, @"(@)(.+)$", this.DominioMapa, RegexOptions.None, TimeSpan.FromMilliseconds(200));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
            if (invalido)
                return false;

            try
            {
                return Regex.IsMatch(email, @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250));
            }
            catch (RegexMatchTimeoutException)
            {
                return false;
            }
        }

        private string DominioMapa(Match match)
        {
            IdnMapping idn = new IdnMapping();

            string dominioNombre = match.Groups[2].Value;
            try
            {
                dominioNombre = idn.GetAscii(dominioNombre);
            }
            catch (ArgumentException)
            {
                invalido = true;
            }
            return match.Groups[1].Value + dominioNombre;
        }

        private void textoEmail_Validated(object sender, EventArgs e)
        {
            if (!EsCorreo(textoEmail.Text))
            {
                error.SetError(textoEmail, "debe ingresar un correo valido");
                //                textBox1.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }
    }
}
