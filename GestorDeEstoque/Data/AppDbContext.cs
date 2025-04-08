using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GestorDeEstoque.Models;
using Microsoft.EntityFrameworkCore;

namespace GestorDeEstoque.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions options) : base(options) {}
        public DbSet<Item> WebApiItensDB { get; set;}
    }
}