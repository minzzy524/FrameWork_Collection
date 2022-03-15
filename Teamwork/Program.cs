using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Teamwork
{
    class Quiz_ask
    {
        Random random = new Random();
        int rand1;
        int rand2;
        Dictionary<string, string> x = new Dictionary<string, string>();

        public Quiz_ask()
        {
            for (int i = 0; i < 5; i++)
            {
                rand1 = random.Next(1, 10);
                rand2 = random.Next(1, 10);

                Console.Write($"{rand1} * {rand2} = ");
                string answer = Console.ReadLine();

                string result = (Quiz_answer(rand1, rand2) == Convert.ToInt32(answer)) ? "O" : "X";
                if (result == "O")
                {
                    Console.WriteLine("정답입니다.");

                }
                else
                {
                    Console.WriteLine("오답입니다.");
                }


                x.Add($"문제 : {rand1}*{rand2} 쓴답 : {answer}", $" 채점 : {result}");

            }

        }


        private int Quiz_answer(int rand1, int rand2)
        {
            return rand1 * rand2;
        }

        public void print()
        {
            foreach (var x in x)
            {
                Console.WriteLine($"{x.Key} {x.Value}");
            }
        }

    }


    class Program
    {
        static void Main(string[] args)
        {
            Quiz_ask quiz = new Quiz_ask();
            quiz.print();
        }
    }
}
