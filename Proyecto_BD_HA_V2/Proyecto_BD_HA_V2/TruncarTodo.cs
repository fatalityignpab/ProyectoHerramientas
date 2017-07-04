using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;

namespace Proyecto_BD_HA_V2
{
    class TruncarTodo
    {
        public static void Truncar()
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("TRUNCATE detalle"), conexion);
            retorno = comando.ExecuteNonQuery();
            MySqlCommand comando2 = new MySqlCommand(string.Format("TRUNCATE factura"), conexion);
            retorno = comando2.ExecuteNonQuery();
            MySqlCommand comando3 = new MySqlCommand(string.Format("TRUNCATE productos"), conexion);
            retorno = comando3.ExecuteNonQuery();
            MySqlCommand comando4 = new MySqlCommand(string.Format("TRUNCATE cliente"), conexion);
            retorno = comando4.ExecuteNonQuery();
            MySqlCommand comando5 = new MySqlCommand(string.Format("TRUNCATE responsable"), conexion);
            retorno = comando5.ExecuteNonQuery();
            MySqlCommand comando6 = new MySqlCommand(string.Format("INSERT INTO `responsable` (`idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`) VALUES (NULL, 'Administrador', 'admin', MD5('admin'), 'Gerente', CURRENT_DATE(), CURRENT_TIME())"), conexion);
            retorno = comando6.ExecuteNonQuery();
            // INSERT INTO `responsable` (`idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`) VALUES (NULL, 'Administrador', 'admin', MD5('admin'), 'Gerente', CURRENT_DATE(), CURRENT_TIME())
            conexion.Close();
        }
    }
}
