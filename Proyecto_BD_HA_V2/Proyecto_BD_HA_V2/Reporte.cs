using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data; // Para el manejo consultado SQL
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;
using System.Diagnostics; //prueba 
using System.IO; // Para directory y FileStream

namespace Proyecto_BD_HA_V2
{
    public partial class Reporte : Form
    {
        DataTable dtDatos = new DataTable();
        DataSet dtSet = new DataSet();
        public Reporte()
        {
            InitializeComponent();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            //            DataTable dtDatos = new DataTable();
            MySqlDataAdapter mdaDatos = new MySqlDataAdapter(string.Format("SELECT * FROM `vistaprod`"), _conexion); // Aqui use un codigo de que previamene cree una vista
            mdaDatos.Fill(dtDatos);
            dataGridReporte.DataSource = dtDatos;
            _conexion.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXML_Click(object sender, EventArgs e)
        {
            //           dtDatos.WriteXml(@"C:\Users\DANNA\Documents\Visual Studio 2015\Projects\Proyecto_BD_FPOO\Proyecto_BD_FPOO\XMLPrueba.xml", XmlWriteMode.WriteSchema);
            //            MessageBox.Show("Datos Exportados");
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
        }
    }
}
