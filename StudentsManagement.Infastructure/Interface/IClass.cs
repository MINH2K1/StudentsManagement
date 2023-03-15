using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsManagement.Infastructure.Interface
{
    public interface IClass<Class>
    {
        public int CreateClass();
        public int UpdateClass();
        public int DeleteClass();

        public IEnumerable<Class> GetClass();

    }
}
