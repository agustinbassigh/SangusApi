using Sangus.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sangus.Model.Productos
{
    public class Producto : BaseEntity
    {
        public string Descripcion { get; set; }
        public decimal StockMinimo { get; set; }
        public decimal PrecioUnitario { get; set; }
        public decimal StockActual { get; set; }

    }
}
