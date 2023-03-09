using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    class Cliente
    {
        public int IdCliente { get; set; }
        public string Documeno { get; set; }
        public string NombreCompleto { get; set; }
        public string Correo { get; set; }
        public bool Estado { get; set; }
        public string FechaRegistro { get; set; }
    }
}
