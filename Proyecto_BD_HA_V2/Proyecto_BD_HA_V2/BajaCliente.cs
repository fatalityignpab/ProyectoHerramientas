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
    public partial class BajaCliente : Form
    {
        public BajaCliente()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            bool[] numerico = new bool[] { true }; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textBox1.Text.Trim());
            if (textBox1.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    if (MessageBox.Show("¿Esta Seguro que desea eliminar el Usuario?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (TablaCliente.Eliminar(textBox1.Text) > 0)
                        {
                            MessageBox.Show("Usuario borrado");
                            Hide();
                        }
                        else
                        {
                            MessageBox.Show("Usuario no encontrado");
                            Hide();
                        }
                    }
                    else
                        MessageBox.Show("Se cancelo la eliminacion", "Eliminacion Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                else
                {
                    MessageBox.Show("El campo de texto con asterisco, Deben de ser numeros enteros");
                }
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }
        }

        private void textBox1_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumerico(textBox1.Text))
            {
                error.SetError(textBox1, "debe ingresar un numero");
                //                textBox1.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void BajaCliente_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }
    }
}
