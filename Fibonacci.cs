namespace Fibonacci
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int num1 = 0;
            int num2 = 1;

            for(int x = 0 ;  x < 50; x++)
            {

                int [] arrayNum = Fibonacci(num1, num2);
                num1 = arrayNum[0];
                num2 = arrayNum[1];
                Console.WriteLine(num1);

            }


        }

        static int [] Fibonacci ( int  num1, int num2)
        {
            int numEnReposo = num1;
            num1 += num2;
            num2 = numEnReposo;
            int [] arrayNum = {num1, num2};
            return arrayNum;

        }
    }
}