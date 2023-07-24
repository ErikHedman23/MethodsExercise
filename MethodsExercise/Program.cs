using System.ComponentModel.Design;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What would you like to do?  1 for Story; 2 for Math problems...");
            string select = Console.ReadLine();
            if (select == "1")
            {
                ShortStory();
            }

            else if (select == "2")
            {

                double twoPlusfour = Add(2, 4);
                Console.WriteLine(twoPlusfour);

                Add(78, 99);

                double dividing = Divide(42, 7);   
                Console.WriteLine(dividing);

                Console.WriteLine(Sum(23, 44, 32));
            }
             else if (select == "3")
            {
                Factorial();
            }
            else
            {
                While();
            }
         

        }

        public static void ShortStory()
        {
            Console.WriteLine("Greetings! What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine($"Nice to meet you {name}!\nTell me, what is your favorite color?");
            string color = Console.ReadLine();

            Console.WriteLine($"I see, I like {color} also.\n Tell me, what is your favorite animal?");
            string animal = Console.ReadLine();

            Console.WriteLine($"I love {animal}!\nNow then, what is your favorite band?");
            string band = Console.ReadLine();

            Console.WriteLine($"Oof, you really like {band}? Ok, well I'll see what I can do with all of this...");

            Console.WriteLine($"Once upon a time, {name} walked into a {color} mud puddle.\nHe quickly got up and found a {animal} standing in front of him!\nPanicking, {name} remebered a song from his fav band {band} and started singing it out loud to the {animal}.\nTo {name}'s surprise, this was the {animal}'s fav band and song too!\n{name} and {animal} became good friends for life after that moment.\n\nFIN");


        }

        public static double Add(double num1, double num2)
        {
            return num1 + num2;
        }

        public static double Divide(double num1, double num2)
        {
            return num1 / num2;
        }

        public static int Sum(params int[] numbers)
        {
            int sum = 0;
            foreach(int num in numbers)
            {
                sum += num;
            }
            return sum;
            //Multiplication is set up the sane way as addition but change + to *
        }

        public static double Subtract(params double[] numbers)
        {
            double difference = numbers[0];
            for (int i = 0; i < numbers.Length - 1; i++)
            {
                difference -= numbers[i = 1];
            }
            return difference;
            /* To subtract with paramsm you must use a for loop.
            Your index always starts at 0, so keep that in mind.
            .Length states the entirety of the array of numbers[].
            The .Length - 1 tells the program to stop after the last number in the index so that it actually has an integer to subtract.
            i++ tells the loop to increase in the iteration by +1 after each iteration.
            difference -= numbers[i = 1]; tells the loop to take the difference
            and subtract it by the next number in the iteration; instead of, subtracting it by itself; i.e.: index 0 - 0
            return difference means that it will return the difference because this is
            not a void method but rather a double method*/
           }
        public static void Factorial()
        {
            // Read an integer from the user and store it in the 'num' variable
            Console.WriteLine("Please input a number here:");
            
            int num = Convert.ToInt32(Console.ReadLine());

            // Initialize a variable called 'factorial' to 1
            int factorial = 1;

            // Start a loop that runs from 1 to 'num'
            for (int i = 1; i <= num; i++)
            {
                // Multiply the 'factorial' variable by the current value of 'i'
                factorial *= i;
            }

            // Print the result (the factorial value) to the console
            Console.WriteLine(factorial);

            /*if the int num = 3; the loop will look like this:
             i=1 * factorial (which = 1)
             i=2 * factorial = 2
             i=3 * factorial (which = 2) = 6
             End of for loop*/
        }
        public static void While()
        {
            int sum = 0;
            int num = 100;

            while (num >= 0)
            {
                sum += num;
                num--;
            }

            Console.WriteLine(sum);
        }
    }
}
