using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

// Proyecto: GamesScore

namespace Proyecto_BD_HA_V2
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            BDConexion.ObtenerConexion(); // Aqui estamos llamando a la funcionn de Obtener conexion
            //MessageBox.Show("Base de Datos Conectado");
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Inicio_sesion());
        }
    }
}
