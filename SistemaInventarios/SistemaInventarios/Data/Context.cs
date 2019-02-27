using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SistemaInventarios.Models;

namespace SistemaInventarios.Models
{
    public class Context : DbContext
    {
        public Context (DbContextOptions<Context> options)
            : base(options)
        {
        }

        public DbSet<SistemaInventarios.Models.Marca> Marca { get; set; }

        public DbSet<SistemaInventarios.Models.Productos> Productos { get; set; }
    }
}
