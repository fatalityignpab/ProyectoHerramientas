using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;

namespace Proyecto_BD_HA_V2
{
    public class BDConexion
    {
            public static MySqlConnection ObtenerConexion() //ObtenerConexion = Nombre del método que nos conectara a la base de datos.
            {
                /*Server = Servidor de MySQL.
                database = Nombre de la base de datos a la cual nos conectamos.
                Uid = Nombre del usuario de Mysql (por defecto "root")
                pwd = Contraseña del usuario (dejar en blanco sino tiene) .*/
                MySqlConnection conectar = new MySqlConnection("server=127.0.0.1; database=herramientasaut_v2; Uid=herr; pwd=admin;");
                conectar.Open();
                return conectar;
            }
    }
}
