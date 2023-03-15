using DataAccess.StudentDB.Entity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.StudentDB
{
    public class Student:BaseEntities
    {
        [Required]
        public string ?Name { get; set; }
        public string ?Address { get; set; }

        public DateTime Birth { get; set; }
        public float Math { get; set; }
        public float Physics { get; set; }

        public float Chemistry { get; set; }

        public int ClassId { get; set; }
        public Class ?Class { get; set; }

    }
}
