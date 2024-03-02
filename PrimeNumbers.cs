namespace primeNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            for (int i = 2; i <= 100; i++) 
            {
                bool prime = Checking(i);
                
                if (prime == true)
                {
                    Console.WriteLine("Es un numero primo " + i);
                }
            } 

        }

        static bool Checking(int num)
        {
            for (int j = 2; j < num; j++)
            {
                if (num % j == 0)
                {
                    return false;
                }
            }

            return true;

        }
    }
}
