namespace MethodsExercise;

public class Program
{
    static void MadLib()
    {
        Console.WriteLine("What is your name?");
        string username = Console.ReadLine();
        Console.WriteLine("What is your favorite color?");
        string favcolor = Console.ReadLine();
        Console.WriteLine("What is your favorite animal?");
        string favanimal = Console.ReadLine();
        Console.WriteLine("Favorite band?");
        string favband = Console.ReadLine();

        Console.WriteLine(
            $"One day, {username} was walking through the woods while wearing a {favcolor} t-shirt. {username} saw a {favanimal} listening to {favband}.");
    }

    public static int Add(int numOne, int numTwo)
    {
        return numOne + numTwo;
    }

    public static int Subtract(int numOne, int numTwo)
    {
        return numOne - numTwo;
    }

    public static int Multiply(int numOne, int numTwo)
    {
        return numOne * numTwo;
    }

    public static int Divide(int numOne, int numTwo)
    {
        return numOne / numTwo;
    }

    public static int Sum(params int[] numbers)
    {
        int sum = 0;

        foreach (int number in numbers)
        {
            //sum = sum + number;
            sum += number;
        }

        return sum;
    }

    static void Main(string[] args)

        {
            MadLib();
            Console.WriteLine(Add(2, 2));
            Console.WriteLine(Subtract(2, 2));
            Console.WriteLine(Multiply(2, 2));
            Console.WriteLine(Divide(2, 2));
            Console.WriteLine(Sum(5, 5, 5));
        }
    }