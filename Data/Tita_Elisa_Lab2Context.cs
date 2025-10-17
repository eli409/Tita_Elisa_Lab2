using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Tita_Elisa_Lab2.Models;

namespace Tita_Elisa_Lab2.Data
{
    public class Tita_Elisa_Lab2Context : DbContext
    {
        public Tita_Elisa_Lab2Context (DbContextOptions<Tita_Elisa_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Tita_Elisa_Lab2.Models.Book> Book { get; set; } = default!;
        public DbSet<Tita_Elisa_Lab2.Models.Publisher> Publisher { get; set; } = default!;
        public DbSet<Tita_Elisa_Lab2.Models.Author> Author { get; set; } = default!;
    }
}
