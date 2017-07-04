using MySql.Data.MySqlClient;
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
    public partial class Pantalla_Enviar : Form
    {
        Correo_SMTP c = new Correo_SMTP();

        public Pantalla_Enviar()
        {
            InitializeComponent();
            //cmbCorreo.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbCorreoCliente.DropDownStyle = ComboBoxStyle.DropDownList;
            //cmbServidor.DropDownStyle = ComboBoxStyle.DropDownList;
        }

        private void BtnEnviar_Click(object sender, EventArgs e)
        {
            c.enviarCorreo(cmbCorreo.Text, txtPassword.Text, rtbMensaje.Text, txtAsunto.Text, cmbCorreoCliente.Text, txtRutaArchivo.Text, cmbServidor.Text);
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                this.openFileDialog1.ShowDialog();
                if(this.openFileDialog1.FileName.Equals("")==false)
                {
                    txtRutaArchivo.Text = this.openFileDialog1.FileName;

                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("Error al cargar la ruta del archivo: "+ex.ToString());
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            llenarcorreo();
            llenarcorreocliente();
        }

        public void llenarcorreo()
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `CORREO` FROM `responsable`", _conexion);
            da.Fill(ds, "responsable");
            cmbCorreo.DataSource = ds.Tables[0].DefaultView;
            cmbCorreo.ValueMember = "CORREO";
            _conexion.Close();
        }

        public void llenarcorreocliente()
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            DataSet ds = new DataSet();
            MySqlDataAdapter da = new MySqlDataAdapter("SELECT `email` FROM `cliente`", _conexion);
            da.Fill(ds, "cliente");
            cmbCorreoCliente.DataSource = ds.Tables[0].DefaultView;
            cmbCorreoCliente.ValueMember = "email";
            _conexion.Close();
        }

        private void rtbMensaje_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
