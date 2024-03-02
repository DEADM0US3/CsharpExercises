namespace FizzBuzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int x = 0 ;  x < 100; x++)
            {
                if(x % 5 == 0 & x % 3 == 0)
                {
                    Console.WriteLine("fizzbuzz");
                } else if ( x % 3 == 0)
                {
                    Console.WriteLine("buzz");
                } else if ( x % 2 == 0)
                {
                    Console.WriteLine("fizz");
                } else
                {
                    Console.WriteLine(x);
                }

            }

            Console.ReadLine();
        }
    }
}