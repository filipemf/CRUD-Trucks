using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD_Caminhoes.Models
{
    public class TrucksContext: DbContext
    {
        public TrucksContext(DbContextOptions<TrucksContext> options) : base(options)
        {

        }

        public DbSet<Trucks> Trucks { get; set; }
    }
}
