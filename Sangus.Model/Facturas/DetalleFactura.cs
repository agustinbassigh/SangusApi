using Sangus.Model.Productos;
using Sangus.Shared;

namespace Sangus.Model.Facturas
{
    public class DetalleFactura : BaseEntity
    {
        public int ProductoId { get; set; }
        public Producto Producto { get; set; }
        public int FacturaId { get; set; }
        public Factura Factura { get; set; }
        public decimal Cantidad { get; set; }
        public decimal Subtotal  => Cantidad * Producto.PrecioUnitario;
    }
}