﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaEntidad
{
    public class Detalle_Compra
    {
        public int IdDetalleCoompra { get; set; }
        public Producto oProducto { get; set; }
        public decimal PrecioI { get; set; }
        public decimal PrecioF { get; set; }
        public int cantidad { get; set; }
        public decimal MontoTotal { get; set; }
        public string FechaRegistro { get; set; }
    }
}
