namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, What is your favorite color?");
            var color = Console.ReadLine();
            Console.WriteLine($"{color} is a neat color! What is your favorite animal?");
            var animal = Console.ReadLine();
            Console.WriteLine($"{animal}'s are awesome! What is your favorite band?");
            var band = Console.ReadLine();
            Console.WriteLine($"{band}! I love them too!");

            Console.WriteLine($"Okay {name}, Here is your profile:");
            Console.WriteLine($"Name: {name}");
            Console.WriteLine($"Favorite Color: {color}");
            Console.WriteLine($"Favorite Animal: {animal}");
            Console.WriteLine($"Favorite Band: {band}");
        }
    }
}
