using DataAccess.StudentDB.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Infastructure.IReponsitory
{
    public interface IReponsitory<T> where T:BaseEntities
    {
        IEnumerable<T> GetAll();
        T GetById(int id);

    }
}
