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

        public Quistion[] Quistions { get; set; }

        protected Exam(int? time, int? numOfQuistions,  Quistion[] quistions)
        {
            Time = time;
            NumOfQuistions = numOfQuistions;
            Quistions = quistions;
        }

        public abstract void ShowExam();
        public abstract void StartExam();
    }




}
