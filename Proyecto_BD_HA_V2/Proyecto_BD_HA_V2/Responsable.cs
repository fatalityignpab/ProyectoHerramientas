using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class Responsable : AbstractaRegistro
    {
        public Responsable()
        {
//            throw new System.NotImplementedException();
        }

        public Responsable(int idResponsable, string Nombre, string Password, string Puesto, string FechaIngreso, string HoraIngreso, string Correo)
        {
            this.idResponsable = idResponsable;
            this.Nombre = Nombre;
            this.Password = Password;
            this.Puesto = Puesto;
            this.FechaIngreso = FechaIngreso;
            this.HoraIngreso = HoraIngreso;
            this.Correo = Correo;
        }

        public int idResponsable { get; set; }

        public string Nombre { get; set; }

        public string Alias { get; set; }

        public string Password { get; set; }

        public string Puesto { get; set; }

        public string FechaIngreso { get; set; }

        public string HoraIngreso { get; set; }

        public string Correo { get; set; }
    }
}