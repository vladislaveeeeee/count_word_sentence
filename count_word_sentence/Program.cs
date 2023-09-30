using System;

namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter sentence: ");
            string sentence = Console.ReadLine();

            int words = 0;
            bool temp = true;
            int c_temp = 0;
            int lenOfSentence = sentence.Length;

            for (int i = 0; i < lenOfSentence; i++)
            {
                temp = true;
                c_temp++;
                if (sentence[i] == ' ')
                {
                    temp = false;
                    c_temp = 0;
                }
                else if (temp && c_temp == 1)
                {
                    words++;
                }
            }

            Console.WriteLine("Words in the sentence = " + words);
        }
    }
}