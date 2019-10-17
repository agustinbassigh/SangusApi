using Sangus.Shared;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sangus.Model.Facturas
{
    public class Factura : BaseEntity
    {
        public int NumeroFactura { get; set; }
        public DateTime FechaFactura { get; set; }
        public ICollection<DetalleFactura> Detalle { get; set; }


    }
}
