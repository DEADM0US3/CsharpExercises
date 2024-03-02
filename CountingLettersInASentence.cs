namespace CountingWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            Console.WriteLine("Enter a sentence");
            string input = Console.ReadLine().Trim();
            string [] arrayInput = input.Split(' ');
            List <string> listInput = new List <string> (arrayInput);
            
            listInput.RemoveAll( x => x == " ");

            for (int i = 0; i < listInput.Count ; i++)
            {
                Console.WriteLine(listInput[i]);

                Console.WriteLine("The word " + listInput[i] + " have " + listInput[i].Length + " letters");
                count += listInput[i].Length;
                
            }

            Console.WriteLine("The sentence have " + count + " letters");
        }
    }
}