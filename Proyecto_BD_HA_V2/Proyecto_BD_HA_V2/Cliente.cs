using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Proyecto_BD_HA_V2
{
    public class Cliente
    {
        public Cliente()
        {
//            throw new System.NotImplementedException();
        }

        public Cliente(int idCliente, string Nombre, string Apellidos, string Direccion, string Telefono, string Email)
        {
            this.idCliente = idCliente;
            this.Nombre = Nombre;
            this.Apellidos = Apellidos;
            this.Direccion = Direccion;
            this.Telefono = Telefono;
            this.Email = Email;
        }

        public int idCliente { get; set; }

        public string Nombre { get; set; }

        public string Apellidos { get; set; }

        public string Direccion { get; set; }

        public string Telefono { get; set; }

        public string Email { get; set; }
    }
}