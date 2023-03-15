using DataAccess.StudentDB;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Service.StudentResponsitory
{
    public interface IStudentRepo
    {
        IEnumerable<Student> GetAll();
        Student GetById(int id);
    }
}
