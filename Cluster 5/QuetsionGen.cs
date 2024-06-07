using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cluster_5
{
    internal class QuetsionGen
    {
        private int RandomGen()
        {
            Random random = new Random();
            return random.Next(0, 11);
        }

        private int op()
        {
            Random rand = new Random();
            return rand.Next(0, 4);

        }

        private void question(out string Question, out int answer)
        {
            int operative = op();

            //operative = 0 means +
            if (operative == 0) 
            {
                int number = RandomGen();
                System.Threading.Thread.Sleep(1);
                int number2 = RandomGen();
                Question = number.ToString() + " + " + number2.ToString() + " = ";
                answer = number + number2;
            }
            //operative = 1 means -
            if (operative == 1)
            {
                int number = RandomGen();
                System.Threading.Thread.Sleep(1);
                int number2 = RandomGen();
                Question = number.ToString() + " - " + number2.ToString() + " = ";
                answer = number - number2;
            }
            //operative = 2 means *
            if (operative == 2)
            {
                int number = RandomGen();
                System.Threading.Thread.Sleep(1);
                int number2 = RandomGen();
                Question = number.ToString() + " x " + number2.ToString() + " = ";
                answer = number * number2;
            }
            //operative
            else
            {
                double number = RandomGen();
                System.Threading.Thread.Sleep(1);
                double number2 = RandomGen();
                while(number2 == 0)
                {
                    number2= RandomGen();
                }
            }

            while (true)
            {
                System.Threading.Thread.Sleep(100);

                Random random = new Random();
                int number1 = random.Next(0, 11);
                System.Threading.Thread.Sleep(1);
                int number2 = random.Next(0, 11);

                while (number2 == 0)
                {
                    number2 = random.Next(1, 11);
                }

                while (number1 % number2 != 0)
                {
                    number1 = random.Next(1, 11);
                }

                string question = $"{number1} / {number2}";
                int Danswer = number1 / number2;
                Console.WriteLine(question + " = " + Danswer.ToString());
            }

                        answer = 0;
            Question = string.Empty;
        }

        






    }
}
