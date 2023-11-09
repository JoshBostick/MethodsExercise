namespace MethodsExercise
{
    public class Program
    {
        public static int Sum(int num1, int num2)
        {
            var answer = num1 + num2;
            return answer;
        }

        public static int Multiply(int num1, int num2, int num3)
        {
            return num1 * num2; 
        }


        static void Main(string[] args)
        {
            var total = Sum(4, 10);
            var blah = Multiply(15, 10, 8);

            //----------------Exercise 1----------------------
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
