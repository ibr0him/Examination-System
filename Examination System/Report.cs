using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System
{
    public class Report
    {
       public string Name { get; set; }
        public string Exec { get; set; }

        public Report(string name,string exec ) { 
        Name = name; 
            Exec = exec;
           
        }
    }
}
