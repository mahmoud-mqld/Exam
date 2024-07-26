using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
     abstract class Exam
    {
        public int? Time {  get; set; } 
        public int? NumOfQuistions { get; set; }
        public Subject? Subject { get; set; }

        public Exam(int? time, int? numOfQuistions, Subject subject)
        {
            Time = time;
            NumOfQuistions = numOfQuistions;
            Subject = subject ?? throw new ArgumentNullException(nameof(subject));
        }

        public abstract void ShowExam();
    }




}
