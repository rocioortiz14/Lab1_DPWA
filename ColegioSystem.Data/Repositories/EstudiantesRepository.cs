using ColegioSystem.Data.Interfaces;
using ColegioSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioSystem.Data.Repositories
{
    public class EstudiantesRepository : Repository<Estudiantes>, IEstudiantesRepository
    {
        private readonly ApplicationDbContext _db;
        public EstudiantesRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
