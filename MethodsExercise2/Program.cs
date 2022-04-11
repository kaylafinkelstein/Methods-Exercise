using System;

namespace MethodsExercise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");

            string? userName = Console.ReadLine();


            Console.WriteLine("What is your favorite color?");

            string? color = Console.ReadLine();

            Console.WriteLine("What is your favorite animal (plural)?");

            string? animal = Console.ReadLine();


            Console.WriteLine("What is your favorite band?");

            string? band = Console.ReadLine();


            Console.WriteLine($"My name is {userName}.");
            Console.WriteLine($"I love {color} {animal}.");
            Console.WriteLine($"My {color} {animal} and I like to jam out to {band}");

            Console.WriteLine($"Give me a number:");

            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine($"Give me another number");

            int num2 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            var mySum = MyMethods.Sum(num1, num2);
            Console.WriteLine($"The sum of {num1} and {num2} is { mySum }");


            Console.WriteLine($"Give me a 3 digit number");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num3 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine($"Give me another random number");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num4 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            var myProduct = MyMethods.Multiply(num3, num4);
            Console.WriteLine($"The product of {num3} and {num4} is { myProduct}");

            Console.WriteLine($"Now, we're going to divide. Give me a number");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num5 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine($"Type another number to see your solution");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num6 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            var mySolution = MyMethods.Divide(num5, num6);
            Console.WriteLine($"The answer to {num5} divided by {num6} is {mySolution}");

            Console.WriteLine($"Lets use subtracrion. Give me any number");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num7 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            Console.WriteLine($"And one last random number");
//#pragma warning disable CS8604 // Possible null reference argument.
            int num8 = int.Parse(Console.ReadLine());
//#pragma warning restore CS8604 // Possible null reference argument.
            var mySubtract = MyMethods.Subtract(num7, num8);
            Console.WriteLine($"{num7} minus {num8} is");

            Console.WriteLine($"All your solutions in order should be {mySum}, {myProduct}, {mySolution}, and {mySubtract}");

        }
    }
}