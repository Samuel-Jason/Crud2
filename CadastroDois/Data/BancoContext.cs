using CadastroDois.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CadastroDois.Data
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext> options) : base(options)
        {
        }

        public DbSet<ClienteModel> Cliente { get; set; }
    }
}
