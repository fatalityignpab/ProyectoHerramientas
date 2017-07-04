using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class Factura
    {
        public Factura()
        {
 //           throw new System.NotImplementedException();
        }

        public Factura(int idFactura, string Cliente_idCliente, string Responsable_idResponsable, string Fecha)
        {
            this.idFactura = idFactura;
            this.Cliente_idCliente = Cliente_idCliente;
            this.Responsable_idResponsable = Responsable_idResponsable;
            this.Fecha = Fecha;
        }

        public int idFactura { get; set; }

        public string Cliente_idCliente { get; set; }

        public string Responsable_idResponsable { get; set; }

        public string Fecha { get; set; }

        public Responsable Responsable { get; set; }

        public Cliente Cliente { get; set; }
    }
}