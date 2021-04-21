using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using RIEG.Compras.Caderno.Pages.Models;

namespace RIEG.Compras.Caderno.Data
{
    public class RIEGComprasCadernoContext : DbContext
    {
        public RIEGComprasCadernoContext (DbContextOptions<RIEGComprasCadernoContext> options)
            : base(options)
        {
        }

        public DbSet<RIEG.Compras.Caderno.Pages.Models.Product> Product { get; set; }
    }
}
