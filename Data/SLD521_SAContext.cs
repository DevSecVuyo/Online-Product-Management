using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using SLD521_SA.Models;


namespace SLD521_SA.Data
{
    public class SLD521_SAContext(DbContextOptions<SLD521_SAContext> options) : DbContext(options)
    {
        public DbSet<SLD521_SA.Models.Product> Product { get; set; }
    }
}
