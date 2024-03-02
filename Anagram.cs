using System.ComponentModel.Design;

namespace Anagram
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter two words. The program have to check if the words are anagrams");
            Console.WriteLine("First Word");
            string firstWord = Console.ReadLine().ToLower();
            Console.WriteLine("Second Word");
            string secondWord = Console.ReadLine().ToLower();
            

            if (firstWord.Length == secondWord.Length)
            {

                try
                {
                    for (int i = 0; i < firstWord.Length; i++)
                    {
                        secondWord = CompareStrings( firstWord[i], secondWord);

                    }

                    Console.WriteLine("It was an anagram");
                }
                catch
                {
                    Console.WriteLine("It wasn´t an anagram");
                }

                } else
            {
                Console.WriteLine("These two words are not an anagram");
            }

        }

        static string CompareStrings( char firstChar, string secondWord)
        {
            int index = secondWord.IndexOf(firstChar);
            secondWord = secondWord.Remove(index, 1);
            Console.WriteLine(secondWord);
            Console.WriteLine("Si contabo con una " + firstChar);
            return secondWord;

        }
    }
}