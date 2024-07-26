using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
        
    {
        public PracticalExam(int? time, int? numOfQuistions, Subject subject) : base(time, numOfQuistions, subject)
        {
        }
        public override void ShowExam()
        {
            throw new NotImplementedException();
        }

        public override string? ToString()
        {
            return base.ToString();
        }
    }
}
