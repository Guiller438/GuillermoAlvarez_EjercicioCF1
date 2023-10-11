using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using GuillermoAlvarez_EjercicioCF1.Models;

namespace GuillermoAlvarez_EjercicioCF1.Data
{
    public class GuillermoAlvarez_EjercicioCF1Context : DbContext
    {
        public GuillermoAlvarez_EjercicioCF1Context (DbContextOptions<GuillermoAlvarez_EjercicioCF1Context> options)
            : base(options)
        {
        }

        public DbSet<GuillermoAlvarez_EjercicioCF1.Models.Burger> Burger { get; set; } = default!;
    }
}
