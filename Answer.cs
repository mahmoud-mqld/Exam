using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    public class Answer
    {
        public int? ID {  get; set; }   
        public string? Text { get; set; }

        public Answer(int? iD, string? text)
        {
            ID = iD;
            Text = text;
        }
    }
}
