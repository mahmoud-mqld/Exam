namespace Exam
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Subject ID");
            int.TryParse(Console.ReadLine(), out int SubjectId);
            Console.WriteLine("Enter Subject Name"); 
            string subjectName = Console.ReadLine();        

            Subject subject = new Subject(SubjectId, subjectName);

            Console.ReadLine();
            Console.WriteLine("Choose Exam Type: 1. Final 2. Practical");
            int examType = 0;
            int.TryParse(Console.ReadLine(), out examType);
            Console.WriteLine("Enter Exam time");
            int examTime = 0;
            int.TryParse(Console.ReadLine(), out examTime);
            Console.WriteLine("Enter Number Of Questions");
            int NumOfQ = 0;
            int.TryParse(Console.ReadLine(), out NumOfQ);


            if (examType == 1)
            {
                for (int i = 0; i < NumOfQ; i++)
                {
                    int typeOfQuestion = 0;

                    Console.WriteLine($"Choose Type of Q : {i} 1- True Or False , 2- MCQ ");
                    int.TryParse(Console.ReadLine(), out typeOfQuestion);
                    if (typeOfQuestion == 1)
                    {
                        Console.WriteLine($"Enter Question {i} Header ");
                        string header = Console.ReadLine();
                        Console.WriteLine($"Enter Question {i} Body");
                        string body = Console.ReadLine();
                        Console.WriteLine($"Enter Question {i} Mark");
                        int.TryParse(Console.ReadLine(), out int Mark);

                        Console.WriteLine($"Enter Question {i} Correct Answer ID ");
                        int.TryParse(Console.ReadLine(), out int RightAnswerId);
                        Answer[] answerList = new Answer[2]
                       {
                        new Answer(1, "True"),
                        new Answer(2, "False")
                        };
                        Answer rightAnswer = new Answer(RightAnswerId, RightAnswerId == 1 ? "True" : "False");
                        new TrueFalseQ(header, body, Mark, answerList, rightAnswer); 







                    }




                }




            }
        }
    }
}
