using Microsoft.EntityFrameworkCore;
using Sangus.Model.Clientes;
using Sangus.Model.Facturas;
using Sangus.Model.Productos;
using System;
using System.Collections.Generic;
using System.Text;

namespace Sangus.Data
{
    public class SangusDbContext : DbContext
    {

        public SangusDbContext(DbContextOptions<SangusDbContext> options)
: base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Producto> Productos { get; set; }
        public DbSet<Factura> Facturas { get; set; }
        public DbSet<DetalleFactura> DetallesFactura { get; set; }

    }
}
