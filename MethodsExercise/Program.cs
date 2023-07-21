using System.ComponentModel.Design;

namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShortStory();

            double twoPlusfour = Add(2, 4);
            Console.WriteLine(twoPlusfour);

            double dividing = Divide(42, 7);
            Console.WriteLine(dividing);
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

            
                    

                
    }
}
