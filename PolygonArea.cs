namespace polygons
{
    internal class Program 
    { 
        static void Main(string[] args) 
        {
            Console.WriteLine("How many sides does your polygon have?");
            Console.WriteLine("3 or 4");
            bool check = true;
            int sides = 0;
            while (check)
            {
                try
                {
                    sides = int.Parse(Console.ReadLine());
                        if (sides == 3 || sides == 4)
                    {
                        check = false;
                    } else
                    {
                        Console.WriteLine("Enter stated value");
                    }
                }
                catch
                {
                    Console.WriteLine("Enter stated value");
                }
            }
            Console.WriteLine("What is the height of the figure?");
            int height = 0;
            check = true;
            while (check)
            {
                try
                {
                    height = int.Parse(Console.ReadLine());
                    
                    check = false;
                }
                catch
                {
                    Console.WriteLine("Enter stated value");
                }
            }
            Console.WriteLine("What is the base of the figure?");
            int Base = 0 ;
            check = true;
            while (check)
            {
                try
                {
                     Base = int.Parse(Console.ReadLine());

                    check = false;
                }
                catch
                {
                    Console.WriteLine("Enter stated value");
                }
            }

            GettingArea(sides, height, Base);

        }

        static void GettingArea (int sides, int height, int Base)
        {
            int area = height * Base;

            if (sides == 3)
            {
                area = area / 2;
            }

            Console.WriteLine("The area of your figure is " + area);
        }
    }
}