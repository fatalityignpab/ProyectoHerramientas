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
    public partial class MenuGerente : Form
    {
        public MenuGerente()
        {
            InitializeComponent();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            Consulta consulta = new Consulta();
            consulta.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //            Alta alta = new Alta();
            //            alta.Show();
            Alta_Productos altaprod = new Alta_Productos();
            altaprod.Recibir(num);
            altaprod.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Reporte reporte = new Reporte();
            reporte.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Baja baja = new Baja();
            baja.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cambio_datos cambio = new Cambio_datos();
            cambio.Recibir(num);
            cambio.Show();
        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Inicio_sesion ini = new Inicio_sesion();
            if (MessageBox.Show("¿Esta Seguro que desea cerrar Sesión?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ini.Visible = true;
                Hide();
                MessageBox.Show("Buen dia");

            }
            else
                MessageBox.Show("Se cancelo la solicitud", "Solicitud Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void Menu_Load(object sender, EventArgs e)
        {
            
        }

        private void Menu_Closing(object sender, System.ComponentModel.CancelEventArgs e)
        {
            /*

            // Determine if text has changed in the textbox by comparing to original text.
            if (textBox1.Text != strMyOriginalText)
            {
                // Display a MsgBox asking the user to save changes or abort.
                if (MessageBox.Show("Do you want to save changes to your text?", "My Application",
                   MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    // Cancel the Closing event from closing the form.
                    e.Cancel = true;
                    // Call method to save file...
                }
            }

            */
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que desea vaciar la Base de Datos?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TruncarTodo.Truncar();
                    MessageBox.Show("Se vacio la Base de Datos");
                    MessageBox.Show("Se creo un Administrador");
                }
                else
                    MessageBox.Show("Se cancelo la acción", "Vaciar BD Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar la Tabla de Productos porque hay tablas que dependen de este");
            }


        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Inicio_sesion ini = new Inicio_sesion();
            if (MessageBox.Show("¿Esta Seguro que desea cerrar Sesión?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                ini.Visible = true;
                Hide();
                MessageBox.Show("Buen dia");

            }
            else
                MessageBox.Show("Se cancelo la solicitud", "Solicitud Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        private void btnAdmin_Click(object sender, EventArgs e)
        {
            AdministradorUsuario admin = new AdministradorUsuario();
            admin.Show();
        }

        private void btnClienteAdmin_Click(object sender, EventArgs e)
        {
            AdministradorClientes admic = new AdministradorClientes();
            admic.Show();
        }

        private void button8_Click(object sender, EventArgs e)
        {
            Ventas ve = new Ventas();
            ve.Recibir(num);
            ve.Show();
        }

        private void btnReporte_Click(object sender, EventArgs e)
        {
            ConsultaVentas ve = new ConsultaVentas();
            ve.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            AdministradorProductos ad = new AdministradorProductos();
            ad.Recibir(num);
            ad.Show();
        }

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            Pantalla_Enviar smtp = new Pantalla_Enviar();
            smtp.Show();
        }
    }
}
