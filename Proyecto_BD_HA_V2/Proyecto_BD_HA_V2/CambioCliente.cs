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
    public partial class CambioCliente : Form
    {
        public CambioCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public Cliente ClienteActual { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            CambioClienteActual cam = new CambioClienteActual();
            cam.ShowDialog();

            if (cam.ClienteSelect != null)
            {
                ClienteActual = cam.ClienteSelect;
                textoNom.Text = cam.ClienteSelect.Nombre;
                textoApe.Text = cam.ClienteSelect.Apellidos;
                textoDir.Text = cam.ClienteSelect.Direccion;
                textoTel.Text = cam.ClienteSelect.Telefono;
                textoEmail.Text = cam.ClienteSelect.Email;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (textoNom.Text.Trim() != "" && textoApe.Text.Trim() != "" && textoDir.Text.Trim() != "" && textoTel.Text.Trim() != "" && textoEmail.Text.Trim() != "")
            {
                Cliente pCliente = new Cliente();
                pCliente.Nombre = textoNom.Text.Trim();
                pCliente.Apellidos = textoApe.Text.Trim();
                pCliente.Direccion = textoDir.Text.Trim();
                pCliente.Telefono = textoTel.Text.Trim();
                pCliente.Email = textoEmail.Text.Trim();
                pCliente.idCliente = ClienteActual.idCliente;


                if (TablaCliente.Actualizar(pCliente) > 0)
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

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void CambioCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
