using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ProjAPI.Model;

namespace ProjAPI.Data
{
    public class ProjAPIContext : DbContext
    {
        public ProjAPIContext (DbContextOptions<ProjAPIContext> options)
            : base(options)
        {
        }

        public DbSet<ProjAPI.Model.Endereco> Endereco { get; set; }

        public DbSet<ProjAPI.Model.Passageiro> Passageiro { get; set; }
    }
}
