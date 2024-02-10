using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuizWork
{
    internal class Functionals
    {
        public void Funcs()
        {
            string[] quiz = new string[]
            {
            "Capital of France?:Paris",
            "Capital of Georgia?:Tbilisi",
            "Where is Berlin located?:Germany",
            "Where is China located?:Asia",
            "Capital of Italy?:Rome",

            "Capital of saudi arabia?:Riyadh",
            "Capital of UAE:Abhu dhabi",
            "Capital of Malaysia?:Kuala Lumpur",
            "Where is Egypt located?:Africa",
            "Capital of Mexico?:Mexico city",

            "Where is Canada located?:North America",
            "Capital of United states?:Washington DC",
            "Capital of UK?:London",
            "Where is Poland located?:Europe",
            "Capital of Russia?:Moscow",

            "Capital of Japan?:Tokyo",
            "Capital of China?:Beijing",
            "Where is Vienna located?:Austria",
            "Where is Canberra located?:Australia",
            "Capital of Portugal?:Lisbon",

            "What do people usually eat on Thanskgiving?:Turkey",
            "Who painted the Starry Night?:Vincent van Gogh",
            "Who carved the Statue of David?:Michelangelo",
            "Capital of Papua New Guinea?:Port Moresby",
            "Longest River in China?:Yangtze River",

            "Largest lake in the World?:Caspian Sea",
            "Capital of Netherlands?:Amsterdam",
            "What does OOP Mean?:Object Oriented Programming",
            "What does CSS Mean?:Cascading Style Sheets",
            "Who Painted The Last Supper?:Leonardo da Vinci"
            };

            using (StreamWriter qwrite = new StreamWriter("test.txt"))
            {
                foreach (string question in quiz)
                {
                    qwrite.WriteLine(question);
                }
            }

            string[] thinredline = File.ReadAllLines("test.txt");

            int points = 0;

            Random rnd = new Random();
            List<int> indexes = new List<int>();
            int index = 0;

            for (int i = 0; i < 5; i++)
            {

                index = rnd.Next(0, quiz.Length);
                var gg = quiz[index].Split(":");


                Console.WriteLine(gg[0]);



                var answer = Console.ReadLine();

                if (answer.ToLower() == gg[1].ToLower())
                {
                    Console.WriteLine("Correct");
                    ++points;
                }
                else
                {
                    Console.WriteLine($"Incorrect, answer was {gg[1]}");
                }

            }

            if (points == 5)
            {
                Console.WriteLine("Congratulations, you got all 5 points!");
            }
            if (points == 0)
            {
                Console.WriteLine("You got 0 points, try again?");

            }
            if (points != 0 && points != 5)
            {
                Console.WriteLine($"Congratulations, you got {points} out of 5 points");
            }
        }
    }
}
