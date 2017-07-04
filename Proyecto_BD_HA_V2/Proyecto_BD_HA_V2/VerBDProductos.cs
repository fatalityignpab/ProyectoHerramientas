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
    public partial class VerBDProductos : Form
    {

        DataTable dtDatos = new DataTable();
        DataSet dtSet = new DataSet();
        public VerBDProductos()
        {
            InitializeComponent();
        }

        private void VerBDProductos_Load(object sender, EventArgs e)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(string.Format("SELECT `idProducto`, `Nombre`, `Talla`, `Precio`, `Stock` FROM `productos`"), _conexion); // Aqui use un codigo de que previamene cree una vista
            mdaDatos.Fill(dtDatos);
            dataGridReporte.DataSource = dtDatos;
            _conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
