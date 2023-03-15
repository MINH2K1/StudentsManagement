using DataAccess.StudentDB.Entity;
using Microsoft.EntityFrameworkCore;
using StudentsManagement.DataAcces.DataContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Infastructure.IReponsitory
{
    public class Reponsitory<T> : IReponsitory<T> where T : BaseEntities
    {
        private readonly StudentsManagementDBContext _context;
        private readonly DbSet<T> entity;

        public Reponsitory(StudentsManagementDBContext context)
        {
            _context = context;
            entity = _context.Set<T>();
        }

        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }

        public T getById(int Id)
        {
            return entity.FirstOrDefault(x => x.Id == Id);
        }
    }
}
