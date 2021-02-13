using ColegioSystem.Data.Interfaces;
using ColegioSystem.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace ColegioSystem.Data.Repositories
{
   public class DocentesRepository : Repository<Docentes>, IDocentesRepository 
    {
        private readonly ApplicationDbContext _db;
        public DocentesRepository(ApplicationDbContext db): base(db)
        {

        }
    }
}
