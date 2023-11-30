using Microsoft.EntityFrameworkCore;
using Tarea_Colores.Models;

namespace Tarea_Colores
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        public DbSet<ColorModel> Colors { get; set; }
    }
}