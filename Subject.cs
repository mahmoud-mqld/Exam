using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
     class Subject
    {
        public int? ID {  get; set; }   
        public string? Name { get; set; }

        public Subject(int? iD, string? name)
        {
            ID = iD;
            Name = name;
        }

        public Exam? Exam { get; set; } 
   public override string ToString()
    {
        return $"Subject ID: {ID}, Subject Name: {Name}";
    }
        
        public void CreateExam(int examType, int time, int numberOfQuestions, Quistion[] questions) 
        {
            if (examType == 1)
            {
                Exam = new FinalExam(time, numberOfQuestions,  questions);
            }
            else if (examType == 2)
            {
                Exam = new PracticalExam(time, numberOfQuestions,  questions);
            }
        }
    } 
}

    
