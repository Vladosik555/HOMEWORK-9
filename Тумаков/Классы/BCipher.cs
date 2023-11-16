using System;

namespace Тумаков
{
    internal class BCipher : IICipher
    {
        /// <summary>
        /// Метод ,который шифрует строку по i позиции символы
        /// </summary>
        private string letters { get; set; }
        public BCipher(string letters)
        {
            this.letters = letters;
        }
        public void encode(string letters)
        {
            string rus_letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] chars_rus = new char[rus_letters.Length];
            string anti_rus_letters = "яюэьыъщшчцхфутсрпонмлкйизжёедгвба";
            string eng_letters = "abcdefghijklmnopqrstuvwxyz";
            char[] chars_eng = new char[eng_letters.Length];
            string anti_eng_letters = "zyxwvutsrqponmlkjihgfedcba";
            string rus_eng_letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            for (int j = 0; j < letters.Length; j++)
            {
                int index = rus_eng_letters.IndexOf(letters[j]);
                if (index != -1)
                {
                    int index_1 = rus_letters.IndexOf(letters[j]);
                    if (index_1 != -1)
                    {
                        for (int i = 0; i < rus_letters.Length; i++)
                        {
                            if (letters[j] == rus_letters[i])
                            {
                                chars_rus[i] = anti_rus_letters[i];
                                Console.WriteLine($"У буквы {rus_letters[i]} i позиция {chars_rus[i]}");
                            }
                        }
                    }
                    else
                    {
                        for (int q = 0; q < eng_letters.Length; q++)
                        {
                            if (letters[j] == eng_letters[q])
                            {
                                chars_eng[q] = anti_eng_letters[q];
                                Console.WriteLine($"У буквы {eng_letters[q]} i позиция {chars_eng[q]}");
                            }
                        }
                    }
                }
                else
                {
                }
            }
        }
        /// <summary>
        /// Метод, который дешифрует строку по i позиции символу
        /// </summary>
        /// <param name="letters"></param>
        public void decode(string letters)
        {
            string rus_letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюя";
            char[] chars_rus = new char[rus_letters.Length];
            string anti_rus_letters = "яюэьыъщшчцхфутсрпонмлкйизжёедгвба";
            string eng_letters = "abcdefghijklmnopqrstuvwxyz";
            char[] chars_eng = new char[eng_letters.Length];
            string anti_eng_letters = "zyxwvutsrqponmlkjihgfedcba";
            string rus_eng_letters = "абвгдеёжзийклмнопрстуфхцчшщъыьэюяabcdefghijklmnopqrstuvwxyz";
            for (int j = 0; j < letters.Length; j++)
            {
                int index = rus_eng_letters.IndexOf(letters[j]);
                if (index != -1)
                {
                    int index_1 = rus_letters.IndexOf(letters[j]);
                    if (index_1 != -1)
                    {
                        for (int i = 0; i < rus_letters.Length; i++)
                        {
                            if (letters[j] == rus_letters[i])
                            {
                                chars_rus[i] = anti_rus_letters[i];
                                Console.WriteLine($"У буквы {rus_letters[i]} i позиция {chars_rus[i]}");
                            }
                        }
                    }
                    else
                    {
                        for (int q = 0; q < eng_letters.Length; q++)
                        {
                            if (letters[j] == eng_letters[q])
                            {
                                chars_eng[q] = anti_eng_letters[q];
                                Console.WriteLine($"У буквы {eng_letters[q]} i позиция {chars_eng[q]}");
                            }
                        }
                    }
                }
                else
                {
                }
            }
        }
    }
}
