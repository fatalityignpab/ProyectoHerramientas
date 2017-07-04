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
    public partial class Cambio_datos : Form
    {
        public Productos ProductoActual { get; set; }
        public Cambio_datos()
        {
            InitializeComponent();
        }

        private void Cambio_datos_Load(object sender, EventArgs e)
        {
            MessageBox.Show(num);
            MessageBox.Show(Convert.ToString(numcam));
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambio cam = new Cambio();
            cam.ShowDialog();

            if(cam.ProductoSelect != null)
            {
                ProductoActual = cam.ProductoSelect;
                textNombre.Text = cam.ProductoSelect.Nombre;
                textStock.Text = cam.ProductoSelect.Stock;
                textPrecio.Text = cam.ProductoSelect.Precio;
                comboTalla.Text = cam.ProductoSelect.Talla;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public int numcam;

        public void RecibirCambio(int usuario_id)
        {
            numcam = usuario_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] numerico = new bool[] { true, true}; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textStock.Text.Trim());
            numerico[1] = Numerico.EsNumericoFloat(textPrecio.Text.Trim());

            if (textNombre.Text.Trim() != "" && textStock.Text.Trim() != "" && comboTalla.Text.Trim() != "" && textPrecio.Text.Trim() != "")
            {
                if (numerico[0] == true && numerico[1] == true)
                {
                    msj_cambio_realizado msjok = new msj_cambio_realizado();
                    msj_cambio_error msjerror = new msj_cambio_error();
                    Productos pProducto = new Productos();
                    pProducto.Responsable_idResponsable = num;
                    pProducto.Nombre = textNombre.Text.Trim();
                    pProducto.Talla = comboTalla.Text.Trim();
                    pProducto.Precio = textPrecio.Text.Trim();
                    pProducto.Stock = textStock.Text.Trim();
//                    MessageBox.Show(Convert.ToString(numcam));
                    pProducto.idProductos = ProductoActual.idProductos;
                    if (TablaProducto.Actualizar(pProducto) > 0)
                    {
                        msjok.Visible = true;
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
        

        private void textBoxpieza_Validated(object sender, EventArgs e)
        {

        }

        private void textBoxcosto_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumerico(textStock.Text))
            {
                error.SetError(textStock, "debe ingresar un numero");
            }
            else
            {
                error.Clear();
            }
        }

        private void textPrecio_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumericoFloat(textPrecio.Text))
            {
                error.SetError(textStock, "debe ingresar un numero flotante");
            }
            else
            {
                error.Clear();
            }
        }
    }
}
