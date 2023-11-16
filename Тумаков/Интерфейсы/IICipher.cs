

namespace Тумаков
{
    internal interface IICipher
    {
        /// <summary>
        /// Шифровка
        /// </summary>
        /// <param name="letters"></param>
        void encode(string letters);
        /// <summary>
        /// дешифровка
        /// </summary>
        /// <param name="letters"></param>
        void decode(string letters);
    }
}
