using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_BD_HA_V2
{
    public class BaseRegistro
    {
        public int IdRemision { get; set; }
        public string IdProducto{ get; set; }
        public string Piezas { get; set; }
        public string CostoUnit { get; set; }
        public string Nombre { get; set; }
        public string Talla { get; set; }

        public BaseRegistro() { } // Constructor

        public BaseRegistro(int pIdRemision, string pIdProducto, string pPiezas, string pCostoUnit, string pNombre, string pClasif) // Constructor con parametros
        {
            this.IdRemision = pIdRemision;
            this.IdProducto = pIdProducto;
            this.Piezas = pPiezas;
            this.CostoUnit = pCostoUnit;
            this.Nombre = pNombre;
            this.Talla = pClasif;
        }
    }
}
