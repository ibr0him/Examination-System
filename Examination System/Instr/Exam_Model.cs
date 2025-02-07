using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Examination_System.Instr
{
    public class Exam
    {
        public int Id { get; set; }
        public int Crs_Id { get; set; }
        public int Duration { get; set; }
        public int TF_NO { get; set; }
        public int MCQ_NO { get; set; }

        public Exam(int Id, int Crs_Id, int Duration, int TF_NO, int MCQ_NO)
        {
            this.Id = Id;
            this.Crs_Id = Crs_Id;
            this.Duration = Duration;
            this.TF_NO = TF_NO;
            this.MCQ_NO = MCQ_NO;
        }
    }

}
