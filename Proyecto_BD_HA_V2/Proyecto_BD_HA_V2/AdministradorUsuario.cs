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
    public partial class AdministradorUsuario : Form
    {
        public AdministradorUsuario()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AltaUsuario usu = new AltaUsuario();
            usu.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Hide();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show("¿Esta Seguro que desea vaciar la Base de Datos en los usuarios?", "¿Estas Seguro?", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    TablaUsuario.Truncar();
                    MessageBox.Show("Se vacio la Base de Datos de Usuarios");
                }
                else
                    MessageBox.Show("Se cancelo la acción", "Vaciar BD Cancelada", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            catch (Exception ex)
            {
                MessageBox.Show("No se puede eliminar la Tabla de Usuarios porque hay tablas que dependen de este");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            BajaUsuario baja = new BajaUsuario();
            baja.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            BDResponsable bdres = new BDResponsable();
            bdres.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            CambioUsuario ca = new CambioUsuario();
            ca.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ConsultaUsuario cusu = new ConsultaUsuario();
            cusu.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
