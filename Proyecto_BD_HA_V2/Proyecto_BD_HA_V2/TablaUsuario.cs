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
    class TablaUsuario
    {
        public static int i = 0;

        public static int AgregarUsuario(Responsable pResponsable)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `responsable`(`idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`, `CORREO`) VALUES ('{0}','{1}','{2}',MD5('{3}'),'{4}',CURRENT_DATE(), CURRENT_TIME(),'{5}')",
                pResponsable.idResponsable, pResponsable.Nombre, pResponsable.Alias, pResponsable.Password, pResponsable.Puesto, pResponsable.Correo), BDConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Responsable> Buscar(string pidResponsable)
        {
            List<Responsable> _lista = new List<Responsable>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT `idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`, `CORREO` FROM `responsable` WHERE `responsable`.`idResponsable` = {0}", pidResponsable), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Responsable pResponsable = new Responsable();
                pResponsable.idResponsable = _reader.GetInt32(0);
                pResponsable.Nombre = _reader.GetString(1);
                pResponsable.Alias = _reader.GetString(2);
                pResponsable.Password = _reader.GetString(3);
                pResponsable.Puesto = _reader.GetString(4);
                pResponsable.FechaIngreso = _reader.GetString(5);
                pResponsable.HoraIngreso = _reader.GetString(6);
                pResponsable.Correo = _reader.GetString(7);
                _lista.Add(pResponsable);
            }

            return _lista;
        }

        public static Responsable ObtenerUsuario(int pidResponsable)
        {
            Responsable pResponsable = new Responsable();
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            //SELECT `idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso` FROM `responsable` WHERE `responsable`.`idResponsable` = 1

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `idResponsable`, `Nombre`, `Alias`, `Password`, `Puesto`, `FechaIngreso`, `HoraIngreso`, `CORREO` FROM `responsable` WHERE `responsable`.`idResponsable` = {0}", pidResponsable), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pResponsable.idResponsable = _reader.GetInt32(0);
                pResponsable.Nombre = _reader.GetString(1);
                pResponsable.Alias = _reader.GetString(2);
                pResponsable.Password = _reader.GetString(3);
                pResponsable.Puesto = _reader.GetString(4);
                pResponsable.FechaIngreso = _reader.GetString(5);
                pResponsable.HoraIngreso = _reader.GetString(6);
                pResponsable.Correo = _reader.GetString(7);
            }

            conexion.Close();
            return pResponsable;
        }
        public static int Actualizar(Responsable pResponsable)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            // UPDATE `responsable` SET `Puesto` = 'Almacenista', `HoraIngreso` = '14:13:22' WHERE `responsable`.`idResponsable` = 2 
            //UPDATE `responsable` SET `Nombre`='{0}',`Alias`='{1}',`Password`='{2}',`Puesto`='{3}',`FechaIngreso`='{4}',`HoraIngreso`='{5}' WHERE `responsable`.`idResponsable` = {6}
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `responsable` SET `Nombre`='{0}',`Alias`='{1}',`Password`= MD5('{2}'),`Puesto`='{3}', `CORREO`='{4}' WHERE `responsable`.`idResponsable` = {5}",
                pResponsable.Nombre, pResponsable.Alias, pResponsable.Password, pResponsable.Puesto, pResponsable.Correo, pResponsable.idResponsable), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(string pidResponsable)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `responsable` WHERE `responsable`.`idResponsable` = {0}", pidResponsable), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Truncar()
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("TRUNCATE responsable"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int ComprobarUsuario(string pAlias, string pPass)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            string SQL = "SELECT * FROM `responsable` WHERE `Alias` = '" + pAlias + "' AND `Password` = MD5('" + pPass + "')";
            MySqlCommand comando = new MySqlCommand(String.Format(SQL), conexion);
            MySqlDataReader leer = comando.ExecuteReader();
            if (leer.Read())
            {
                retorno = 1;
                conexion.Close();
                return retorno;
            }
            else
            {
                conexion.Close();
                return retorno;
            }
        }

        public static DataTable Buscar(string pAlias, string pPass)
        {
            DataTable dt = new DataTable();
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            string consulta = "SELECT * FROM `responsable` WHERE `Alias` = '" + pAlias + "' AND `Password` = MD5('" + pPass + "')";
            MySqlCommand comando = new MySqlCommand(String.Format(consulta), conexion);
            comando.Parameters.AddWithValue("{0}",pAlias);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);
            return dt;
        }

        public static int Actualhora(string pAlias, string pPass)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `responsable` SET `FechaIngreso`=CURRENT_DATE(), `HoraIngreso`= CURRENT_TIME() WHERE `Alias` = '" + pAlias + "' AND `Password` = MD5('" + pPass + "')"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }
        
    }
}
