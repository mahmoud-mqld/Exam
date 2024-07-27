﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam
{
    internal class TrueFalseQ : Quistion
    {
        public TrueFalseQ(string? header, string? body, int? mark, Answer[]? answerList, Answer? rightAnswer) : base(header ="Choose True Or False", body, mark, answerList , rightAnswer)
        {
           

        }

        public override void ShowQuestion()
        {
            if (AnswerList is not null) {

                Console.WriteLine($"{Header} : {Body} (Mark: {Mark}");
            foreach (var answer in AnswerList)
            {
                Console.WriteLine($"{answer.ID}. {answer.Text}");
            }
               

            }
            
        }
    }
}
