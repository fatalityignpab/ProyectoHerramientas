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
    class TablaVentas
    {
        public static List<VistaVenta> Buscar(string pidFactura)
        {
            List<VistaVenta> _lista = new List<VistaVenta>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT factura.idFactura, responsable.Nombre AS Responsable, productos.Nombre, productos.Talla, productos.Precio, cliente.Nombre AS Comprador, CONCAT('$ ',FORMAT(detalle.Cantidad*productos.Precio,2)) AS Importe FROM `factura` INNER JOIN detalle INNER JOIN cliente INNER JOIN responsable INNER JOIN productos ON cliente.idCliente = factura.Cliente_idCliente AND responsable.idResponsable = factura.Responsable_idResponsable AND productos.idProducto = detalle.Productos_idProducto AND detalle.Factura_idFactura = factura.idFactura WHERE factura.idFactura ={0}", pidFactura), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                VistaVenta pVentas = new VistaVenta();
                pVentas.idFactura = _reader.GetInt32(0);
                pVentas.Responsable = _reader.GetString(1);
                pVentas.Nombre = _reader.GetString(2);
                pVentas.Talla = _reader.GetString(3);
                pVentas.Precio = _reader.GetString(4);
                pVentas.Comprador = _reader.GetString(5);
                pVentas.Importe = _reader.GetString(6);
                _lista.Add(pVentas);
            }
            return _lista;
        }

        public static List<VistaVenta> Llenar(string pidFactura)
        {
            List<VistaVenta> _lista = new List<VistaVenta>();

            MySqlCommand _comando = new MySqlCommand(String.Format(
           "SELECT factura.idFactura, responsable.Nombre AS Responsable, productos.Nombre, productos.Talla, productos.Precio, cliente.Nombre AS Comprador, CONCAT('$ ',FORMAT(detalle.Cantidad*productos.Precio,2)) AS Importe FROM `factura` INNER JOIN detalle INNER JOIN cliente INNER JOIN responsable INNER JOIN productos ON cliente.idCliente = factura.Cliente_idCliente AND responsable.idResponsable = factura.Responsable_idResponsable AND productos.idProducto = detalle.Productos_idProducto AND detalle.Factura_idFactura = factura.idFactura WHERE factura.idFactura = {0}", pidFactura), BDConexion.ObtenerConexion());
            MySqlDataReader _reader = _comando.ExecuteReader();
            while (_reader.Read())
            {
                VistaVenta pVentas = new VistaVenta();
                pVentas.idFactura = _reader.GetInt32(0);
                pVentas.Responsable = _reader.GetString(1);
                pVentas.Nombre = _reader.GetString(2);
                pVentas.Talla = _reader.GetString(3);
                pVentas.Precio = _reader.GetString(4);
                pVentas.Comprador = _reader.GetString(5);
                pVentas.Importe = _reader.GetString(6);
                _lista.Add(pVentas);
            }
            return _lista;
        }
    }
}
