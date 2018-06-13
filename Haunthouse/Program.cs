using System;

namespace MathTest
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            var questionHead = new Question(0,1,1,1);

            Random randomNum = new Random();
            var questionList = new QuestionList(questionHead);

            for (int i = 1; i < 5; i++)
            {
                float first = randomNum.Next(1, 99);
                float second = randomNum.Next(1, 99);
                int cal = randomNum.Next(1, 5);
                questionList.SetNext(new Question(i, first, second, cal));
            }
			
            MathGame(questionList);
            //questionList.DisplayAll();
		}


        public static void MathGame(QuestionList questionList)
        {

            var question = questionList.head.next;
            float result;
            question.DisplayThis();
            while (true)
            {   string input = Console.ReadLine();
                if (input != "end")
                {
                    question.answered = true;
                    bool parseSuc = float.TryParse(input, out result);
                    if (parseSuc)
                    {
                        if (Math.Abs(result - question.GetResult()) < 0.001f)
                        {
                            Console.WriteLine("Correct answer");
                        }
                        else
                        {
                            Console.WriteLine("Wrong answer");
                        }
                    }
                    else 
                    {
						Console.WriteLine("Wrong answer");
                    }
                    if (question.next != null)
                    {
                        question = question.next;
                        question.DisplayThis();
                    }
                    else { break; }
						
                }

                else { break; }
            }
               

        }
    }
}
