using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using aeropuerto.Model;

namespace aeropuerto.Data
{
    public class aeropuertoContext : DbContext
    {
        public aeropuertoContext (DbContextOptions<aeropuertoContext> options)
            : base(options)
        {
        }

        public DbSet<aeropuerto.Model.Airport> Airport { get; set; }
    }
}
