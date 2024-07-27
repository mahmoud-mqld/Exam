using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class PracticalExam : Exam
        
    {
        public PracticalExam(int? time, int? numOfQuistions, Quistion[] quistions) : base(time, numOfQuistions, quistions)
        {
        }

        public override void ShowExam()
        {
            int? grade = 0;

            foreach (var question in Quistions)
            {
                question.ShowQuestion();
                grade = +question.Mark;

            }

            foreach (var question in Quistions)
            {
                Console.WriteLine($"{question.Body} \n {question.Mark} \n {grade} marks  ");

            }
        }
        public override void StartExam()
        {
            foreach (var question in Quistions)
            {
                question.ShowQuestion();
                Console.WriteLine("Your Answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (question.AnswerList[userAnswer - 1].ID== question.RightAnswer.ID)
                {
                    Console.WriteLine("Correct!");
                }
                else
                {
                    Console.WriteLine($"Incorrect. The right answer is: {question.RightAnswer.Text}");
                }
            }
        }
    }

       
    
}
