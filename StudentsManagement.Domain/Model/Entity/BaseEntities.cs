using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StudentDB.Entity
{
    public class BaseEntities
    {
        public int Id { get; set; }
        public bool isActive { get; set; } = false;
    }
}
