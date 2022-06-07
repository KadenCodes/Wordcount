//Prompt:
//Count Words in a String - Counts the number of individual words in a string. 
//For added complexity read these strings in from a text file and generate a summary.
using System;
namespace count
{
    static class Program
    {
        public static void Main()
        {
            Console.WriteLine("Please write a sentence in English. ");
            Console.Write("Type a string");
            string? words = Console.ReadLine();
            int? count = 0;
            foreach (Char WhiteSpace in words)
            {
                if (char.IsLetter(' '))
                {
                    count++;
                }
            }
            if (Convert.ToBoolean(count = 0))
            {
                count = 1;
            }
            else
            {
                count++;//?counts the first word of the string.
            }
            Console.WriteLine($"you have {count} words in your string");
        }
    }
}