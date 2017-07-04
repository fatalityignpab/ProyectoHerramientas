using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class VistaVenta
    {
        public VistaVenta()
        {
            //throw new System.NotImplementedException();
        }

        public VistaVenta(int idFactura, string Responsable, string Nombre, string Talla, string Precio, string Comprador, string Importe)
        {
            this.idFactura= idFactura;
            this.Responsable= Responsable;
            this.Nombre= Nombre;
            this.Talla= Talla;
            this.Precio= Precio;
            this.Comprador= Comprador;
            this.Importe= Importe;
        }

        public int idFactura { get; set; }

        public string Responsable { get; set; }

        public string Nombre { get; set; }

        public string Talla { get; set; }

        public string Precio { get; set; }

        public string Comprador { get; set; }

        public string Importe { get; set; }
    }
}