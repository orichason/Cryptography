using System;

namespace SubstitutionCipher
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();


            Console.WriteLine("Enter Message");

            string message = Console.ReadLine();

            char[] Encrypted = new char[message.Length];

            for (int i = 0; i < message.Length; i++)
            {
                Encrypted[i] = (char)gen.Next(97, 123);

            }
        }

        //DO THIS FOR ALL LETTERS IN THE ALPH REGARDLESS OF MESSAGE
    }
}
