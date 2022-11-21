namespace MethodsExercise
{
    public class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, What is your name?");
            //string userName = Console.ReadLine();

            //Console.WriteLine("What is your favorite color?");
            //string userColor = Console.ReadLine();

            //Console.WriteLine("What is youir favorite animal?");
            //string userAnimal = Console.ReadLine();

            //Console.WriteLine("What is your favorite band?");
            //string userBand = Console.ReadLine();

            //Console.WriteLine($"There once was a person named {userName}. {userName} could only see in different shades of {userColor}. Every day {userName} would sit on a bench to watch the {userColor} {userAnimal} while listing to his favorite songs from {userBand}.");

            //Additon//

            Console.WriteLine("Give me a number to add");
            int num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to add to the first one");
            int num2 = int.Parse(Console.ReadLine());

            int sum = Sum(num1, num2, 2, 3, 4);

            Console.WriteLine($"The sum is: {sum}");

            //Multiplication//

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to multiply to the first one");
            num2 = int.Parse(Console.ReadLine());

            int product = Multiply(num1, num2);

            Console.WriteLine($"The sum is: {product}");

            //Subtraction//

            Console.WriteLine("Give me a number");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to subtract from the first one");
            num2 = int.Parse(Console.ReadLine());

            int sub = Sub(num1, num2);

            Console.WriteLine($"The sum is: {sub}");

            //Division//

            Console.WriteLine("Give me a number to divide");
            num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Give me a number to divide by the first one");
            num2 = int.Parse(Console.ReadLine());

            int divide = Div(num1, num2);

            Console.WriteLine($"The sum is: {divide}");


            //end of main//
        }
        public static int Sum(params int[] list)
        {
            int sum = 0;

            for(int i = 0; i < list.Length; i++)
            {
                sum = sum + list[i];
            }

            return sum;
        }

        public static int Sub(int num1, int num2) 
        {
            return num1 - num2;
        }

        public static int Multiply(int x, int y)
        {
            return x * y;
        }

        public static int Div(int x, int y) 
        {
            return x / y;
        }
    }
}
