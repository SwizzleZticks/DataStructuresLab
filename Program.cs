using System.Reflection.PortableExecutable;

namespace DataStructuresLab
{
    internal class Program
    {
        public static Stack<char> stack = new Stack<char>();
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a word to reverse: ");
            string? userInput = Console.ReadLine();

            Console.WriteLine($"Original word: {userInput}");
            Console.WriteLine($"Reversed word: {ReverseWord(userInput)}");

        }

        static string ReverseWord(string word)
        {
            for (int i = 0; i < word.Length; i++)
            {
                stack.Push(word[i]);
            }

            string reversedWord = string.Empty;

            while (stack.Count > 0)
            {
                reversedWord += stack.Pop();
            }

            return reversedWord;
        }
    }
}
