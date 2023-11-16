using System;

namespace Тумаков
{
    internal class ACipher : IICipher
    {
        private string letters { get; set; }
        public ACipher(string letters)
        {
            this.letters = letters;
        }
        /// <summary>
        /// Метод, который шифрует строку по следующему символу
        /// </summary>
        /// <param name="letters"></param>
        public void encode(string letters)
        {
            char[] chars = new char[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                chars[i] = letters[i];
                chars[i]++;
                if (letters[i] == 'z' || letters[i] == 'я')
                {
                    Console.WriteLine($"Буква: {letters[i]} является последней буквой алфавита");
                }
                else
                {
                    Console.WriteLine($"У буквы {letters[i]} следующая буква {chars[i]}");
                }

            }
        }
        /// <summary>
        /// Метод, который дешифрует строку по предыдущему символу
        /// </summary>
        /// <param name="letters"></param>
        public void decode(string letters)
        {
            char[] chars = new char[letters.Length];
            for (int i = 0; i < letters.Length; i++)
            {
                chars[i] = letters[i];
                chars[i]--;
                if (letters[i] == 'a' || letters[i] == 'а')
                {
                    Console.WriteLine($"Буква: {letters[i]} является первой буквой алфавита");
                }
                else
                {
                    Console.WriteLine($"У буквы {letters[i]} предыдущая буква {chars[i]}");
                }

            }
        }
    }
}
