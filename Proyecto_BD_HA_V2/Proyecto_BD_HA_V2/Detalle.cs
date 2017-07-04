using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class Detalle
    {
        public Detalle()
        {
   //         throw new System.NotImplementedException();
        }

        public Detalle(int idDetalle, string Factura_idFactura, string Productos_idProducto, string Cantidad, string Precio)
        {
            this.idDetalle= idDetalle;
            this.Factura_idFactura= Factura_idFactura;
            this.Productos_idProducto= Productos_idProducto;
            this.Cantidad= Cantidad;
            this.Precio= Precio;
        }

        public int idDetalle { get; set; }

        public string Factura_idFactura { get; set; }

        public string Productos_idProducto { get; set; }

        public string Cantidad { get; set; }

        public string Precio { get; set; }

        public Factura Factura { get; set; }

        public Productos Productos { get; set; }
    }
}