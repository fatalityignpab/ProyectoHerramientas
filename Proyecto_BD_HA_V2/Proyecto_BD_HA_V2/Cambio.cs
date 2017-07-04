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
    public partial class Cambio : Form
    {
        public Cambio()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cambio_Load(object sender, EventArgs e)
        {

        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] numerico = new bool[] { true }; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textBox1.Text.Trim());

            if (textBox1.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    dataGridViewcambio.DataSource = TablaProducto.Buscar(textBox1.Text);
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

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public Productos ProductoSelect { get; set; }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambio_datos ca = new Cambio_datos();
            bool[] numerico = new bool[] {true}; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textBox1.Text.Trim());

            if (textBox1.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    if (dataGridViewcambio.SelectedRows.Count == 1)
                    {
                        int id = Convert.ToInt32(dataGridViewcambio.CurrentRow.Cells[0].Value);
                        ProductoSelect = TablaProducto.ObtenerProductos(id);
                        ca.RecibirCambio(id);
                        this.Close();
                    }
                    else
                        MessageBox.Show("Debe de seleccionar una fila");
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
    }
}
