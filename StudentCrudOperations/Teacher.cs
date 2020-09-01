using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentCrudOperations
{
    class Teacher
    {
        public string FullName => $"{Name} {Surname}";
        public int ID { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public List<Teacher> teacherList { get; set; }
    }
}
