using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Exam
{
    internal class Subject
    {
        public int? ID {  get; set; }   
        public string? Name { get; set; }    
        
       public Exam? Exam { get; set; } 
   public override string ToString()
    {
        return $"Subject ID: {ID}, Subject Name: {Name}";
    }

        public void CreateExam(Exam exam)
        {
            Exam = exam;
        }
    } 
}

    
