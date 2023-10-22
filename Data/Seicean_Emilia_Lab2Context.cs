using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Seicean_Emilia_Lab2.Models;

namespace Seicean_Emilia_Lab2.Data
{
    public class Seicean_Emilia_Lab2Context : DbContext
    {
        public Seicean_Emilia_Lab2Context (DbContextOptions<Seicean_Emilia_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Seicean_Emilia_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Seicean_Emilia_Lab2.Models.Publisher> Publisher { get; set; } = default!;
    }
}
