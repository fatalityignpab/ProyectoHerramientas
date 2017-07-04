using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data; // Para el manejo consultado SQL
using System.Xml;
using System.Xml.Serialization;
using System.Drawing;
using System.Web;
using System.Diagnostics; //prueba 
using System.IO; // Para directory y FileStream

namespace Proyecto_BD_HA_V2
{
    class TablaCliente
    {
        public static int i = 0;

        public static int AgregarCliente(Cliente pCliente)
        {
            int retorno = 0;
            // INSERT INTO `cliente`(`idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email`) VALUES ([value-1],[value-2],[value-3],[value-4],[value-5],[value-6])
            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `cliente`(`idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email`) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}')",
                pCliente.idCliente, pCliente.Nombre, pCliente.Apellidos, pCliente.Direccion, pCliente.Telefono, pCliente.Email), BDConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Cliente> Buscar(string pidCliente)
        {
            List<Cliente> _lista = new List<Cliente>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT `idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email` FROM `cliente` WHERE `cliente`.`idCliente` = {0}", pidCliente), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Cliente pCliente = new Cliente();
                pCliente.idCliente = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellidos = _reader.GetString(2);
                pCliente.Direccion = _reader.GetString(3);
                pCliente.Telefono = _reader.GetString(4);
                pCliente.Email = _reader.GetString(5);
                _lista.Add(pCliente);
            }

            return _lista;
        }

        public static Cliente ObtenerCliente(int pidCliente)
        {
            Cliente pCliente = new Cliente();
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            
            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `idCliente`, `Nombre`, `Apellidos`, `Direccion`, `Telefono`, `email` FROM `cliente` WHERE `cliente`.`idCliente` = {0}", pidCliente), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pCliente.idCliente = _reader.GetInt32(0);
                pCliente.Nombre = _reader.GetString(1);
                pCliente.Apellidos = _reader.GetString(2);
                pCliente.Direccion = _reader.GetString(3);
                pCliente.Telefono = _reader.GetString(4);
                pCliente.Email = _reader.GetString(5);
            }

            conexion.Close();
            return pCliente;
        }
        public static int Actualizar(Cliente pCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `cliente` SET `Nombre`='{0}',`Apellidos`='{1}',`Direccion`='{2}',`Telefono`='{3}',`email`='{4}' WHERE `cliente`.`idCliente` = {5}",
                pCliente.Nombre, pCliente.Apellidos, pCliente.Direccion, pCliente.Telefono, pCliente.idCliente), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(string pidCliente)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `cliente` WHERE `cliente`.`idCliente` = {0}", pidCliente), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Truncar()
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("TRUNCATE cliente"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        
    }
}
