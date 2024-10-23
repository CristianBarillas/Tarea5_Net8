using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using ApiEmpresa2.Models;

    public class Conexiones : DbContext
    {
        public Conexiones (DbContextOptions<Conexiones> options)
            : base(options)
        {
        }

        public DbSet<ApiEmpresa2.Models.Clientes> Clientes { get; set; } = default!;
    }
