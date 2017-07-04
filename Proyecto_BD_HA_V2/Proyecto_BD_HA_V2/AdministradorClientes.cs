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
    public partial class AdministradorClientes : Form
    {
        public AdministradorClientes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaClientes usu = new AltaClientes();
            usu.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaCliente baja = new BajaCliente();
            baja.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambioCliente ca = new CambioCliente();
            ca.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaCliente con = new ConsultaCliente();
            con.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BDCliente bd = new BDCliente();
            bd.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que desea vaciar la Base de Datos de los clientes?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TablaCliente.Truncar();
                    MessageBox.Show("Se vacio la Base de Datos de Clientes");
                }
                else
                    MessageBox.Show("Se cancelo la acción", "Vaciar BD Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex) //Exception ex
            {
                MessageBox.Show("No se puede eliminar la Tabla de Clientes porque hay tablas que dependen de este");
            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
