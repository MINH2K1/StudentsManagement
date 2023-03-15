using DataAccess.StudentDB;
using StudentsManagement.Infastructure.IReponsitory;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Service.StudentResponsitory
{
    public class StudentRepo : IStudentRepo
    {
        private IReponsitory<Student> _reponsitory;

        public StudentRepo(IReponsitory<Student> reponsitory)
        {
            _reponsitory = reponsitory;
        }
    
        public IEnumerable<Student> GetAll()
        {
            return _reponsitory.GetAll();
        }

        public Student GetById(int id)
        {
           return _reponsitory.GetById(id);
        }
    }
}

