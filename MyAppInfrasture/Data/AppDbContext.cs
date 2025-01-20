using Microsoft.EntityFrameworkCore;
using MyAppCore.Entites;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyAppInfrasture.Data
{
    public class AppDbContext(DbContextOptions<AppDbContext> options) : DbContext(options)
    {
        public DbSet<Products> Products { get; set; }
    }
   
}
