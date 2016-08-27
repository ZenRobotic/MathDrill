using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathDrill
{
    class Program
    {
        static void Main(string[] args)
        {
            // 1: Ask what digit the user wants to practice
            // 2: Record digit
            // 3: Begin asking user addition problems with the chosen digit up to 25 problems
            // 4: For each problem:
            //    a: Generate random single digit to add to selected digit
            //    b: Start stopwatch
            //    c: Ask problem
            //    d: Get input
            //    e: Check input
            //    f: Decide if correct and record correct answer time
            //    g: If incorrect, ask again
            // 5: Display statistics

            Console.WriteLine("enter digit of practice");
            var input = Console.ReadLine();
            Int32 n;
            Int32.TryParse(input, out n);
            var rng = new Random();
            var answers = new List<TimeSpan>();
            for (int i = 0; i < 25; i++)
            {
                var x = rng.Next(0, 10);
                Console.WriteLine($"{n} + {x}");
                var stopwatch = new Stopwatch();
                stopwatch.Start();
                var answer = Console.ReadLine();
                Int32 a;
                Int32.TryParse(answer, out a);
                if (n + x == a)
                {
                    answers.Add(stopwatch.Elapsed);



                }




            }


        }
    }
}
