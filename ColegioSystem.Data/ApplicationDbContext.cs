using ColegioSystem.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioSystem.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }
    public DbSet<Docentes> Docentes { get; set; }
        public DbSet<Estudiantes> Estudiantes { get; set; }

        public DbSet<Materias> Materias { get; set; }
    }
}