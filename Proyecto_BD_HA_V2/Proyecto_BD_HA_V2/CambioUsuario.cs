using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_BD_HA_V2
{
    public partial class CambioUsuario : Form
    {
        public CambioUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Responsable ProductoActual { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            CambioUsuarioActual cam = new CambioUsuarioActual();
            cam.ShowDialog();

            if (cam.ProductoSelect != null)
            {
                ProductoActual = cam.ProductoSelect;
                textoNombre.Text = cam.ProductoSelect.Nombre;
                textoAlias.Text = cam.ProductoSelect.Alias;
                textoPassword.Text = cam.ProductoSelect.Password;
                comboPuesto.Text = cam.ProductoSelect.Puesto;
                txtCorreo.Text = cam.ProductoSelect.Correo;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textoNombre.Text.Trim() != "" && textoPassword.Text.Trim() != "" && textoAlias.Text.Trim() != "" && comboPuesto.Text.Trim() != "" && txtCorreo.Text.Trim() != "")
            {
                Responsable pResponsable = new Responsable();
                pResponsable.Nombre = textoNombre.Text.Trim();
                pResponsable.Alias = textoAlias.Text.Trim();
                pResponsable.Password = textoPassword.Text.Trim();
                pResponsable.Puesto = comboPuesto.Text.Trim();
                pResponsable.idResponsable = ProductoActual.idResponsable;
                pResponsable.Correo = txtCorreo.Text.Trim();

                if (TablaUsuario.Actualizar(pResponsable) > 0)
                {
                    MessageBox.Show("Cambio Realizado");
                    Hide();
                }
                else
                {
                    MessageBox.Show("El número ingresado no esta registrado");
                    Hide();
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
