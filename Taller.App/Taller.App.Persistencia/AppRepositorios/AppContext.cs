using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Taller.App.Dominio;
{
    
}

namespace Taller.App.Persistencia.AppRepositorios
{
    public class AppContext : DbContext
    {
        
        public DbSet<EmpleadoTaller> Empleado {get; set;}

        protected override void onconfiguring(DbContextOptionsBuilder optionsBuilder)
        
    {
        optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Test");
    }

    }
}