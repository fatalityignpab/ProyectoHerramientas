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
    public partial class Inicio_sesion : Form
    {
        public Inicio_sesion()
        {
            InitializeComponent();
        }

        private void Inicio_sesion_Load(object sender, EventArgs e)
        {

        }

        //        string puesto;
        

        public Responsable usuarioselect { get; set; }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            MenuGerente menu = new MenuGerente();
            MenuAlmacenista menualm = new MenuAlmacenista();
            MenuVendedor menuven = new MenuVendedor();
            TablaUsuario tab = new TablaUsuario();
            Responsable res = new Responsable();
            string puesto, usuario_id;

            //msj_sesion_aceptado msjaceptado = new msj_sesion_aceptado();
            //msj_sesion_rechazo msjrechazo = new msj_sesion_rechazo();
            try
            {
                if (textBox1.Text.Trim() != "" && textBox2.Text.Trim() != "")
                {
                    if (TablaUsuario.ComprobarUsuario(textBox1.Text, textBox2.Text) > 0)
                    {
                        DataTable dt = TablaUsuario.Buscar(textBox1.Text, textBox2.Text);
                        if (dt.Rows.Count > 0)
                        {
                            DataRow row = dt.Rows[0];
                            puesto = Convert.ToString(row["puesto"]);
                            usuario_id = Convert.ToString(row["idResponsable"]);
                            //MessageBox.Show(puesto);
                            //MessageBox.Show(usuario_id);
                            if (puesto == "Gerente")
                            {
                                Hide();
                                TablaUsuario.Actualhora(textBox1.Text, textBox2.Text);
                                menu.Recibir(usuario_id);
                                menu.Show();
                                //msjaceptado.Show();
                                MessageBox.Show("Usuario y Password Aceptado");
                                //msjaceptado.Visible = true;
                            }
                            else
                            {
                                if (puesto == "Almacenista")
                                {
                                    Hide();
                                    TablaUsuario.Actualhora(textBox1.Text, textBox2.Text);
                                    menualm.Recibir(usuario_id);
                                    menualm.Show();
                                    //msjaceptado.Show();
                                    MessageBox.Show("Usuario y Password Aceptado");
                                    //msjaceptado.Visible = true;
                                }
                                else
                                {
                                    if (puesto == "Vendedor")
                                    {
                                        Hide();
                                        TablaUsuario.Actualhora(textBox1.Text, textBox2.Text);
                                        menuven.Recibir(usuario_id);
                                        menuven.Show();
                                        //msjaceptado.Show();
                                        MessageBox.Show("Usuario y Password Aceptado");
                                        //msjaceptado.Visible = true;
                                    }
                                    else
                                    {
                                        MessageBox.Show("Esta erroneo el puesto");
                                    }
                                }
                            }
                        }
                    }
                    else
                    {
                        ////msjrechazo.Visible = true;
                        MessageBox.Show("Usuario y Password No fue aceptado");
                        textBox1.Text = "";
                        textBox2.Text = "";
                    }
                }
                else
                {
                    MessageBox.Show("Debe de rellenar los campos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("No funciono XD :'v");
            }
        }



        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void btnVer_Click(object sender, EventArgs e)
        {
            BDResponsable bd = new BDResponsable();
            bd.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AltaUsuario usu = new AltaUsuario();
            usu.Show();
        }
    }
}
