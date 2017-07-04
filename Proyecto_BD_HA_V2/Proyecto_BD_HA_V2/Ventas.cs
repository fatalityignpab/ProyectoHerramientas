using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;

namespace Proyecto_BD_HA_V2
{
    public partial class Ventas : Form
    {
        public Ventas()
        {
            InitializeComponent();
        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Ha finalizado las Ventas");
            this.Close();
        }

        private void Ventas_Load(object sender, EventArgs e)
        {
            llenarclientes();
            llenarproductos();
            textCliente.Enabled = true;
            btnVenProd.Enabled = true;
            comboBoxCliente.Enabled = true;
            textFactura.Enabled = true;
        }

        public void llenarproductos()
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `idProducto` FROM `productos`", _conexion);
            da.Fill(ds, "productos");
            comboBoxProducto.DataSource = ds.Tables[0].DefaultView;
            comboBoxProducto.ValueMember = "idProducto";
            _conexion.Close();
        }

        public void llenarclientes()
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `idCliente` FROM `cliente`", _conexion);
            da.Fill(ds, "cliente");
            comboBoxCliente.DataSource = ds.Tables[0].DefaultView;
            comboBoxCliente.ValueMember = "idCliente";
            _conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            BDCliente bd = new BDCliente();
            bd.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            VerBDProductos ver = new VerBDProductos();
            ver.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ConsultaVentas ve = new ConsultaVentas();
            ve.Show();
        }

        private void btnVenProd_Click(object sender, EventArgs e)
        {
            Factura pFactura = new Factura();

            if (comboBoxCliente.Text.Trim() != "")
            {
                pFactura.Responsable_idResponsable = num;
                pFactura.Cliente_idCliente = comboBoxCliente.Text.Trim();
                int resultado = TablaFactura.AgregarFactura(pFactura);
                DataTable dt = TablaFactura.obtenerCliente(comboBoxCliente.Text.Trim());
                DataRow row = dt.Rows[0];
                DataTable dt2 = TablaFactura.obtenerClienteApe(comboBoxCliente.Text.Trim());
                DataRow row2 = dt2.Rows[0];
                string nom = Convert.ToString(row["Nombre"]);
                string ape = Convert.ToString(row2["Apellidos"]);
                textCliente.Text = nom+" "+ape;
                DataTable dt3 = TablaDetalle.obtenerFact(comboBoxCliente.Text.Trim());
                DataRow row3 = dt3.Rows[0];
                string fac = Convert.ToString(row3["idFactura"]);
                textFactura.Text = fac;
                textCliente.Enabled = false;
                btnVenProd.Enabled = false;
                comboBoxCliente.Enabled = false;
                textFactura.Enabled = false;
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }
        }

        private void btnVenderProducto_Click(object sender, EventArgs e)
        {
            Detalle pDetalle = new Detalle();

            bool[] numerico = new bool[] { true }; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumericoFloat(textoCant.Text.Trim());

            if (textoCant.Text.Trim() != "" && comboBoxProducto.Text.Trim() != "" && comboBoxCliente.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    DataTable dt = TablaDetalle.obtenerFact(comboBoxCliente.Text.Trim());
                    DataRow row = dt.Rows[0];
                    pDetalle.Factura_idFactura = Convert.ToString(row["idFactura"]);
                    pDetalle.Productos_idProducto = comboBoxProducto.Text.Trim();
                    pDetalle.Cantidad = textoCant.Text.Trim();
                    int resultado2 = TablaDetalle.AgregarDetalle(pDetalle);
                    comboBoxProducto.Text = "";
                    textProducto.Text = "";
                    textoCant.Text = "";
                    MessageBox.Show("Producto Vendido");
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

        private void btnVicProd_Click(object sender, EventArgs e)
        {
            if (comboBoxProducto.Text.Trim() != "" && comboBoxCliente.Text.Trim() != "")
            {
                DataTable dt = TablaFactura.obtenerProdNom(comboBoxProducto.Text.Trim());
                DataRow row = dt.Rows[0];
                DataTable dt2 = TablaFactura.obtenerProdTalla(comboBoxProducto.Text.Trim());
                DataRow row2 = dt2.Rows[0];
                DataTable dt3 = TablaFactura.obtenerProdPrecio(comboBoxProducto.Text.Trim());
                DataRow row3 = dt3.Rows[0];
                string prodnom = Convert.ToString(row["Nombre"]);
                string prodtal = Convert.ToString(row2["Talla"]);
                string prodpre = Convert.ToString(row3["Precio"]);
                textProducto.Text = "Nombre: "+prodnom + " \nTalla: " + prodtal + " \nPrecio: " + prodpre;
            }
            else
            {
                MessageBox.Show("Debe de rellenar los campos con asterisco");
            }
        }

        private void textoCant_Validated(object sender, EventArgs e)
        {
            if (!Numerico.EsNumerico(textoCant.Text))
            {
                error.SetError(textoCant, "debe ingresar un numero");
                //                textBox1.Focus(); // Para restringir al usuario que ingrese un numero
            }
            else
            {
                error.Clear();
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
