using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class AltaUsuario : Form
    {
        public AltaUsuario()
        {
            InitializeComponent();
            timer1.Enabled = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Responsable pUsuario = new Responsable();
            DateTime fecha = DateTime.Today;
            DateTime hora = DateTime.Now;
            //            DateTime hora = new DateTime(2008, 4, 10, 6, 30, 0);

            if (textoNombre.Text.Trim() != "" && textoPassword.Text.Trim() != "" && textoAlias.Text.Trim() != "")
            {
                pUsuario.Nombre = textoNombre.Text.Trim();
                pUsuario.Alias = textoAlias.Text.Trim();
                pUsuario.Password = textoPassword.Text.Trim();
                pUsuario.Puesto = comboPuesto.Text.Trim();
                pUsuario.Correo = txtCorreo.Text.Trim();
                int resultado = TablaUsuario.AgregarUsuario(pUsuario);

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

        private void button3_Click(object sender, EventArgs e)
        {
            DateTime fecha = DateTime.Today;
            MessageBox.Show(fecha.ToString("yyyy/MM/dd"));
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lblFecha.Text = DateTime.Now.ToString();
        }

        private void AltaUsuario_Load(object sender, EventArgs e)
        {

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

        private void txtCorreo_Validated(object sender, EventArgs e)
        {
            if (!EsCorreo(txtCorreo.Text))
            {
                error.SetError(txtCorreo, "debe ingresar un correo valido");
                //                textBox1.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }
    }
}
