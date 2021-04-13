using System;

namespace VariablesCS
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("");

            Console.WriteLine("Variables, Variables, Variables!");

            Console.WriteLine("");

            var numberOfCoffeeCups = 1;
            var fullName = "Danny Le";
            var rightNow = DateTime.Now;

            Console.WriteLine($"I drink {numberOfCoffeeCups} cup of coffee a day, my name is {fullName}, and it is {rightNow} ");

            Console.WriteLine("");

            Console.Write("What is your name? ");

            var userName = Console.ReadLine();

            Console.WriteLine("");

            Console.WriteLine($"It's a pleasure {userName}!");

            if (userName == "Alice")

            {
                Console.WriteLine("But maybe you should stay away from rabbitholes...");
            }

            Console.WriteLine("");

            Console.Write("Can you give me a random number? ");

            var firstNumberAsString = Console.ReadLine();

            Console.WriteLine($"What a great number {firstNumberAsString} is!");

            Console.Write("Now how about another number? ");

            var secondNumberAsString = Console.ReadLine();

            Console.WriteLine($"Wow {secondNumberAsString} is another great number is!");

            Console.WriteLine("");

            Console.Write("Want to see them added together?");

            var sum = ($"{firstNumberAsString} + {secondNumberAsString}");

            var firstOperand = ($"{firstNumberAsString}");

            var secondOperand = ($"{secondNumberAsString}");

            var valueSum = double.Parse(firstOperand) + double.Parse(secondOperand);

            Console.WriteLine("");

            Console.WriteLine($"The anwser to {sum} is {valueSum}!");

            Console.WriteLine("");

            Console.Write("Now let's see them subtracted.");

            var difference = ($"{firstNumberAsString} - {secondNumberAsString}");

            var valueDifference = double.Parse(firstOperand) - double.Parse(secondOperand);

            Console.WriteLine("");

            Console.WriteLine($"The anwser to {difference} is {valueDifference}!");

            Console.WriteLine("");

            Console.Write("Multiplied.");

            var product = ($"{firstNumberAsString} * {secondNumberAsString}");

            var valueProduct = double.Parse(firstOperand) * double.Parse(secondOperand);

            Console.WriteLine("");

            Console.WriteLine($"{product} is {valueProduct}!");

            Console.WriteLine("");

            Console.Write("Divived!");

            var quotient = ($"{firstNumberAsString} * {secondNumberAsString}");

            var valueQuotient = double.Parse(firstOperand) * double.Parse(secondOperand);

            Console.WriteLine("");

            Console.WriteLine($"{quotient} is {valueQuotient}!");

            Console.WriteLine("");

            Console.Write("And finally a modulo operation...");

            var remainder = ($"{firstNumberAsString} % {secondNumberAsString}");

            var valueRemainder = double.Parse(firstOperand) % double.Parse(secondOperand);

            Console.WriteLine("");

            Console.WriteLine($"{remainder} is {valueRemainder}!");

            Console.WriteLine("");




        }
    }
}