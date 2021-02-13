using ColegioSystem.Data.Interfaces;
using ColegioSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioSystem.Data.Repositories
{
    public class MateriasRepository : Repository<Materias>, IMateriasRepository
    {
        private readonly ApplicationDbContext _db;
        public MateriasRepository(ApplicationDbContext db) : base(db)
        {

        }
    }
}
