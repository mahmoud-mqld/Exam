using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class FinalExam : Exam
    {
        public FinalExam(int? time, int? numOfQuistions,  Quistion[] quistions) : base(time, numOfQuistions, quistions)
        {
        }

        public override void ShowExam()
        {
            //int? grade=0;

            //foreach (var question in Quistions) 
            //{ 
            //    question.ShowQuestion();
            //    grade = +question.Mark;

            //}

            //foreach (var question in Quistions)
            //{
            //    Console.WriteLine($"{question.Body} \n {question.Mark} \n {grade} marks  ");

            //}

            foreach (var question in Quistions)
            {
                question.ShowQuestion();
                //    Console.WriteLine();

            }
        }
            public override void StartExam()
        {
            int?totalMarks = 0;
            foreach (var question in Quistions)
            {
                question.ShowQuestion();
                Console.WriteLine("Your Answer: ");
                int userAnswer = Convert.ToInt32(Console.ReadLine());

                if (question.AnswerList[userAnswer - 1].ID == question.RightAnswer.ID)
                {
                    totalMarks += question.Mark;
                }
            }
            Console.WriteLine($"Total Marks: {totalMarks}");
        }
    }

    }
