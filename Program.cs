using System.ComponentModel.Design;

namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Subject ID");
            int.TryParse(Console.ReadLine(), out int SubjectId);
            Console.WriteLine("Enter Subject Name");
            string? subjectName = Console.ReadLine();

            Subject subject = new Subject(SubjectId, subjectName);
            Console.ReadLine();
            int ExamType, Time, NumOfQ;
            Answer[] answers = new Answer[2];
            do
            {
                Console.WriteLine("Choose Exam Type: 1. Final 2. Practical");
            }
            while (!int.TryParse(Console.ReadLine(), out ExamType) || ExamType < 1 || ExamType > 2);

            do
            {
                Console.WriteLine("Please Enter Time Of The Exam From (30 to 180 min):");
            }
            while (!int.TryParse(Console.ReadLine(), out Time) || Time < 30 || Time > 180);


            do
            {
                Console.WriteLine("Please Enter The Number of questions :");
            }
            while (!int.TryParse(Console.ReadLine(), out NumOfQ) || NumOfQ < 1);
            Quistion[] questions = new Quistion[NumOfQ];

            for (int i = 0; i < NumOfQ; i++)
            {
                int typeOfQuestion = 0;



                Console.WriteLine($"Enter Question {i + 1} Header "); 
                string? header = Console.ReadLine();
                Console.WriteLine($"Enter Question {i + 1} Body");
                string? body = Console.ReadLine();
                Console.WriteLine($"Enter Question {i + 1} Mark");
                int.TryParse(Console.ReadLine(), out int Mark);
                if (ExamType == 1)
                {
                    Console.WriteLine($"Choose Type of Q : {i + 1} 1- True Or False , 2- MCQ ");
                    int.TryParse(Console.ReadLine(), out typeOfQuestion);

                    if (typeOfQuestion == 1)
                    {

                        Console.WriteLine($"Enter Question {i + 1} Correct Answer ID ");
                        int.TryParse(Console.ReadLine(), out int RightAnswerId);
                        Answer[] answerList =
                       {
                        new Answer(1, "True"),
                        new Answer(2, "False")
                        }; 
                        Answer rightAnswer = new Answer(RightAnswerId, RightAnswerId == 1 ? "True" : "False");
                        new TrueFalseQ(header, body, Mark, answerList, rightAnswer);

                    }
                    else if (typeOfQuestion == 2 || ExamType == 2)

                    {
                        answers = new Answer[3];
                        for (int j = 0; j < 3; j++)
                        {
                            Console.WriteLine($"Enter text for option {j + 1}: ");
                            string? optionText = Console.ReadLine();
                            answers[j] = new Answer(j + 1, optionText);
                        }
                    }
                }
                Console.WriteLine("Enter the correct answer option number: ");
                int.TryParse(Console.ReadLine(), out int correctAnswerId);
                Answer RightAnswer = answers[correctAnswerId - 1];
                if (ExamType == 1)
                {
                    if (answers.Length == 2)
                    {
                        questions[i] = new TrueFalseQ(header, body, Mark, answers, RightAnswer);
                    }
                    else if (answers.Length >= 3||ExamType == 2) 
                    {
                        questions[i] = new MCQQ(header, body, Mark, answers, RightAnswer);
                    }
                }

              


            }


            subject.CreateExam(ExamType, Time, NumOfQ, questions);
            char c;
            do
            {
                Console.WriteLine("Do You Want to start the Exam (Y | N):");


            } while (!char.TryParse(Console.ReadLine(), out c));

            if (c == 'Y' || c == 'y')
            {

                subject?.Exam?.ShowExam();
                subject?.Exam?.StartExam();
            }
        }
    }
}
    

