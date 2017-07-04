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
using System.Xml;
using System.Xml.Serialization;

namespace Proyecto_BD_HA_V2
{
    public partial class ConsultaVentas : Form
    {
        public ConsultaVentas()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool[] numerico = new bool[] { true }; // Para verificar si es numerico
            numerico[0] = Numerico.EsNumerico(textBox1.Text.Trim());

            if (textBox1.Text.Trim() != "")
            {
                if (numerico[0] == true)
                {
                    dataGridViewBuscar.DataSource = TablaVentas.Buscar(textBox1.Text);
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

        DataTable dtDatos = new DataTable();
        DataSet dtSet = new DataSet();




        private void btnXML_Click(object sender, EventArgs e)
        {
            ControlReporte re = new ControlReporte(textBox1.Text.Trim());
            re.Show();


            /*
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(string.Format("SELECT factura.idFactura, responsable.Nombre AS Responsable, productos.Nombre, productos.Talla, productos.Precio, cliente.Nombre AS Comprador, CONCAT('$ ',FORMAT(detalle.Cantidad*productos.Precio,2)) AS Importe FROM `factura` INNER JOIN detalle INNER JOIN cliente INNER JOIN responsable INNER JOIN productos ON cliente.idCliente = factura.Cliente_idCliente AND responsable.idResponsable = factura.Responsable_idResponsable AND productos.idProducto = detalle.Productos_idProducto AND detalle.Factura_idFactura = factura.idFactura WHERE factura.idFactura = " + textBox1.Text.Trim()+""), _conexion); // Aqui use un codigo de que previamene cree una vista
            mdaDatos.Fill(dtDatos);
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "XML|*.xml";
            if (save.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    dtSet.Tables.Add(dtDatos); // Agregamos los datos de la tabla
                    dtSet.WriteXml(save.FileName);
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex);
                }
            }
            _conexion.Close(); */
        }
    }
}
