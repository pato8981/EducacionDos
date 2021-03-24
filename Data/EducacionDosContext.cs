using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using EducacionDos.Models;

namespace EducacionDos.Data
{
    public class EducacionDosContext : DbContext
    {
        public EducacionDosContext (DbContextOptions<EducacionDosContext> options)
            : base(options)
        {
        }

        public DbSet<EducacionDos.Models.Alumno> Alumno { get; set; }

        public DbSet<EducacionDos.Models.Ciudad> Ciudad { get; set; }

        public DbSet<EducacionDos.Models.Curso> Curso { get; set; }

        public DbSet<EducacionDos.Models.Pais> Pais { get; set; }
    }
}
