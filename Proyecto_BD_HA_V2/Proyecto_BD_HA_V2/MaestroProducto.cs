using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data; // Nuevo
using MySql.Data.MySqlClient;

namespace Proyecto_BD_HA_V2
{
    class MaestroProducto
    {
        public static int AgregarProducto(BaseRegistro pProducto)
        {
            int retorno = 0;

            MySqlCommand comando = new MySqlCommand(string.Format("INSERT INTO registro (IdProducto, Piezas, CostoUnit, Nombre, Talla) VALUES ('{0}','{1}','{2}','{3}','{4}') ",
                pProducto.IdProducto, pProducto.Piezas, pProducto.CostoUnit, pProducto.Nombre, pProducto.Talla), BDConexion.ObtenerConexion());

            //INSERT INTO `registro` (`IdProducto`, `Piezas`, `CostoUnit`, `Nombre`, `Clasif`) VALUES ('{0}','{1}','{2}','{3}','{4}') 

            retorno = comando.ExecuteNonQuery();

            return retorno;
        }

        public static List<Productos> Buscar(string pIdRemision)
        {
            List<Productos> _lista = new List<Productos>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT IdRegistro, IdProducto, Piezas, CostoUnit, Nombre, Talla, (Piezas*CostoUnit) AS Importe FROM registro where IdRegistro ='{0}'", pIdRemision), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                Productos pProducto = new Productos();
                pProducto.idProductos = _reader.GetInt32(0);
                pProducto.Nombre = _reader.GetString(1);
                pProducto.FechaIngreso = _reader.GetString(2);
                pProducto.FechaIngreso = _reader.GetString(3);
                pProducto.Nombre = _reader.GetString(4);
                pProducto.Talla = _reader.GetString(5);
                _lista.Add(pProducto);
            }

            return _lista;
        }

        public static BaseRegistro ObtenerProducto(int pIdRemision)
        {
            BaseRegistro pProducto = new BaseRegistro();
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand _comando = new MySqlCommand(String.Format("SELECT IdRegistro, IdProducto, Piezas, CostoUnit, Nombre, Talla, (Piezas*CostoUnit) AS Importe FROM registro where IdRegistro={0}", pIdRemision), conexion);
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                pProducto.IdRemision = _reader.GetInt32(0);
                pProducto.IdProducto = _reader.GetString(1);
                pProducto.Piezas = _reader.GetString(2);
                pProducto.CostoUnit = _reader.GetString(3);
                pProducto.Nombre = _reader.GetString(4);
                pProducto.Talla = _reader.GetString(5);
            }
            
            conexion.Close();
            return pProducto;
        }
        public static int Actualizar(BaseRegistro pProducto)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("UPDATE registro SET IdProducto='{0}', Piezas='{1}', CostoUnit='{2}', Nombre='{3}', Talla='{4}' WHERE IdRegistro={5}",
                pProducto.IdProducto, pProducto.Piezas, pProducto.CostoUnit, pProducto.Nombre, pProducto.Talla, pProducto.IdRemision), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;
        }

        public static int Eliminar(string pIdRemision)
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            //DELETE FROM `productos` WHERE `productos`.`idProducto` = 4
            MySqlCommand comando = new MySqlCommand(string.Format("DELETE FROM registro WHERE IdRegistro={0}", pIdRemision), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }

        public static int Truncar()
        {
            int retorno = 0;
            MySqlConnection conexion = BDConexion.ObtenerConexion();

            MySqlCommand comando = new MySqlCommand(string.Format("TRUNCATE registro"), conexion);

            retorno = comando.ExecuteNonQuery();
            conexion.Close();

            return retorno;

        }
    }
}
