using System;

namespace Samples
{
    class Program
    {
        static void Main(string[] args)
        {
            int grade = 90;

            // Ternary operator
            #region Simple ternary operator
            //// using if else
            //if (grade >= 50)
            //{
            //    Console.WriteLine("He passed the exam");
            //}
            //else
            //{
            //    Console.WriteLine("Did not pass the exam");
            //}
            //// using ternary operator
            //var result = grade >= 0 ? "He passed the exam" : "He didn't pass the exam";
            //Console.WriteLine(result);
            #endregion

            #region Nested ternary operator
            // using nested if
            //if (grade >= 50)
            //{
            //    if (grade >= 90 && grade <= 100)
            //    {
            //        Console.WriteLine("He passed the exam with an excellent mark");
            //    }
            //    else
            //    {
            //        Console.WriteLine("He passed the exam");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("He didn't pass the exam");
            //}
            //// using nested ternary
            //var result = grade >= 50 ?
            //    grade >= 90 && grade <= 100 ?
            //    "He passed the exam with an excellent mark" :
            //    "He passed the exam" :
            //    "He didn't pass the exam";
            //Console.WriteLine(result);
            #endregion

            #region Compound ternary operator
            // using compound if
            var number = 10;
            //if (number > 0)
            //{
            //    Console.WriteLine("Positive");
            //}
            //else if (number < 0)
            //{
            //    Console.WriteLine("Negative");
            //}
            //else
            //{
            //    Console.WriteLine("Zero");
            //}
            // using compound ternary operator
            var result = number > 0 ? "Positive" : number < 0 ? "Negative" : "Zero";
            Console.WriteLine(result);
            #endregion
            Console.ReadLine();
        }
    }
}