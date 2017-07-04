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
    public partial class MenuAlmacenista : Form
    {
        public MenuAlmacenista()
        {
            InitializeComponent();
        }

        private void MenuAlmacenista_Load(object sender, EventArgs e)
        {

        }

        public string num;

        public void Recibir(string usuario_id)
        {
            num = usuario_id;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AdministradorProductos ad = new AdministradorProductos();
            ad.Recibir(num);
            ad.Show();
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
    }
}
