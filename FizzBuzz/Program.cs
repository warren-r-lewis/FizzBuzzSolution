namespace FizzBuzz;

internal class Program
{
    static void Main(string[] args)
    {
        for (int num =1; num <= 100; num++)
        {
            if (num % 3 == 0)
            {
                if (num % 15 == 0)
                {
                    Console.WriteLine("Fizz Buzz");
                }
                else { Console.WriteLine("Fizz"); }

            }
            else if (num % 5 == 0)
            {
                Console.WriteLine("Buzz");
            }
            else { Console.WriteLine(num); }
        }

    }
}

