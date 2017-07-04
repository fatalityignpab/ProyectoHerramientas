using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Proyecto_BD_HA_V2
{
    public partial class Alta_Productos : Form
    {
        
        public Alta_Productos()
        {
            InitializeComponent();
        }

        private void Alta_Productos_Load(object sender, EventArgs e)
        {
            //MessageBox.Show(num);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            msj_alta_completo msjalta = new msj_alta_completo();
            msj_alta_error msjerror = new msj_alta_error();
            Productos pProducto = new Productos();
            bool[] numerico = new bool[] {true,true}; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumericoFloat(textoPrecio.Text.Trim());
            numerico[1] = Numerico.EsNumerico(textoStock.Text.Trim());

            if (textoPrecio.Text.Trim() != "" && textoNombre.Text.Trim() != "" && textoStock.Text.Trim() != "" && comboTalla.Text.Trim() != "")
            {
                if(numerico[0] == true && numerico[1] == true)
                {
                    pProducto.Responsable_idResponsable = num;
                    pProducto.Nombre = textoNombre.Text.Trim();
                    pProducto.Talla = comboTalla.Text.Trim();
                    pProducto.Precio = textoPrecio.Text.Trim();
                    pProducto.Stock = textoStock.Text.Trim();
                    int resultado = TablaProducto.AgregarProducto(pProducto);

                    if (resultado > 0)
                    {
                        msjalta.Visible = true;
                        Hide();
                    }
                    else
                    {
                        msjerror.Visible = true;
                        Hide();
                    }
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

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textoCasif_TextChanged(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void textoProducto_Validated(object sender, EventArgs e)
        {

        }

        private void textoPieza_Validated(object sender, EventArgs e)
        {

        }

        private void textoCosto_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumerico(textoStock.Text))
            {
                error.SetError(textoStock, "debe ingresar un numero");
//                textoProducto.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        private void textoPrecio_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumericoFloat(textoPrecio.Text))
            {
                error.SetError(textoPrecio, "debe ingresar un numero flotante");
                //                textoProducto.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        private void comboTalla_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textoPrecio_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoStock_TextChanged(object sender, EventArgs e)
        {

        }

        private void textoNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }
    }
}
