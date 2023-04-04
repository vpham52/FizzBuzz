namespace FizzBuzz;
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Please input number");
        var number = int.Parse(Console.ReadLine());

        Console.WriteLine(FizzBuzz(number));
    }

    public static string FizzBuzz(int userInput)
    {

        if (userInput % 3 == 0)
        {
            return "fizz";
        }

        if (userInput % 5 == 0)
        {
            return "buzz";
        }

        if (userInput % 3 == 0 && userInput % 5 == 0)
        {
            return "fizbuzz";
        }

        else
        {
            return "No fizzbuzz for you :(";
        }
    }
}

