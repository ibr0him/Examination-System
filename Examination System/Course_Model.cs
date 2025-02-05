using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Course
    {
        public string Name { get; set; }
        public int Id { get; set; }
        public int StudentCount { get; set; }

        public Course(string name, int id, int studentCount)
        {
            Name = name;
            Id = id;
            StudentCount = studentCount;
        }
    }

}
