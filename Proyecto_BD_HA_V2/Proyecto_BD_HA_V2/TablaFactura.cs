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
    class TablaFactura
    {
        public static int i = 0;

        public static int AgregarFactura(Factura pFactura)
        {
            int retorno = 0;

            // INSERT INTO `factura`(`idFactura`, `Cliente_idCliente`, `Responsable_idResponsable`, `Fecha`) VALUES ('{0}','{1}','{2}',CURRENT_DATE())

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO `factura`(`idFactura`, `Cliente_idCliente`, `Responsable_idResponsable`, `Fecha`) VALUES ('{0}','{1}','{2}',CURRENT_DATE())",
                pFactura.idFactura, pFactura.Cliente_idCliente, pFactura.Responsable_idResponsable), BDConexion.ObtenerConexion());
            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Productos> Buscar(string pidProductos)
        {
            List<Productos> _lista = new List<Productos>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT `idProducto`, `Responsable_idResponsable`, `Nombre`, `Talla`, `Precio`, `Stock`, `FechaIngreso`, `HoraIngreso` FROM `productos` WHERE `productos`.`idProducto` = {0}", pidProductos), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos pProductos = new Productos();
                pProductos.idProductos = _reader.GetInt32(0);
                pProductos.Responsable_idResponsable = _reader.GetString(1);
                pProductos.Nombre = _reader.GetString(2);
                pProductos.Talla = _reader.GetString(3);
                pProductos.Precio = _reader.GetString(4);
                pProductos.Stock = _reader.GetString(5);
                _lista.Add(pProductos);
            }

            return _lista;
        }

        public static Productos ObtenerProductos(int pidProductos)
        {
            Productos pProductos = new Productos();
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            //SELECT `idProducto`, `Nombre`, `Talla`, `Precio`, `Stock`, `Responsable_idResponsable` FROM `productos` WHERE `productos`.`idProducto` = 1

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT `idProducto`, `Responsable_idResponsable`, `Nombre`, `Talla`, `Precio`, `Stock` FROM `productos` WHERE `productos`.`idProducto` = {0}", pidProductos), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProductos.idProductos = _reader.GetInt32(0);
                pProductos.Responsable_idResponsable = _reader.GetString(1);
                pProductos.Nombre = _reader.GetString(2);
                pProductos.Talla = _reader.GetString(3);
                pProductos.Precio = _reader.GetString(4);
                pProductos.Stock = _reader.GetString(5);
            }

            conexion.Close();
            return pProductos;
        }
        public static int Actualizar(Productos pProductos)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();
            MessageBox.Show(Convert.ToString(pProductos.Responsable_idResponsable));
            MessageBox.Show(Convert.ToString(pProductos.Nombre));
            MessageBox.Show(Convert.ToString(pProductos.Talla));
            MessageBox.Show(Convert.ToString(pProductos.Precio));
            MessageBox.Show(Convert.ToString(pProductos.Stock));
            MessageBox.Show(Convert.ToString(pProductos.idProductos));
            //UPDATE `productos` SET `Responsable_idResponsable` = '8', `Nombre` = 'cobija', `Talla` = 'Chico', `Precio` = '54', `Stock` = '65' WHERE `productos`.`idProducto` = 4 
            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE `productos` SET `Responsable_idResponsable` = '{0}', `Nombre` = '{1}', `Talla` = '{2}', `Precio` = '{3}', `Stock` = '{4}' WHERE `productos`.`idProducto` = '{5}'",
                pProductos.Responsable_idResponsable, pProductos.Nombre, pProductos.Talla, pProductos.Precio, pProductos.Stock, pProductos.idProductos), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(string pidProductos)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            // DELETE FROM `productos` WHERE `productos`.`idProducto` = 4
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM `productos` WHERE `productos`.`idProducto` = {0}", pidProductos), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Truncar()
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("TRUNCATE productos"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static DataTable obtenerProdNom(string num)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            //MessageBox.Show(num);
            string consulta = "SELECT `Nombre` FROM `productos` WHERE idProducto = @idProducto";
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, _conexion);
            comando.Parameters.AddWithValue("@idProducto", num);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }
        public static DataTable obtenerProdTalla(string num)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            string consulta = "SELECT `Talla` FROM `productos` WHERE idProducto = @idProducto";
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, _conexion);
            comando.Parameters.AddWithValue("@idProducto", num);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }
        public static DataTable obtenerProdPrecio(string num)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            string consulta = "SELECT `Precio` FROM `productos` WHERE idProducto = @idProducto";
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, _conexion);
            comando.Parameters.AddWithValue("@idProducto", num);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }

        public static DataTable obtenerCliente(string num)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            string consulta = "SELECT `Nombre` FROM `cliente` WHERE cliente.idCliente = @idCliente";
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, _conexion);
            comando.Parameters.AddWithValue("@idCliente", num);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }
        

        public static DataTable obtenerClienteApe(string num)
        {
            MySqlConnection _conexion = BDConexion.ObtenerConexion();
            string consulta = "SELECT `Apellidos` FROM `cliente` WHERE cliente.idCliente = @idCliente";
            DataTable dt = new DataTable();

            MySqlCommand comando = new MySqlCommand(consulta, _conexion);
            comando.Parameters.AddWithValue("@idCliente", num);
            MySqlDataAdapter adap = new MySqlDataAdapter(comando);
            adap.Fill(dt);

            return dt;
        }

    }
}
