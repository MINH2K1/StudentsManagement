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
    public class Repository<T> :IReponsitory<T>where T : BaseEntities
    {
        private readonly StudentsManagementDBContext _context;
        private readonly DbSet<T> entity;


        public Repository(StudentsManagementDBContext context)
        {
            _context = context;
          entity = _context.Set<T>();

        }
        public IEnumerable<T> GetAll()
        {
            return entity.AsEnumerable();
        }

        public T GetById(int id)
        {
            return entity.FirstOrDefault(x => x.Id == id);
        }
    }
}
