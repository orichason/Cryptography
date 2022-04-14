using System;

namespace VigenereCipher
{
    class Program
    {

        static string Encrypt(string message, string key, char[,] table)
        {
            string strengthenedKey = "";
            string encryptedMessage = "";

            for (int i = 0; i < message.Length; i++)
            {
                strengthenedKey += key[i % key.Length];
            }

            for (int i = 0; i < message.Length; i++)
            {
                if(message[i] == ' ')
                {
                    encryptedMessage += ' ';
                    continue;
                }

                int row = (int)message[i]- 'a';
                int col = (int)strengthenedKey[i] - 'a';
                char letter = table[row, col];

                encryptedMessage += letter;
                // add to encryptedMesssage
            }

            return encryptedMessage;
        }

        static string Decrypt(string encryptedMessage, string key, char[,] table)
        {
            string strengthenedKey = "";
            string decryptedMessage = "";

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                strengthenedKey += key[i % key.Length];
            }

            for (int i = 0; i < encryptedMessage.Length; i++)
            {
                if(encryptedMessage[i] == ' ')
                {
                    decryptedMessage += ' ';
                    continue;
                }

                int col = (int)(strengthenedKey[i] - 'a');

                int row = (int)(encryptedMessage[i] - table[0, col]);

                if(row < 0)
                {
                    row += 26;
                }    



                char letter = table[row, 0];

                decryptedMessage += letter;
            }

            return decryptedMessage;
        }

        static void Main(string[] args)
        {
            //create 2D array and put table in it. then do logic for encryption.
            char[,] table = new char[26, 26];

            for (int row = 0; row < 26; row++)
            {
                for (int col = 0, letter = 'a' + row; col < 26 - row; col++, letter++)
                {
                    table[row, col] = (char)letter;
                }

                for (int col = 26 - row, letter = 'a'; col < 26; col++, letter++)
                {
                    table[row, col] = (char)letter;
                }
            }

            PrintTable(table);

            string encryptedMessage = Encrypt("hello hello hello hello hello", "bathroom", table);
            Console.WriteLine(encryptedMessage);

            string decryptedMessage = Decrypt(encryptedMessage, "bathroom", table);
            Console.WriteLine(decryptedMessage);


        }

        private static void PrintTable(char[,] table)
        {
            for (int row = 0; row < table.GetLength(0); row++)
            {
                for (int col = 0; col < table.GetLength(1); col++)
                {
                    Console.Write($"{table[row, col]} ");
                }
                Console.WriteLine();
            }
        }
    }
}
