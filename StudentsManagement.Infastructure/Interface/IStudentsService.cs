using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Infastructure.Interface
{
    public interface IStudentsService<Student>
    {
        public int CreateStudent();
        public int UpdateStudent();

        public int DeleteStudent();

        public Student GetStudentByName();

        public IEnumerable<Student> GetAllStudent();

    }
}
