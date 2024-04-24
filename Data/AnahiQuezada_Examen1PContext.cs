using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AnahiQuezada_Examen1P.Models;

namespace AnahiQuezada_Examen1P.Data
{
    public class AnahiQuezada_Examen1PContext : DbContext
    {
        public AnahiQuezada_Examen1PContext (DbContextOptions<AnahiQuezada_Examen1PContext> options)
            : base(options)
        {
        }

        public DbSet<AnahiQuezada_Examen1P.Models.AQ_CitaMedica> AQ_CitaMedica { get; set; } = default!;
    }
}
