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

             Console.WriteLine($"One day, {username} was walking through the woods while wearing a {favcolor} t-shirt. {username} saw a {favanimal} listening to {favband}.");
         }
         static void Main(string[] args)
         {
             MadLib();
         }
}

