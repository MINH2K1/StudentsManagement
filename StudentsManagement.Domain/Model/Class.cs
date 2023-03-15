using DataAccess.StudentDB.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StudentDB
{
    public class Class:BaseEntities
    {
        [Required]
        public string  ?ClassName { get; set; }

        [ForeignKey("ClassId")]
        public List<Student> ?Students { get; set; }
    }
}
