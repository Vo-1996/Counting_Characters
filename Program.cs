using System;

namespace Counting_Characters // refer to folder
{
    class Program
    {
        public static void Counting_Characters(string word)
        {
            string newName = word.ToUpper();
            Dictionary<char, int> myString = new Dictionary<char, int>();

            foreach(char c in newName)
            {
                myString.TryGetValue(c, out int value);
                myString[c] = value +1;
            }

            foreach(var x in myString)
            {
                Console.WriteLine($"Numeber of character for : {x.Key} is {x.Value}");
            }
            Console.ReadLine();
        }
        public static void Main(string[] args)
        {
            string word = " Hello World I'm Counting!";
            Counting_Characters(word);
        }
    }
}